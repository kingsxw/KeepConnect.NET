using System.Windows.Forms;

namespace KeepConnect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonRun = new Button();
            labelConnect = new Label();
            buttonInstall = new Button();
            buttonKeep = new Button();
            labelCycle = new Label();
            numericUpDownClcye = new NumericUpDown();
            buttonRefresh = new Button();
            buttonExit = new Button();
            labelHost = new Label();
            textBoxHost = new TextBox();
            labelPort = new Label();
            numericUpDownPort = new NumericUpDown();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            buttonStop = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownClcye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPort).BeginInit();
            SuspendLayout();
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(54, 19);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(192, 80);
            buttonRun.TabIndex = 0;
            buttonRun.Text = "运行EasyConnect";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // labelConnect
            // 
            labelConnect.AutoEllipsis = true;
            labelConnect.AutoSize = true;
            labelConnect.FlatStyle = FlatStyle.System;
            labelConnect.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelConnect.Location = new Point(36, 378);
            labelConnect.Name = "labelConnect";
            labelConnect.Size = new Size(86, 31);
            labelConnect.TabIndex = 1;
            labelConnect.Text = "未连接";
            labelConnect.Click += labelConnect_Click;
            // 
            // buttonInstall
            // 
            buttonInstall.Location = new Point(303, 19);
            buttonInstall.Name = "buttonInstall";
            buttonInstall.Size = new Size(175, 80);
            buttonInstall.TabIndex = 2;
            buttonInstall.Text = "下载EasyConnect";
            buttonInstall.UseVisualStyleBackColor = true;
            buttonInstall.Click += buttonInstall_Click;
            // 
            // buttonKeep
            // 
            buttonKeep.Location = new Point(291, 278);
            buttonKeep.Name = "buttonKeep";
            buttonKeep.Size = new Size(150, 46);
            buttonKeep.TabIndex = 3;
            buttonKeep.Text = "保持连接";
            buttonKeep.UseVisualStyleBackColor = false;
            buttonKeep.Click += buttonKeep_Click;
            // 
            // labelCycle
            // 
            labelCycle.AutoSize = true;
            labelCycle.Location = new Point(424, 197);
            labelCycle.Name = "labelCycle";
            labelCycle.Size = new Size(158, 31);
            labelCycle.TabIndex = 8;
            labelCycle.Text = "周期（分钟）";
            labelCycle.Click += labelCycle_Click;
            // 
            // numericUpDownClcye
            // 
            numericUpDownClcye.Location = new Point(588, 195);
            numericUpDownClcye.Maximum = new decimal(new int[] { 29, 0, 0, 0 });
            numericUpDownClcye.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownClcye.Name = "numericUpDownClcye";
            numericUpDownClcye.Size = new Size(104, 38);
            numericUpDownClcye.TabIndex = 9;
            numericUpDownClcye.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownClcye.ValueChanged += numericUpDownClcye_ValueChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = SystemColors.ActiveCaption;
            buttonRefresh.Location = new Point(54, 278);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(150, 46);
            buttonRefresh.TabIndex = 10;
            buttonRefresh.Text = "刷新状态";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Salmon;
            buttonExit.Location = new Point(542, 19);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(150, 80);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "退出";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelHost
            // 
            labelHost.AutoSize = true;
            labelHost.Location = new Point(36, 142);
            labelHost.Name = "labelHost";
            labelHost.Size = new Size(68, 31);
            labelHost.TabIndex = 12;
            labelHost.Text = "Host";
            // 
            // textBoxHost
            // 
            textBoxHost.Location = new Point(119, 139);
            textBoxHost.Name = "textBoxHost";
            textBoxHost.Size = new Size(562, 38);
            textBoxHost.TabIndex = 13;
            textBoxHost.Text = "172.16.130.1";
            textBoxHost.TextChanged += textBoxHost_TextChanged;
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new Point(36, 199);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(62, 31);
            labelPort.TabIndex = 14;
            labelPort.Text = "端口";
            // 
            // numericUpDownPort
            // 
            numericUpDownPort.Location = new Point(119, 197);
            numericUpDownPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDownPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPort.Name = "numericUpDownPort";
            numericUpDownPort.Size = new Size(154, 38);
            numericUpDownPort.TabIndex = 15;
            numericUpDownPort.Value = new decimal(new int[] { 80, 0, 0, 0 });
            numericUpDownPort.ValueChanged += numericUpDownPort_ValueChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "KeepConnect";
            notifyIcon1.Visible = false;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(301, 48);
            contextMenuStrip1.Text = "KeepConnect";
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // buttonStop
            // 
            buttonStop.Enabled = false;
            buttonStop.Location = new Point(542, 278);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(150, 46);
            buttonStop.TabIndex = 16;
            buttonStop.Text = "停止保持";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStop);
            Controls.Add(numericUpDownPort);
            Controls.Add(labelPort);
            Controls.Add(textBoxHost);
            Controls.Add(labelHost);
            Controls.Add(buttonExit);
            Controls.Add(buttonRefresh);
            Controls.Add(numericUpDownClcye);
            Controls.Add(labelCycle);
            Controls.Add(buttonKeep);
            Controls.Add(buttonInstall);
            Controls.Add(labelConnect);
            Controls.Add(buttonRun);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "KeepConnect v0.9.9_20230907_RC";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)numericUpDownClcye).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPort).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRun;
        private Label labelConnect;
        private Button buttonInstall;
        private Button buttonKeep;
        private Label labelCycle;
        private NumericUpDown numericUpDownClcye;
        private Button buttonRefresh;
        private Button buttonExit;
        private Label labelHost;
        private TextBox textBoxHost;
        private Label labelPort;
        private NumericUpDown numericUpDownPort;
        private NotifyIcon notifyIcon1;
        private Button buttonStop;
        private ContextMenuStrip contextMenuStrip1;
    }
}
