﻿using DevExpress.XtraEditors;
using LaundryManager.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaundryManager
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check ô đăng nhập có dữ liệu không
            if (txtUsername.Text == "")
            {
                XtraMessageBox.Show("Tên đăng nhập không được để trống");
                return;
            }
            else
            {
                if (txtPassword.Text == "")
                {
                    XtraMessageBox.Show("Mật khẩu không được để trống.");
                    return;
                }
            }

            // Có data trong ô textbox 
            string check = "";
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            check = Controllers.LoginController.CheckLogin(user, pass);

            if (check == "")
            {
                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }  
            else
            {
                fLaunryManager fLaunry = new fLaunryManager();
                this.Hide();
                fLaunry.ShowDialog();
                this.Close();
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult _dialog = MessageBox.Show("Bạn có muốn thoát chương trình? ", "Thông báo!", MessageBoxButtons.YesNoCancel);
            if (_dialog == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
