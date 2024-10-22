﻿namespace TSHotelManagerSystem
{
    partial class FrmChangePosition
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtworkerId = new System.Windows.Forms.TextBox();
            this.txtworkerName = new System.Windows.Forms.TextBox();
            this.cboClub = new System.Windows.Forms.ComboBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.cboNewPosition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboNewClub = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "原属部门";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "员工职位";
            // 
            // txtworkerId
            // 
            this.txtworkerId.Location = new System.Drawing.Point(74, 9);
            this.txtworkerId.Name = "txtworkerId";
            this.txtworkerId.ReadOnly = true;
            this.txtworkerId.Size = new System.Drawing.Size(100, 21);
            this.txtworkerId.TabIndex = 4;
            // 
            // txtworkerName
            // 
            this.txtworkerName.Location = new System.Drawing.Point(74, 35);
            this.txtworkerName.Name = "txtworkerName";
            this.txtworkerName.Size = new System.Drawing.Size(100, 21);
            this.txtworkerName.TabIndex = 5;
            // 
            // cboClub
            // 
            this.cboClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClub.FormattingEnabled = true;
            this.cboClub.Items.AddRange(new object[] {
            "人事部",
            "酒店部",
            "财务部",
            "商品部",
            "后勤部",
            "经理部"});
            this.cboClub.Location = new System.Drawing.Point(74, 61);
            this.cboClub.Name = "cboClub";
            this.cboClub.Size = new System.Drawing.Size(100, 20);
            this.cboClub.TabIndex = 6;
            // 
            // cboPosition
            // 
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Items.AddRange(new object[] {
            "职员",
            "经理",
            "总经理"});
            this.cboPosition.Location = new System.Drawing.Point(74, 86);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(100, 20);
            this.cboPosition.TabIndex = 7;
            // 
            // cboNewPosition
            // 
            this.cboNewPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewPosition.FormattingEnabled = true;
            this.cboNewPosition.Items.AddRange(new object[] {
            "职员",
            "经理",
            "总经理"});
            this.cboNewPosition.Location = new System.Drawing.Point(241, 86);
            this.cboNewPosition.Name = "cboNewPosition";
            this.cboNewPosition.Size = new System.Drawing.Size(100, 20);
            this.cboNewPosition.TabIndex = 9;
            this.cboNewPosition.TextChanged += new System.EventHandler(this.cboNewPosition_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "调任职位";
            // 
            // cboNewClub
            // 
            this.cboNewClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewClub.FormattingEnabled = true;
            this.cboNewClub.Items.AddRange(new object[] {
            "人事部",
            "酒店部",
            "财务部",
            "商品部",
            "后勤部",
            "经理部"});
            this.cboNewClub.Location = new System.Drawing.Point(241, 60);
            this.cboNewClub.Name = "cboNewClub";
            this.cboNewClub.Size = new System.Drawing.Size(100, 20);
            this.cboNewClub.TabIndex = 11;
            this.cboNewClub.TextChanged += new System.EventHandler(this.cboNewClub_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "调任部门";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(361, 83);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(67, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "任命";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmChangePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 121);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboNewClub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboNewPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.cboClub);
            this.Controls.Add(this.txtworkerName);
            this.Controls.Add(this.txtworkerId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangePosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "将XXX任命为XXX";
            this.Load += new System.EventHandler(this.FrmChangePosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtworkerId;
        private System.Windows.Forms.TextBox txtworkerName;
        private System.Windows.Forms.ComboBox cboClub;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.ComboBox cboNewPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboNewClub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOK;
    }
}