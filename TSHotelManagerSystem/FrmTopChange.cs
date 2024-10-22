﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSHotelManagerSystem.DAL;

namespace TSHotelManagerSystem
{
    public partial class FrmTopChange : Form
    {
        public static string wk_WorkerNo;
        public static string wk_WorkerName;
        public static string wk_WorkerBirthday;
        public static string wk_WorkerSex;
        public static string wk_WorkerTel;
        public static string wk_WorkerClub;
        public static string wk_WorkerAddress;
        public static string wk_WorkerPosition;
        public static string wk_WorkerID;
        public static string wk_WorkerPwd;
        public static string wk_WorkerTime;
        public static string wk_WorkerFace;

        public FrmTopChange()
        {
            InitializeComponent();
        }

        public void CmpSetDgv()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvWorkerList.AllowUserToAddRows = false;
            this.dgvWorkerList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvWorkerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorkerList.BackgroundColor = System.Drawing.Color.White;
            this.dgvWorkerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorkerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvWorkerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorkerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkerList.EnableHeadersVisualStyles = false;
            this.dgvWorkerList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvWorkerList.ReadOnly = true;
            this.dgvWorkerList.RowHeadersVisible = false;
            this.dgvWorkerList.RowTemplate.Height = 23;
            this.dgvWorkerList.RowTemplate.ReadOnly = true;
        }

        private void FrmTopChange_Load(object sender, EventArgs e)
        {
            CmpSetDgv();
            dgvWorkerList.DataSource = WorkerService.SelectWorkerAll();
        }

        private void dgvWorkerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvWorkerList.Rows.Count > 1)
            {
                wk_WorkerNo = dgvWorkerList.SelectedRows[0].Cells["clWorkerNo"].Value.ToString();
                wk_WorkerName = dgvWorkerList.SelectedRows[0].Cells["clWorkerName"].Value.ToString();
                wk_WorkerBirthday = dgvWorkerList.SelectedRows[0].Cells["clWorkerBirth"].Value.ToString();
                wk_WorkerSex = dgvWorkerList.SelectedRows[0].Cells["clWorkerSex"].Value.ToString();
                wk_WorkerTel = dgvWorkerList.SelectedRows[0].Cells["clWorkerTel"].Value.ToString();
                wk_WorkerClub = dgvWorkerList.SelectedRows[0].Cells["clWorkerClub"].Value.ToString();
                wk_WorkerAddress = dgvWorkerList.SelectedRows[0].Cells["clWorkerAddress"].Value.ToString();
                wk_WorkerPosition = dgvWorkerList.SelectedRows[0].Cells["clWorkerPosition"].Value.ToString();
                wk_WorkerID = dgvWorkerList.SelectedRows[0].Cells["clWorkerID"].Value.ToString();
                wk_WorkerPwd = dgvWorkerList.SelectedRows[0].Cells["clWorkerPwd"].Value.ToString();
                wk_WorkerTime = dgvWorkerList.SelectedRows[0].Cells["clWorkerTime"].Value.ToString();
                wk_WorkerFace = dgvWorkerList.SelectedRows[0].Cells["clWorkerFace"].Value.ToString();
                FrmChangeWorker aff = new FrmChangeWorker();
                aff.Show();
            }
        }

        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            dgvWorkerList.DataSource = WorkerService.SelectWorkerAll();
        }
    }
}
