namespace Switch_Guide
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_setup_auto = new System.Windows.Forms.GroupBox();
            this.button_set_auto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_timer_auto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_setup_man = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_set_man = new System.Windows.Forms.Button();
            this.textBox_timer_RF4 = new System.Windows.Forms.TextBox();
            this.textBox_timer_RF3 = new System.Windows.Forms.TextBox();
            this.textBox_timer_RF2 = new System.Windows.Forms.TextBox();
            this.textBox_timer_RF1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_RF4 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF3 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF2 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_serial = new System.Windows.Forms.GroupBox();
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.comboBox_Baudrate = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_setup_auto.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox_setup_man.SuspendLayout();
            this.groupBox_serial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(39, 168);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 226);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_setup_auto);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Auto";
            // 
            // groupBox_setup_auto
            // 
            this.groupBox_setup_auto.Controls.Add(this.button_set_auto);
            this.groupBox_setup_auto.Controls.Add(this.label8);
            this.groupBox_setup_auto.Controls.Add(this.textBox_timer_auto);
            this.groupBox_setup_auto.Controls.Add(this.label7);
            this.groupBox_setup_auto.Location = new System.Drawing.Point(25, 23);
            this.groupBox_setup_auto.Name = "groupBox_setup_auto";
            this.groupBox_setup_auto.Size = new System.Drawing.Size(568, 128);
            this.groupBox_setup_auto.TabIndex = 1;
            this.groupBox_setup_auto.TabStop = false;
            this.groupBox_setup_auto.Text = "Set up";
            // 
            // button_set_auto
            // 
            this.button_set_auto.Location = new System.Drawing.Point(231, 82);
            this.button_set_auto.Name = "button_set_auto";
            this.button_set_auto.Size = new System.Drawing.Size(83, 29);
            this.button_set_auto.TabIndex = 3;
            this.button_set_auto.Text = "Set";
            this.button_set_auto.UseVisualStyleBackColor = true;
            this.button_set_auto.Click += new System.EventHandler(this.button_set_auto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "ms";
            // 
            // textBox_timer_auto
            // 
            this.textBox_timer_auto.Location = new System.Drawing.Point(212, 41);
            this.textBox_timer_auto.Name = "textBox_timer_auto";
            this.textBox_timer_auto.Size = new System.Drawing.Size(121, 26);
            this.textBox_timer_auto.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Timer:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox_setup_man);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual";
            // 
            // groupBox_setup_man
            // 
            this.groupBox_setup_man.Controls.Add(this.label11);
            this.groupBox_setup_man.Controls.Add(this.button_set_man);
            this.groupBox_setup_man.Controls.Add(this.textBox_timer_RF4);
            this.groupBox_setup_man.Controls.Add(this.textBox_timer_RF3);
            this.groupBox_setup_man.Controls.Add(this.textBox_timer_RF2);
            this.groupBox_setup_man.Controls.Add(this.textBox_timer_RF1);
            this.groupBox_setup_man.Controls.Add(this.label10);
            this.groupBox_setup_man.Controls.Add(this.label9);
            this.groupBox_setup_man.Controls.Add(this.checkBox_RF4);
            this.groupBox_setup_man.Controls.Add(this.checkBox_RF3);
            this.groupBox_setup_man.Controls.Add(this.checkBox_RF2);
            this.groupBox_setup_man.Controls.Add(this.checkBox_RF1);
            this.groupBox_setup_man.Controls.Add(this.label6);
            this.groupBox_setup_man.Controls.Add(this.label5);
            this.groupBox_setup_man.Controls.Add(this.label4);
            this.groupBox_setup_man.Controls.Add(this.label3);
            this.groupBox_setup_man.Location = new System.Drawing.Point(23, 21);
            this.groupBox_setup_man.Name = "groupBox_setup_man";
            this.groupBox_setup_man.Size = new System.Drawing.Size(579, 151);
            this.groupBox_setup_man.TabIndex = 15;
            this.groupBox_setup_man.TabStop = false;
            this.groupBox_setup_man.Text = "Set up";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(534, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "ms";
            // 
            // button_set_man
            // 
            this.button_set_man.Location = new System.Drawing.Point(233, 109);
            this.button_set_man.Name = "button_set_man";
            this.button_set_man.Size = new System.Drawing.Size(97, 36);
            this.button_set_man.TabIndex = 29;
            this.button_set_man.Text = "Set";
            this.button_set_man.UseVisualStyleBackColor = true;
            this.button_set_man.Click += new System.EventHandler(this.button_set_man_Click);
            // 
            // textBox_timer_RF4
            // 
            this.textBox_timer_RF4.Location = new System.Drawing.Point(428, 69);
            this.textBox_timer_RF4.Name = "textBox_timer_RF4";
            this.textBox_timer_RF4.Size = new System.Drawing.Size(100, 26);
            this.textBox_timer_RF4.TabIndex = 28;
            // 
            // textBox_timer_RF3
            // 
            this.textBox_timer_RF3.Location = new System.Drawing.Point(311, 69);
            this.textBox_timer_RF3.Name = "textBox_timer_RF3";
            this.textBox_timer_RF3.Size = new System.Drawing.Size(100, 26);
            this.textBox_timer_RF3.TabIndex = 27;
            // 
            // textBox_timer_RF2
            // 
            this.textBox_timer_RF2.Location = new System.Drawing.Point(191, 69);
            this.textBox_timer_RF2.Name = "textBox_timer_RF2";
            this.textBox_timer_RF2.Size = new System.Drawing.Size(100, 26);
            this.textBox_timer_RF2.TabIndex = 26;
            // 
            // textBox_timer_RF1
            // 
            this.textBox_timer_RF1.Location = new System.Drawing.Point(76, 69);
            this.textBox_timer_RF1.Name = "textBox_timer_RF1";
            this.textBox_timer_RF1.Size = new System.Drawing.Size(100, 26);
            this.textBox_timer_RF1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Timer:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "On/Off:";
            // 
            // checkBox_RF4
            // 
            this.checkBox_RF4.AutoSize = true;
            this.checkBox_RF4.Location = new System.Drawing.Point(470, 46);
            this.checkBox_RF4.Name = "checkBox_RF4";
            this.checkBox_RF4.Size = new System.Drawing.Size(18, 17);
            this.checkBox_RF4.TabIndex = 22;
            this.checkBox_RF4.UseVisualStyleBackColor = true;
            this.checkBox_RF4.CheckedChanged += new System.EventHandler(this.checkBox_RF4_CheckedChanged);
            // 
            // checkBox_RF3
            // 
            this.checkBox_RF3.AutoSize = true;
            this.checkBox_RF3.Location = new System.Drawing.Point(351, 46);
            this.checkBox_RF3.Name = "checkBox_RF3";
            this.checkBox_RF3.Size = new System.Drawing.Size(18, 17);
            this.checkBox_RF3.TabIndex = 21;
            this.checkBox_RF3.UseVisualStyleBackColor = true;
            this.checkBox_RF3.CheckedChanged += new System.EventHandler(this.checkBox_RF3_CheckedChanged);
            // 
            // checkBox_RF2
            // 
            this.checkBox_RF2.AutoSize = true;
            this.checkBox_RF2.Location = new System.Drawing.Point(233, 46);
            this.checkBox_RF2.Name = "checkBox_RF2";
            this.checkBox_RF2.Size = new System.Drawing.Size(18, 17);
            this.checkBox_RF2.TabIndex = 20;
            this.checkBox_RF2.UseVisualStyleBackColor = true;
            this.checkBox_RF2.CheckedChanged += new System.EventHandler(this.checkBox_RF2_CheckedChanged);
            // 
            // checkBox_RF1
            // 
            this.checkBox_RF1.AutoSize = true;
            this.checkBox_RF1.Location = new System.Drawing.Point(119, 46);
            this.checkBox_RF1.Name = "checkBox_RF1";
            this.checkBox_RF1.Size = new System.Drawing.Size(18, 17);
            this.checkBox_RF1.TabIndex = 19;
            this.checkBox_RF1.UseVisualStyleBackColor = true;
            this.checkBox_RF1.CheckedChanged += new System.EventHandler(this.checkBox_RF1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "RF4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "RF3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "RF2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "RF1";
            // 
            // groupBox_serial
            // 
            this.groupBox_serial.Controls.Add(this.comboBox_COM);
            this.groupBox_serial.Controls.Add(this.label2);
            this.groupBox_serial.Controls.Add(this.label1);
            this.groupBox_serial.Controls.Add(this.button_disconnect);
            this.groupBox_serial.Controls.Add(this.button_connect);
            this.groupBox_serial.Controls.Add(this.comboBox_Baudrate);
            this.groupBox_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_serial.Location = new System.Drawing.Point(39, 12);
            this.groupBox_serial.Name = "groupBox_serial";
            this.groupBox_serial.Size = new System.Drawing.Size(448, 135);
            this.groupBox_serial.TabIndex = 1;
            this.groupBox_serial.TabStop = false;
            this.groupBox_serial.Text = "Serial";
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Location = new System.Drawing.Point(138, 39);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(121, 28);
            this.comboBox_COM.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serial Port:";
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(284, 82);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(131, 28);
            this.button_disconnect.TabIndex = 3;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(284, 39);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(131, 28);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // comboBox_Baudrate
            // 
            this.comboBox_Baudrate.FormattingEnabled = true;
            this.comboBox_Baudrate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.comboBox_Baudrate.Location = new System.Drawing.Point(138, 82);
            this.comboBox_Baudrate.Name = "comboBox_Baudrate";
            this.comboBox_Baudrate.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Baudrate.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Switch_Guide.Properties.Resources.logo_nextwaves;
            this.pictureBox1.Location = new System.Drawing.Point(503, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_serial);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Switch Module Guide";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_setup_auto.ResumeLayout(false);
            this.groupBox_setup_auto.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox_setup_man.ResumeLayout(false);
            this.groupBox_setup_man.PerformLayout();
            this.groupBox_serial.ResumeLayout(false);
            this.groupBox_serial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox_setup_auto;
        private System.Windows.Forms.Button button_set_auto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_timer_auto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_setup_man;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_set_man;
        private System.Windows.Forms.TextBox textBox_timer_RF4;
        private System.Windows.Forms.TextBox textBox_timer_RF3;
        private System.Windows.Forms.TextBox textBox_timer_RF2;
        private System.Windows.Forms.TextBox textBox_timer_RF1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_RF4;
        private System.Windows.Forms.CheckBox checkBox_RF3;
        private System.Windows.Forms.CheckBox checkBox_RF2;
        private System.Windows.Forms.CheckBox checkBox_RF1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_serial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.ComboBox comboBox_Baudrate;
        private System.Windows.Forms.ComboBox comboBox_COM;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

