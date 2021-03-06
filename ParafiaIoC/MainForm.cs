﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ParafiaIoC
{
    public partial class MainForm : Form
    {
        private ConfigForm configForm;
        //private Worker worker;
        private List<Thread> threadList;

        public ConfigForm ConfigForm
        {
            set { this.configForm = value; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Enabled = false;
            btStop.Enabled = true;
            //notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconEnabled")));
            //worker.StartUpTime();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            btStart.Enabled = true;
            btStop.Enabled = false;
            //notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconDisabled")));
            //worker.StopUpTime();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*worker = new Worker(this);
            threadList = new List<Thread>();

            Thread systemTimeThread = new Thread(worker.renderSystemTime);
            systemTimeThread.Name = "SystemTimeThread";
            systemTimeThread.Start();

            Thread mainWorkThread = new Thread(worker.startMainWork);
            mainWorkThread.Name = "MainWorkThread";
            mainWorkThread.Start();

            threadList.Add(systemTimeThread);
            threadList.Add(mainWorkThread);*/
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*worker.StopAllThreads();

            foreach (Thread thread in threadList)
            {
                thread.Join();
            }*/
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void bConfig_Click(object sender, EventArgs e)
        {
            configForm.ShowDialog();
        }
    }
}
