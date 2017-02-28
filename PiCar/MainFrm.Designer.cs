namespace WangHeng.Org.PiCar
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPostResultInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.btnCamUp = new System.Windows.Forms.Button();
            this.btnCamDown = new System.Windows.Forms.Button();
            this.btnCamLeft = new System.Windows.Forms.Button();
            this.btnCamRight = new System.Windows.Forms.Button();
            this.btnCamRst = new System.Windows.Forms.Button();
            this.btnPyLeft = new System.Windows.Forms.Button();
            this.btnPyRight = new System.Windows.Forms.Button();
            this.setSpeedBtn1 = new System.Windows.Forms.Button();
            this.setSpeedBtn2 = new System.Windows.Forms.Button();
            this.setSpeedBtn4 = new System.Windows.Forms.Button();
            this.setSpeedBtn3 = new System.Windows.Forms.Button();
            this.setSpeedBtn5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(27, 214);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(100, 71);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "左转";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.ctlButton_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(135, 214);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 71);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.ctlButton_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(243, 214);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(100, 71);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "右转";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.ctlButton_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(135, 135);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 71);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "前进";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.ctlButton_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(135, 293);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 71);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "后退";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.ctlButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPostResultInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(663, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPostResultInfo
            // 
            this.lblPostResultInfo.Name = "lblPostResultInfo";
            this.lblPostResultInfo.Size = new System.Drawing.Size(66, 20);
            this.lblPostResultInfo.Text = "Success";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(27, 396);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(208, 25);
            this.ipBox.TabIndex = 6;
            this.ipBox.Text = "192.168.1.102";
            this.ipBox.TextChanged += new System.EventHandler(this.ipBox_TextChanged);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(243, 396);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(75, 25);
            this.portBox.TabIndex = 7;
            this.portBox.Text = "2000";
            this.portBox.TextChanged += new System.EventHandler(this.portBox_TextChanged);
            // 
            // btnCamUp
            // 
            this.btnCamUp.Location = new System.Drawing.Point(479, 55);
            this.btnCamUp.Name = "btnCamUp";
            this.btnCamUp.Size = new System.Drawing.Size(75, 70);
            this.btnCamUp.TabIndex = 8;
            this.btnCamUp.Text = "上";
            this.btnCamUp.UseVisualStyleBackColor = true;
            this.btnCamUp.Click += new System.EventHandler(this.camctlButton_Click);
            // 
            // btnCamDown
            // 
            this.btnCamDown.Location = new System.Drawing.Point(479, 219);
            this.btnCamDown.Name = "btnCamDown";
            this.btnCamDown.Size = new System.Drawing.Size(75, 70);
            this.btnCamDown.TabIndex = 9;
            this.btnCamDown.Text = "下";
            this.btnCamDown.UseVisualStyleBackColor = true;
            this.btnCamDown.Click += new System.EventHandler(this.camctlButton_Click);
            // 
            // btnCamLeft
            // 
            this.btnCamLeft.Location = new System.Drawing.Point(391, 133);
            this.btnCamLeft.Name = "btnCamLeft";
            this.btnCamLeft.Size = new System.Drawing.Size(75, 70);
            this.btnCamLeft.TabIndex = 10;
            this.btnCamLeft.Text = "左";
            this.btnCamLeft.UseVisualStyleBackColor = true;
            this.btnCamLeft.Click += new System.EventHandler(this.camctlButton_Click);
            // 
            // btnCamRight
            // 
            this.btnCamRight.Location = new System.Drawing.Point(565, 134);
            this.btnCamRight.Name = "btnCamRight";
            this.btnCamRight.Size = new System.Drawing.Size(75, 70);
            this.btnCamRight.TabIndex = 11;
            this.btnCamRight.Text = "右";
            this.btnCamRight.UseVisualStyleBackColor = true;
            this.btnCamRight.Click += new System.EventHandler(this.camctlButton_Click);
            // 
            // btnCamRst
            // 
            this.btnCamRst.Location = new System.Drawing.Point(479, 134);
            this.btnCamRst.Name = "btnCamRst";
            this.btnCamRst.Size = new System.Drawing.Size(75, 70);
            this.btnCamRst.TabIndex = 12;
            this.btnCamRst.Text = "初始化";
            this.btnCamRst.UseVisualStyleBackColor = true;
            this.btnCamRst.Click += new System.EventHandler(this.camctlButton_Click);
            // 
            // btnPyLeft
            // 
            this.btnPyLeft.Location = new System.Drawing.Point(27, 136);
            this.btnPyLeft.Name = "btnPyLeft";
            this.btnPyLeft.Size = new System.Drawing.Size(100, 71);
            this.btnPyLeft.TabIndex = 13;
            this.btnPyLeft.Text = "左漂";
            this.btnPyLeft.UseVisualStyleBackColor = true;
            this.btnPyLeft.Click += new System.EventHandler(this.btnPyLeft_Click);
            // 
            // btnPyRight
            // 
            this.btnPyRight.Location = new System.Drawing.Point(242, 136);
            this.btnPyRight.Name = "btnPyRight";
            this.btnPyRight.Size = new System.Drawing.Size(100, 71);
            this.btnPyRight.TabIndex = 14;
            this.btnPyRight.Text = "右漂";
            this.btnPyRight.UseVisualStyleBackColor = true;
            this.btnPyRight.Click += new System.EventHandler(this.btnPyRight_Click);
            // 
            // setSpeedBtn1
            // 
            this.setSpeedBtn1.Location = new System.Drawing.Point(60, 61);
            this.setSpeedBtn1.Name = "setSpeedBtn1";
            this.setSpeedBtn1.Size = new System.Drawing.Size(37, 36);
            this.setSpeedBtn1.TabIndex = 15;
            this.setSpeedBtn1.Tag = "100";
            this.setSpeedBtn1.Text = "1";
            this.setSpeedBtn1.UseVisualStyleBackColor = true;
            this.setSpeedBtn1.Click += new System.EventHandler(this.setSpeedButton_Click);
            // 
            // setSpeedBtn2
            // 
            this.setSpeedBtn2.Location = new System.Drawing.Point(113, 61);
            this.setSpeedBtn2.Name = "setSpeedBtn2";
            this.setSpeedBtn2.Size = new System.Drawing.Size(37, 36);
            this.setSpeedBtn2.TabIndex = 16;
            this.setSpeedBtn2.Tag = "130";
            this.setSpeedBtn2.Text = "2";
            this.setSpeedBtn2.UseVisualStyleBackColor = true;
            this.setSpeedBtn2.Click += new System.EventHandler(this.setSpeedButton_Click);
            // 
            // setSpeedBtn4
            // 
            this.setSpeedBtn4.Location = new System.Drawing.Point(222, 61);
            this.setSpeedBtn4.Name = "setSpeedBtn4";
            this.setSpeedBtn4.Size = new System.Drawing.Size(37, 36);
            this.setSpeedBtn4.TabIndex = 18;
            this.setSpeedBtn4.Tag = "200";
            this.setSpeedBtn4.Text = "4";
            this.setSpeedBtn4.UseVisualStyleBackColor = true;
            this.setSpeedBtn4.Click += new System.EventHandler(this.setSpeedButton_Click);
            // 
            // setSpeedBtn3
            // 
            this.setSpeedBtn3.Location = new System.Drawing.Point(169, 61);
            this.setSpeedBtn3.Name = "setSpeedBtn3";
            this.setSpeedBtn3.Size = new System.Drawing.Size(37, 36);
            this.setSpeedBtn3.TabIndex = 17;
            this.setSpeedBtn3.Tag = "160";
            this.setSpeedBtn3.Text = "3";
            this.setSpeedBtn3.UseVisualStyleBackColor = true;
            this.setSpeedBtn3.Click += new System.EventHandler(this.setSpeedButton_Click);
            // 
            // setSpeedBtn5
            // 
            this.setSpeedBtn5.Location = new System.Drawing.Point(272, 61);
            this.setSpeedBtn5.Name = "setSpeedBtn5";
            this.setSpeedBtn5.Size = new System.Drawing.Size(37, 36);
            this.setSpeedBtn5.TabIndex = 19;
            this.setSpeedBtn5.Tag = "255";
            this.setSpeedBtn5.Text = "5";
            this.setSpeedBtn5.UseVisualStyleBackColor = true;
            this.setSpeedBtn5.Click += new System.EventHandler(this.setSpeedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "档位控制";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "方向控制";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "云台控制";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "灯光控制";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 41);
            this.button1.TabIndex = 24;
            this.button1.Tag = "1";
            this.button1.Text = "大灯开";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.lightCtlButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 41);
            this.button2.TabIndex = 25;
            this.button2.Tag = "0";
            this.button2.Text = "大灯关";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.lightCtlButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(113, -1);
            this.trackBar1.Maximum = 155;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(227, 56);
            this.trackBar1.TabIndex = 26;
            this.trackBar1.Value = 78;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 466);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setSpeedBtn5);
            this.Controls.Add(this.setSpeedBtn4);
            this.Controls.Add(this.setSpeedBtn3);
            this.Controls.Add(this.setSpeedBtn2);
            this.Controls.Add(this.setSpeedBtn1);
            this.Controls.Add(this.btnPyRight);
            this.Controls.Add(this.btnPyLeft);
            this.Controls.Add(this.btnCamRst);
            this.Controls.Add(this.btnCamRight);
            this.Controls.Add(this.btnCamLeft);
            this.Controls.Add(this.btnCamDown);
            this.Controls.Add(this.btnCamUp);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblPostResultInfo;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Button btnCamUp;
        private System.Windows.Forms.Button btnCamDown;
        private System.Windows.Forms.Button btnCamLeft;
        private System.Windows.Forms.Button btnCamRight;
        private System.Windows.Forms.Button btnCamRst;
        private System.Windows.Forms.Button btnPyLeft;
        private System.Windows.Forms.Button btnPyRight;
        private System.Windows.Forms.Button setSpeedBtn1;
        private System.Windows.Forms.Button setSpeedBtn2;
        private System.Windows.Forms.Button setSpeedBtn4;
        private System.Windows.Forms.Button setSpeedBtn3;
        private System.Windows.Forms.Button setSpeedBtn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

