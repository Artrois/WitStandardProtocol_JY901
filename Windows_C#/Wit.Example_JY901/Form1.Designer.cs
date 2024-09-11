
namespace Wit.Example_JY901
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.baudComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bandWidth256 = new System.Windows.Forms.Button();
            this.bandWidth20 = new System.Windows.Forms.Button();
            this.returnRate50 = new System.Windows.Forms.Button();
            this.returnRate10 = new System.Windows.Forms.Button();
            this.readReg03Button = new System.Windows.Forms.Button();
            this.endFieldCalibrationButton = new System.Windows.Forms.Button();
            this.startFieldCalibrationButton = new System.Windows.Forms.Button();
            this.appliedCalibrationButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccY = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAccZ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblGyroX = new System.Windows.Forms.Label();
            this.lblGyroY = new System.Windows.Forms.Label();
            this.lblGyroZ = new System.Windows.Forms.Label();
            this.lblAngleX = new System.Windows.Forms.Label();
            this.lblMagX = new System.Windows.Forms.Label();
            this.lblAngleY = new System.Windows.Forms.Label();
            this.lblMagY = new System.Windows.Forms.Label();
            this.lblAngleZ = new System.Windows.Forms.Label();
            this.lblMagZ = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblVer = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.portComboBox, "portComboBox");
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.portComboBox_MouseDown);
            // 
            // baudComboBox
            // 
            this.baudComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.baudComboBox, "baudComboBox");
            this.baudComboBox.Name = "baudComboBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // openButton
            // 
            resources.ApplyResources(this.openButton, "openButton");
            this.openButton.Name = "openButton";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.closeButton);
            this.groupBox2.Controls.Add(this.portComboBox);
            this.groupBox2.Controls.Add(this.openButton);
            this.groupBox2.Controls.Add(this.baudComboBox);
            this.groupBox2.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMagZ);
            this.groupBox1.Controls.Add(this.lblAngleZ);
            this.groupBox1.Controls.Add(this.lblGyroZ);
            this.groupBox1.Controls.Add(this.lblAccZ);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblMagY);
            this.groupBox1.Controls.Add(this.lblAngleY);
            this.groupBox1.Controls.Add(this.lblGyroY);
            this.groupBox1.Controls.Add(this.lblAccY);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblVer);
            this.groupBox1.Controls.Add(this.lblTemp);
            this.groupBox1.Controls.Add(this.lblMagX);
            this.groupBox1.Controls.Add(this.lblAngleX);
            this.groupBox1.Controls.Add(this.lblGyroX);
            this.groupBox1.Controls.Add(this.lblAccX);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataRichTextBox);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dataRichTextBox
            // 
            resources.ApplyResources(this.dataRichTextBox, "dataRichTextBox");
            this.dataRichTextBox.Name = "dataRichTextBox";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.groupBox3);
            this.leftPanel.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.leftPanel, "leftPanel");
            this.leftPanel.Name = "leftPanel";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bandWidth256);
            this.groupBox3.Controls.Add(this.bandWidth20);
            this.groupBox3.Controls.Add(this.returnRate50);
            this.groupBox3.Controls.Add(this.returnRate10);
            this.groupBox3.Controls.Add(this.readReg03Button);
            this.groupBox3.Controls.Add(this.endFieldCalibrationButton);
            this.groupBox3.Controls.Add(this.startFieldCalibrationButton);
            this.groupBox3.Controls.Add(this.appliedCalibrationButton);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // bandWidth256
            // 
            resources.ApplyResources(this.bandWidth256, "bandWidth256");
            this.bandWidth256.Name = "bandWidth256";
            this.bandWidth256.UseVisualStyleBackColor = true;
            this.bandWidth256.Click += new System.EventHandler(this.bandWidth256_Click);
            // 
            // bandWidth20
            // 
            resources.ApplyResources(this.bandWidth20, "bandWidth20");
            this.bandWidth20.Name = "bandWidth20";
            this.bandWidth20.UseVisualStyleBackColor = true;
            this.bandWidth20.Click += new System.EventHandler(this.bandWidth20_Click);
            // 
            // returnRate50
            // 
            resources.ApplyResources(this.returnRate50, "returnRate50");
            this.returnRate50.Name = "returnRate50";
            this.returnRate50.UseVisualStyleBackColor = true;
            this.returnRate50.Click += new System.EventHandler(this.returnRate50_Click);
            // 
            // returnRate10
            // 
            resources.ApplyResources(this.returnRate10, "returnRate10");
            this.returnRate10.Name = "returnRate10";
            this.returnRate10.UseVisualStyleBackColor = true;
            this.returnRate10.Click += new System.EventHandler(this.returnRate10_Click);
            // 
            // readReg03Button
            // 
            resources.ApplyResources(this.readReg03Button, "readReg03Button");
            this.readReg03Button.Name = "readReg03Button";
            this.readReg03Button.UseVisualStyleBackColor = true;
            this.readReg03Button.Click += new System.EventHandler(this.readReg03Button_Click);
            // 
            // endFieldCalibrationButton
            // 
            resources.ApplyResources(this.endFieldCalibrationButton, "endFieldCalibrationButton");
            this.endFieldCalibrationButton.Name = "endFieldCalibrationButton";
            this.endFieldCalibrationButton.UseVisualStyleBackColor = true;
            this.endFieldCalibrationButton.Click += new System.EventHandler(this.endFieldCalibrationButton_Click);
            // 
            // startFieldCalibrationButton
            // 
            resources.ApplyResources(this.startFieldCalibrationButton, "startFieldCalibrationButton");
            this.startFieldCalibrationButton.Name = "startFieldCalibrationButton";
            this.startFieldCalibrationButton.UseVisualStyleBackColor = true;
            this.startFieldCalibrationButton.Click += new System.EventHandler(this.startFieldCalibrationButton_Click);
            // 
            // appliedCalibrationButton
            // 
            resources.ApplyResources(this.appliedCalibrationButton, "appliedCalibrationButton");
            this.appliedCalibrationButton.Name = "appliedCalibrationButton";
            this.appliedCalibrationButton.UseVisualStyleBackColor = true;
            this.appliedCalibrationButton.Click += new System.EventHandler(this.appliedCalibrationButton_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblAccX
            // 
            resources.ApplyResources(this.lblAccX, "lblAccX");
            this.lblAccX.Name = "lblAccX";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblAccY
            // 
            resources.ApplyResources(this.lblAccY, "lblAccY");
            this.lblAccY.Name = "lblAccY";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lblAccZ
            // 
            resources.ApplyResources(this.lblAccZ, "lblAccZ");
            this.lblAccZ.Name = "lblAccZ";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // lblGyroX
            // 
            resources.ApplyResources(this.lblGyroX, "lblGyroX");
            this.lblGyroX.Name = "lblGyroX";
            // 
            // lblGyroY
            // 
            resources.ApplyResources(this.lblGyroY, "lblGyroY");
            this.lblGyroY.Name = "lblGyroY";
            // 
            // lblGyroZ
            // 
            resources.ApplyResources(this.lblGyroZ, "lblGyroZ");
            this.lblGyroZ.Name = "lblGyroZ";
            // 
            // lblAngleX
            // 
            resources.ApplyResources(this.lblAngleX, "lblAngleX");
            this.lblAngleX.Name = "lblAngleX";
            // 
            // lblMagX
            // 
            resources.ApplyResources(this.lblMagX, "lblMagX");
            this.lblMagX.Name = "lblMagX";
            // 
            // lblAngleY
            // 
            resources.ApplyResources(this.lblAngleY, "lblAngleY");
            this.lblAngleY.Name = "lblAngleY";
            // 
            // lblMagY
            // 
            resources.ApplyResources(this.lblMagY, "lblMagY");
            this.lblMagY.Name = "lblMagY";
            // 
            // lblAngleZ
            // 
            resources.ApplyResources(this.lblAngleZ, "lblAngleZ");
            this.lblAngleZ.Name = "lblAngleZ";
            // 
            // lblMagZ
            // 
            resources.ApplyResources(this.lblMagZ, "lblMagZ");
            this.lblMagZ.Name = "lblMagZ";
            // 
            // lblTemp
            // 
            resources.ApplyResources(this.lblTemp, "lblTemp");
            this.lblTemp.Name = "lblTemp";
            // 
            // lblVer
            // 
            resources.ApplyResources(this.lblVer, "lblVer");
            this.lblVer.Name = "lblVer";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.leftPanel);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.ComboBox baudComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox dataRichTextBox;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button readReg03Button;
        private System.Windows.Forms.Button endFieldCalibrationButton;
        private System.Windows.Forms.Button startFieldCalibrationButton;
        private System.Windows.Forms.Button appliedCalibrationButton;
        private System.Windows.Forms.Button bandWidth256;
        private System.Windows.Forms.Button bandWidth20;
        private System.Windows.Forms.Button returnRate50;
        private System.Windows.Forms.Button returnRate10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAccX;
        private System.Windows.Forms.Label lblAccZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAccY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMagZ;
        private System.Windows.Forms.Label lblAngleZ;
        private System.Windows.Forms.Label lblGyroZ;
        private System.Windows.Forms.Label lblMagY;
        private System.Windows.Forms.Label lblAngleY;
        private System.Windows.Forms.Label lblGyroY;
        private System.Windows.Forms.Label lblMagX;
        private System.Windows.Forms.Label lblAngleX;
        private System.Windows.Forms.Label lblGyroX;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label lblTemp;
    }
}

