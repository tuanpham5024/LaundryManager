﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManager.Views
{
    public partial class fCreateBill : DevExpress.XtraEditors.XtraForm
    {
        public fCreateBill()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }

        double totalBill = 0;
        private void fCreateBill_Load(object sender, EventArgs e)
        {
            gcCart.DataSource = SampleDS();
            txtBillCode.Text = Models.Connection.ExcuteScalar(String.Format("SELECT dbo.fcgetBillCode()"));
        }

        BindingList<BillDetails> ds = new BindingList<BillDetails>();
        public BindingList<BillDetails> SampleDS()
        {
            
            return ds;
        }
        
        public class BillDetails
        {
            public string ServID { get; set; }
            public string ServiceNameBD { get; set; }
            public Int32 Quantity { get; set; }
            public double Total { get; set; }

            public BillDetails()
            {
            }

            public BillDetails(string serviceID, string serviceName, int quantity, double total)
            {
                ServID = serviceID;
                ServiceNameBD = serviceName;
                Quantity = quantity;
                Total = total;
            }
        }

        IDictionary<string, int> serviceList = new Dictionary<string, int>();
        private void ribtnAdd_Click(object sender, EventArgs e)
        {
            object value;

            int rowIndex = gvServiceList.FocusedRowHandle;

            // Lấy id
            string colFieldID = "ID";
            value = gvServiceList.GetRowCellValue(rowIndex, colFieldID);
            string serviceID = value.ToString();

            // Lấy tên
            string colFieldName = "ServiceName";
            value = gvServiceList.GetRowCellValue(rowIndex, colFieldName);
            string serviceName = value.ToString();

            // Lấy đơn giá
            string colFieldPrice = "Price";
            value = gvServiceList.GetRowCellValue(rowIndex, colFieldPrice);
            string s = value.ToString();
            double price = double.Parse(s);


            double total = price; // Thành tiền


            bool flag = false; // Biến kiểm tra service có trong gvCart chưa
            var quantity = 1; // Biến đếm số lượng trong gvCart

            // Check xem có trong gvCart chưa 
            foreach (KeyValuePair<string, int> kvp in serviceList)
            {
                var key = kvp.Key;
                if (key == serviceID)
                {
                    flag = true;
                    quantity = kvp.Value;
                }    
            }    

            // Nếu tồn tại trong gvCart thì tăng số lượng lên 1
            if (flag == true)
            {
                quantity++;
                int temp = quantity; 
                total = total * quantity; // Thành tiền bằng 
                totalBill = total;
                serviceList[serviceID] = quantity; // gán lại cho hashtable
                // So sánh serviceID gvServiceList vs ...gvCart
                int count = gvCart.DataRowCount;          
                for (int idx = 0; idx < count; idx++)
                {
                    string servID = (string)gvCart.GetRowCellValue(idx, "ServID");
                    if (serviceID == servID)
                    {
                        
                        gvCart.SetRowCellValue(idx, "Quantity", temp);
                        gvCart.SetRowCellValue(idx, "Total", total);
                        break;
                    }    
                }   
            }
            else // KHÔNG TỒN TẠI THÌ THÊM MỚI
            {
                serviceList.Add(serviceID, 1);
                ds.Add(new BillDetails(serviceID ,serviceName, 1, total));
                totalBill += total;
            }
            txtTotal.Text = totalBill.ToString();
            txtTotal1.Text = totalBill.ToString();
        }

        private void riBtnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = gvCart.FocusedRowHandle;
            string colFieldName = "ServID";
            object value = gvCart.GetRowCellValue(rowIndex, colFieldName);
            string str = (string)value;
            serviceList.Remove(str);
            gvCart.DeleteRow(gvCart.FocusedRowHandle);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string billCode = txtBillCode.Text;

            string strBillDate = dtBillDate.Text;
            DateTime billDate = DateTime.Parse(strBillDate);

            string strAppointmentDate = dtAppointmentDate.Text;
            DateTime appointmentDate = DateTime.Parse(strAppointmentDate);

            string customerName = txtCustomerName.Text;
            string phone = txtPhone.Text;

            string address = txtAddress.Text;

            string total = txtTotal.Text; // Tiền khi chưa chiết khẩu

            string strDiscount = txtDiscount.Text;
            double discount = double.Parse(strDiscount);

            string strSurcharge = txtSurcharge.Text;
            double surcharge = double.Parse(strSurcharge);

            string strTotal1 = txtTotal1.Text; // Tiền sau khi đã chiết khẩu
            double total1 = double.Parse(strTotal1);

            string note = txtNote.Text;
            string status = cbStatus.GetItemText(cbStatus.SelectedItem);


            int userID = fLogin.userID;
            // INSERT CUSTOMER
            Controllers.CustomerController.InsertCustomer(customerName, address, phone, total1);


            // Lấy id Customer vừa thêm vào
            int cusID = Controllers.CustomerController.GetID();
            // INSERT BILL
            string s = txtDiscount.Text;
            double d;
            try
            {
                d = double.Parse(s);
            }
            catch
            {
                d = 100;
            }
            double discountMoney = totalBill * (discount / 100.0);

            Controllers.BillsController.InsertBill(billCode, cusID, userID, billDate, appointmentDate, discountMoney, surcharge, note, total1);

            // INSERT BILLDETAILS - 1. Lấy các row trong gcCart - 2. Insert lần lượt vào trong db

            for (int i = 0; i < gvCart.DataRowCount; i++)
            {
                // Lấy servID, quantity , total , : price = total / quantity
                object value;
                value = gvCart.GetRowCellValue(i, "ServID");
                string servID = (string)value;

                // Quantity
                value = gvCart.GetRowCellValue(i, "Quantity");
                int quantity = (int)value;


                // Price 
                value = gvCart.GetRowCellValue(i, "Total");
                double totalBillDetails = (double)value;
                double pricez = totalBillDetails / quantity;

                Controllers.BillDetailsController.InsertBillDetails(billCode, servID, quantity, pricez, totalBillDetails);
            }
            this.Close();

       //     

        }

        private void riBtnRemove_Click(object sender, EventArgs e)
        {
            object value;

            int rowIndex = gvServiceList.FocusedRowHandle;

            // Lấy id
            string colFieldID = "ID";
            value = gvServiceList.GetRowCellValue(rowIndex, colFieldID);
            string serviceID = value.ToString();

            // Lấy số lượng 
            string colFieldQuantity = "Quantity";
            value = gvCart.GetRowCellValue(rowIndex, colFieldQuantity);
            string squantity;
            if (value == null)
            {
                squantity = "";
            }    
            squantity = value.ToString();
            int quantity;
            if (squantity == "")
            {
                quantity = 0;
            }
            else
            {
                quantity = int.Parse(squantity);
            }    

            // Lấy thành tiền
            string colFieldTotal = "Total";
            value = gvCart.GetRowCellValue(rowIndex, colFieldTotal);
            string s = value.ToString();
            double total = double.Parse(s);

            // Lấy price

            double price = total / quantity;

           

            if (quantity <= 1)
            {
                string colFieldName = "ServID";
                value = gvCart.GetRowCellValue(rowIndex, colFieldName);
                string str = (string)value;
                totalBill = totalBill - price;
                txtTotal.Text = totalBill.ToString();
                txtTotal1.Text = totalBill.ToString();
                serviceList.Remove(str);
                gvCart.DeleteRow(gvCart.FocusedRowHandle);
            }
            else
            {


                quantity--;
                int temp = quantity;
                total = total - price; // Thành tiền bằng 
                serviceList[serviceID] = quantity; // gán lại cho hashtable
                 // So sánh serviceID gvServiceList vs ...gvCart
                int count = gvCart.DataRowCount;
                for (int idx = 0; idx < count; idx++)
                {
                    string servID = (string)gvCart.GetRowCellValue(idx, "ServID");
                    if (serviceID == servID)
                    {

                        gvCart.SetRowCellValue(idx, "Quantity", temp);
                        gvCart.SetRowCellValue(idx, "Total", total);
                        totalBill -= price;
                        txtTotal.Text = totalBill.ToString();
                        txtTotal1.Text = totalBill.ToString();
                        break;
                    }
                }
            }    
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            string s = txtDiscount.Text;
            double discount;
            try
            {
                discount = double.Parse(s);
            }
            catch
            {
                discount = 100;
            }
            double total = totalBill * (discount / 100.0);
            total = totalBill - total;
            txtTotal1.Text = total.ToString();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSurcharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSurcharge_TextChanged(object sender, EventArgs e)
        {
            double x = double.Parse(txtTotal1.Text);
            double y;
            try
            {
                y = double.Parse(txtSurcharge.Text);

            }
            catch
            {
                y = 0;
            }
            txtTotal1.Text = (x + y).ToString();
        }
    }
}