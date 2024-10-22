﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TSHotelManagerSystem.Properties;
using TSHotelManagerSystem.BLL;
using TSHotelManagerSystem.Models;
using DevComponents.DotNetBar;

namespace TSHotelManagerSystem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            #region 防止背景闪屏方法
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲 
            #endregion
            Control.CheckForIllegalCrossThreadCalls = false;//关闭线程检查
            Main = this;//储存主窗口实例对象
        }

        public static FrmMain Main;//全局保存主窗口实例对象
        //private MyRoom Myroom;//房态图对象

        public static string wk_WorkerName;
        public static string wk_WorkerNames;

        #region 调用windows的系统锁定
        [DllImport("user32 ")]
        public static extern bool LockWorkStation();//这个是调用windows的系统锁定  
        #endregion

        #region 窗体渐变相关代码
        private bool showing = true; 
        #endregion

        #region 记录鼠标和窗体坐标的方法
        private Point mouseOld;//鼠标旧坐标
        private Point formOld;//窗体旧坐标 
        #endregion

        #region 记录移动的窗体坐标
        private void FrmMain_MouseDown_1(object sender, MouseEventArgs e)
        {
            formOld = this.Location;
            mouseOld = MousePosition;
        }
        #endregion

        #region 记录窗体移动的坐标
        private void FrmMain_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouseNew = MousePosition;
                int moveX = mouseNew.X - mouseOld.X;
                int moveY = mouseNew.Y - mouseOld.Y;
                this.Location = new Point(formOld.X + moveX, formOld.Y + moveY);
            }
        }
        #endregion

        #region 定时器：当前系统时间
        private void tmrDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = System.DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region 从数据库读取文字滚动的内容
        static FontsManager fontsManager = new FontsManager();
        List<Fonts> fonts = fontsManager.SelectFontAll();
        int fontn = 0; 
        #endregion

        #region 定时器：文字滚动间隔
        private void tmrFont_Tick(object sender, EventArgs e)
        {
            lblScroll.Location = new Point(lblScroll.Location.X - 8, lblScroll.Location.Y);
            if (lblScroll.Location.X + lblScroll.Width <= 8)
            {
                fontn++;
                if (fontn == fonts.Count)
                {
                    fontn = 0;
                }
                lblScroll.Text = fonts[fontn].FontsMess;
                lblScroll.Location = new Point(panel1.Width, lblScroll.Location.Y);
            }
            
        }
        #endregion

        #region 退出当前程序
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 窗体最小化
        private void picFormSize_Click(object sender, EventArgs e)
        {
                WindowState = FormWindowState.Minimized;
            
        }
        #endregion

        #region 窗体加载事件方法
        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblUserName.Text = LoginInfo.WorkerName + "【" + LoginInfo.WorkerClub +LoginInfo.WorkerPosition+ "】";
            notifyIcon1.Text = "TS酒店管理系统-" + lblUserName.Text;
            Opacity = 0.0; //窗体透明度为0
            fadeTimer.Start(); //计时开始
            picReser.BackgroundImage = Resources.预约管理_aa;
            picRoom.BackgroundImage = Resources.客房管理_ib;
            picExtend.BackgroundImage = Resources.扩展功能_ib;
            picCustomer.BackgroundImage = Resources.用户管理_ib;
            pnlMID.Controls.Clear();
            FrmReserManager frm1 = new FrmReserManager();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();

            

        }
        #endregion

        

        #region 客房管理列表弹出事件方法
        private void picRoom_Click(object sender, EventArgs e)
        {
            picReser.BackgroundImage = Resources.预约管理;
            picRoom.BackgroundImage = Resources.客房管理_ia;
            picExtend.BackgroundImage = Resources.扩展功能_ib;
            picCustomer.BackgroundImage = Resources.用户管理_ib ;
            picCommodity.BackgroundImage = Resources.商品消费_ia;
            pnlMID.Controls.Clear();
            FrmRoomManager frm1 = new FrmRoomManager();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();

            
        }
        #endregion

        #region 用户管理列表弹出事件方法
        private void picCustomer_Click(object sender, EventArgs e)
        {
            picReser.BackgroundImage = Resources.预约管理;
            picRoom.BackgroundImage = Resources.客房管理_ib;
            picCustomer.BackgroundImage = Resources.用户管理_ia;
            picExtend.BackgroundImage = Resources.扩展功能_ib;
            picCommodity.BackgroundImage = Resources.商品消费_ia;
            pnlMID.Controls.Clear();
            FrmCustomerManager frm1 = new FrmCustomerManager();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();
        }
        #endregion


        #region 扩展管理列表弹出事件方法
        private void picExtend_Click(object sender, EventArgs e)
        {
            picReser.BackgroundImage = Resources.预约管理;
            picRoom.BackgroundImage = Resources.客房管理_ib;
            picCustomer.BackgroundImage = Resources.用户管理_ib;
            picCommodity.BackgroundImage = Resources.商品消费_ia;
            picExtend.BackgroundImage = Resources.扩展功能_ia;
            pnlMID.Controls.Clear();
            ExtendOption frm = new ExtendOption();
            frm.TopLevel = false;
            ExtendOption frm1 = new ExtendOption();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();
        } 
        #endregion

        #region 关闭按钮鼠标事件
        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.White;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;
        }
        #endregion

        #region 最小化按钮鼠标事件
        private void picFormSize_MouseEnter(object sender, EventArgs e)
        {
            picFormSize.BackColor = Color.White;
        }
        private void picFormSize_MouseLeave(object sender, EventArgs e)
        {
            picFormSize.BackColor = Color.Transparent;
        }






        #endregion

        #region 窗体渐变效果
        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            double d = 0.10;
            if (showing)
            {
                if (Opacity + d >= 1.0)
                {
                    Opacity = 1.0;
                    fadeTimer.Stop();
                }
                else
                {
                    Opacity += d;
                }
            }
            else
            {
                if (Opacity - d <= 0.0)
                {
                    Opacity = 0.0;
                    fadeTimer.Stop();
                }
                else
                {
                    Opacity -= d;
                }
            }
        }
        #endregion

        #region 计算后台系统的入口点击事件方法
        int i = 0; 
        #endregion

        #region 后台系统入口事件方法
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            i++;
            if (i < 3)
            {
               
            }
            else if (i % 3==0)
            {
                FrmAdminEnter frm = new FrmAdminEnter();
                frm.Show();
            }
            
        }
        #endregion

        #region 调用系统锁屏方法
        private void tsmiLockScreen_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }
        #endregion

        #region 检查软件更新版本事件方法
        private void tsmiCheckUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请到：https://www.jackson.xyz" + "获取该软件的最新版本！");
        }
        #endregion

        #region 切换用户事件方法
        private void tsmiChangeUser_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }
        #endregion

        #region 退出酒店管理系统事件方法
        private void tsmiExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 关于我们选项的事件方法
        private void tsmiAboutUs_Click(object sender, EventArgs e)
        {
            FrmAboutUs frm = new FrmAboutUs();
            frm.Show();
        }
        #endregion

        #region 当窗体关闭后的事件方法
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            notifyIcon1.Dispose();
        }
        #endregion

        private void tsmiSelectUserAdmin_Click(object sender, EventArgs e)
        {
            
        }

        private void picCommodity_Click(object sender, EventArgs e)
        {
            picReser.BackgroundImage = Resources.预约管理;
            picRoom.BackgroundImage = Resources.客房管理_ib;
            picCustomer.BackgroundImage = Resources.用户管理_ib;
            picExtend.BackgroundImage = Resources.扩展功能_ib;
            picCommodity.BackgroundImage = Resources.商品消费_ib;
            pnlMID.Controls.Clear();
            FrmSellThing frm1 = new FrmSellThing();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();
        }

        private void tsmiBackUpDatabase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("为出于安全考虑，新版本的数据库备份已搬家至后台！","T仔的提醒");
        }

        private void picReser_Click(object sender, EventArgs e)
        {
            picReser.BackgroundImage = Resources.预约管理_aa;
            picRoom.BackgroundImage = Resources.客房管理_ib;
            picCustomer.BackgroundImage = Resources.用户管理_ib;
            picExtend.BackgroundImage = Resources.扩展功能_ib;
            picCommodity.BackgroundImage = Resources.商品消费_ia;
            pnlMID.Controls.Clear();
            FrmReserManager frm1 = new FrmReserManager();
            frm1.TopLevel = false;
            pnlMID.Controls.Add(frm1);
            frm1.Show();
        }

        private void cmsMain_Opening(object sender, CancelEventArgs e)
        {
            tsmiBackUpDatabase.Enabled = false;
        }
    }
}
