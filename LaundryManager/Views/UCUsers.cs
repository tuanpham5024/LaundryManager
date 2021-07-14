﻿using DevExpress.XtraEditors;
using System;
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
    public partial class UCUsers : DevExpress.XtraEditors.XtraUserControl
    {
        public UCUsers()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            fSignUp fCreateUser = new fSignUp();
            fCreateUser.ShowDialog();
            sqlDataSource1.FillAsync();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = gvUsers.FocusedRowHandle;
            string colFieldUser = "UserName";
            object value = gvUsers.GetRowCellValue(rowIndex, colFieldUser);

            string user = (string)value;

            MessageBox.Show(user);

            
            if (value != null)
            {
                DialogResult _dialog = MessageBox.Show("Bạn có muốn xoá dịch vụ này không? ", "Thông báo!", MessageBoxButtons.YesNo);
                if (_dialog == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _ = Controllers.UserController.DeleteUser(user);
                        XtraMessageBox.Show("Xoá thành công!");
                        // SELECT Services.ID, ServiceName, Unt.Unit, Price, Services.Note FROM dbo.Services LEFT JOIN dbo.Units Unt ON Unt.ID = Services.UnitID
                        sqlDataSource1.FillAsync();
                    }
                    catch
                    {
                        XtraMessageBox.Show("Loi");
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn đối tượng xoá", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             
             

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            object value;
            // Lấy userName
            int rowIndex = gvUsers.FocusedRowHandle;
            string colFieldUser = "UserName";
            value = gvUsers.GetRowCellValue(rowIndex, colFieldUser);

            string user = (string)value;

            // Lấy FullName

            string colFieldName = "FullName";
            value = gvUsers.GetRowCellValue(rowIndex, colFieldName);
            string fullName = (string)value;
            // Lấy ngày sinh
            string colFieldBirthday = "BirthDay";
            value = gvUsers.GetRowCellValue(rowIndex, colFieldBirthday);
            DateTime birthDay = DateTime.Parse(value.ToString());


            // Lấy số điẹn thoại
            string colFieldPhone = "Mobile";
            value = gvUsers.GetRowCellValue(rowIndex, colFieldPhone);
            string phone = (string)value;

            // Lấy địa chỉ
            string colFieldAddress = "Address";
            value = gvUsers.GetRowCellValue(rowIndex, colFieldAddress);
            string address = (string)value;

            // Lấy id card;
            string colFieldIDCard = "IDCardNumber";
            value = gvUsers.GetRowCellValue(rowIndex, colFieldIDCard);
            string idCard = (string)value;

            // Lấy status
            string colFieldStatus = "Status";
            value = gvUsers.GetRowCellValue(rowIndex, colFieldStatus);
            bool status = (bool)value;

            fEditUser feditUser = new fEditUser(user, fullName, birthDay, phone, address, idCard, status);
            feditUser.ShowDialog();
            sqlDataSource1.FillAsync();
        }
    }
}
