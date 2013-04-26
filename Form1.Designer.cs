namespace IEC62056_21
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.comboBoxCOMPorts = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.WriteData = new System.Windows.Forms.Button();
            this.ReadData = new System.Windows.Forms.Button();
            this.ReadOBIS = new System.Windows.Forms.TextBox();
            this.WriteOBIS = new System.Windows.Forms.TextBox();
            this.ProgramMode = new System.Windows.Forms.CheckBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(93, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // comboBoxCOMPorts
            // 
            this.comboBoxCOMPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOMPorts.FormattingEnabled = true;
            this.comboBoxCOMPorts.Location = new System.Drawing.Point(174, 14);
            this.comboBoxCOMPorts.Name = "comboBoxCOMPorts";
            this.comboBoxCOMPorts.Size = new System.Drawing.Size(98, 21);
            this.comboBoxCOMPorts.TabIndex = 2;
            this.comboBoxCOMPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOMPorts_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 300;
            this.serialPort1.DataBits = 7;
            this.serialPort1.Parity = System.IO.Ports.Parity.Even;
            this.serialPort1.RtsEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Location = new System.Drawing.Point(13, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(259, 208);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // WriteData
            // 
            this.WriteData.Enabled = false;
            this.WriteData.Location = new System.Drawing.Point(278, 123);
            this.WriteData.Name = "WriteData";
            this.WriteData.Size = new System.Drawing.Size(114, 23);
            this.WriteData.TabIndex = 0;
            this.WriteData.Text = "Write";
            this.WriteData.UseVisualStyleBackColor = true;
            this.WriteData.Click += new System.EventHandler(this.WriteData_Click);
            // 
            // ReadData
            // 
            this.ReadData.Enabled = false;
            this.ReadData.Location = new System.Drawing.Point(278, 68);
            this.ReadData.Name = "ReadData";
            this.ReadData.Size = new System.Drawing.Size(114, 23);
            this.ReadData.TabIndex = 0;
            this.ReadData.Text = "Read";
            this.ReadData.UseVisualStyleBackColor = true;
            this.ReadData.Click += new System.EventHandler(this.ReadData_Click);
            // 
            // ReadOBIS
            // 
            this.ReadOBIS.Location = new System.Drawing.Point(278, 97);
            this.ReadOBIS.Name = "ReadOBIS";
            this.ReadOBIS.Size = new System.Drawing.Size(114, 20);
            this.ReadOBIS.TabIndex = 4;
            this.ReadOBIS.Text = "0.9.1()";
            // 
            // WriteOBIS
            // 
            this.WriteOBIS.Location = new System.Drawing.Point(278, 152);
            this.WriteOBIS.Name = "WriteOBIS";
            this.WriteOBIS.Size = new System.Drawing.Size(114, 20);
            this.WriteOBIS.TabIndex = 4;
            this.WriteOBIS.Text = "0.9.1()";
            // 
            // ProgramMode
            // 
            this.ProgramMode.AutoSize = true;
            this.ProgramMode.Checked = true;
            this.ProgramMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProgramMode.Location = new System.Drawing.Point(278, 16);
            this.ProgramMode.Name = "ProgramMode";
            this.ProgramMode.Size = new System.Drawing.Size(79, 17);
            this.ProgramMode.TabIndex = 5;
            this.ProgramMode.Text = "Programing";
            this.ProgramMode.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(334, 42);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(58, 20);
            this.Password.TabIndex = 6;
            this.Password.Text = "00000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(404, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ProgramMode);
            this.Controls.Add(this.WriteOBIS);
            this.Controls.Add(this.ReadOBIS);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBoxCOMPorts);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.ReadData);
            this.Controls.Add(this.WriteData);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "62056-21";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ComboBox comboBoxCOMPorts;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button WriteData;
        private System.Windows.Forms.Button ReadData;
        private System.Windows.Forms.TextBox ReadOBIS;
        private System.Windows.Forms.TextBox WriteOBIS;
        private System.Windows.Forms.CheckBox ProgramMode;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;


    }
}

