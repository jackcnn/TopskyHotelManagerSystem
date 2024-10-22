﻿namespace TSHotelManagerSystem
{
    partial class FrmChangeWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangeWorker));
            this.btnWatchInfo = new System.Windows.Forms.Button();
            this.btnUpWorker = new System.Windows.Forms.Button();
            this.btnGoodBad = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblWorker = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWatchInfo
            // 
            this.btnWatchInfo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnWatchInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWatchInfo.BackgroundImage")));
            this.btnWatchInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWatchInfo.FlatAppearance.BorderSize = 0;
            this.btnWatchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatchInfo.Location = new System.Drawing.Point(14, 75);
            this.btnWatchInfo.Name = "btnWatchInfo";
            this.btnWatchInfo.Size = new System.Drawing.Size(72, 29);
            this.btnWatchInfo.TabIndex = 0;
            this.btnWatchInfo.Text = "查看信息";
            this.btnWatchInfo.UseVisualStyleBackColor = false;
            this.btnWatchInfo.Click += new System.EventHandler(this.btnWatchInfo_Click);
            // 
            // btnUpWorker
            // 
            this.btnUpWorker.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpWorker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpWorker.BackgroundImage")));
            this.btnUpWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpWorker.FlatAppearance.BorderSize = 0;
            this.btnUpWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpWorker.Location = new System.Drawing.Point(135, 75);
            this.btnUpWorker.Name = "btnUpWorker";
            this.btnUpWorker.Size = new System.Drawing.Size(72, 29);
            this.btnUpWorker.TabIndex = 1;
            this.btnUpWorker.Text = "职位任命";
            this.btnUpWorker.UseVisualStyleBackColor = false;
            this.btnUpWorker.Click += new System.EventHandler(this.btnUpWorker_Click);
            // 
            // btnGoodBad
            // 
            this.btnGoodBad.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGoodBad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoodBad.BackgroundImage")));
            this.btnGoodBad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoodBad.FlatAppearance.BorderSize = 0;
            this.btnGoodBad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoodBad.Location = new System.Drawing.Point(256, 75);
            this.btnGoodBad.Name = "btnGoodBad";
            this.btnGoodBad.Size = new System.Drawing.Size(72, 29);
            this.btnGoodBad.TabIndex = 2;
            this.btnGoodBad.Text = "奖罚情况";
            this.btnGoodBad.UseVisualStyleBackColor = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.BackgroundImage")));
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(377, 75);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(72, 29);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "打卡考勤";
            this.btnCheck.UseVisualStyleBackColor = false;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.BackColor = System.Drawing.Color.Transparent;
            this.lblWorker.Font = new System.Drawing.Font("隶书", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWorker.Location = new System.Drawing.Point(20, 9);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(343, 29);
            this.lblWorker.TabIndex = 108;
            this.lblWorker.Text = "XXX部XXX:XXX的操作界面";
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(453, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(20, 20);
            this.picClose.TabIndex = 109;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // FrmChangeWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(473, 134);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnGoodBad);
            this.Controls.Add(this.btnUpWorker);
            this.Controls.Add(this.btnWatchInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangeWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XXX员工操作";
            this.Load += new System.EventHandler(this.FrmChangeWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWatchInfo;
        private System.Windows.Forms.Button btnUpWorker;
        private System.Windows.Forms.Button btnGoodBad;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.PictureBox picClose;
    }
}