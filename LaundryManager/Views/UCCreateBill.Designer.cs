﻿
namespace LaundryManager.Views
{
    partial class UCCreateBill
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeOffsetEdit2 = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.dateTimeOffsetEdit1 = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(576, 592);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl2.Location = new System.Drawing.Point(576, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(717, 245);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.maskedTextBox7);
            this.groupControl1.Controls.Add(this.maskedTextBox6);
            this.groupControl1.Controls.Add(this.dateTimeOffsetEdit2);
            this.groupControl1.Controls.Add(this.dateTimeOffsetEdit1);
            this.groupControl1.Controls.Add(this.maskedTextBox5);
            this.groupControl1.Controls.Add(this.maskedTextBox4);
            this.groupControl1.Controls.Add(this.maskedTextBox3);
            this.groupControl1.Controls.Add(this.maskedTextBox2);
            this.groupControl1.Controls.Add(this.maskedTextBox1);
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(576, 245);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(717, 347);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "ĐIỀN THÔNG TIN";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(574, 300);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 23);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Tạo phiếu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Location = new System.Drawing.Point(117, 254);
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox7.TabIndex = 20;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(117, 193);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox6.TabIndex = 19;
            // 
            // dateTimeOffsetEdit2
            // 
            this.dateTimeOffsetEdit2.EditValue = null;
            this.dateTimeOffsetEdit2.Location = new System.Drawing.Point(436, 133);
            this.dateTimeOffsetEdit2.Name = "dateTimeOffsetEdit2";
            this.dateTimeOffsetEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeOffsetEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateTimeOffsetEdit2.TabIndex = 18;
            // 
            // dateTimeOffsetEdit1
            // 
            this.dateTimeOffsetEdit1.EditValue = null;
            this.dateTimeOffsetEdit1.Location = new System.Drawing.Point(117, 84);
            this.dateTimeOffsetEdit1.Name = "dateTimeOffsetEdit1";
            this.dateTimeOffsetEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeOffsetEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateTimeOffsetEdit1.TabIndex = 17;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(117, 302);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(419, 21);
            this.maskedTextBox5.TabIndex = 16;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(436, 254);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox4.TabIndex = 15;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(436, 193);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox3.TabIndex = 14;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(436, 36);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox2.TabIndex = 13;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(117, 136);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 11;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(326, 262);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(51, 13);
            this.labelControl11.TabIndex = 10;
            this.labelControl11.Text = "Thành tiền";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(326, 201);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 13);
            this.labelControl10.TabIndex = 9;
            this.labelControl10.Text = "Điện thoại";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(326, 144);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Ngày hẹn";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(326, 92);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Trạng thái";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(326, 44);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Chiết khấu ( % )";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(38, 310);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Địa chỉ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(38, 262);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Phụ thu";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(38, 201);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tổng tiền";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(38, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên khách";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ngày lập";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số phiếu";
            // 
            // UCCreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCCreateBill";
            this.Size = new System.Drawing.Size(1293, 592);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dateTimeOffsetEdit2;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dateTimeOffsetEdit1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}