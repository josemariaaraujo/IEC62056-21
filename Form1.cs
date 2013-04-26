using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace IEC62056_21
{
    public partial class Form1 : Form
    {
        string RxString;
        string RxBuffer;
        
        public Form1()
        {
            InitializeComponent();
        }
       
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboBoxCOMPorts.SelectedIndex < 0)
                return;

            RxBuffer = "";
            serialPort1.BaudRate = 300;
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                ProgramMode.Enabled = false;
                if (ProgramMode.Checked)
                {
                    ReadData.Enabled = true;
                    WriteData.Enabled = true;
                }
                //richTextBox1.ReadOnly = false;
                comboBoxCOMPorts.Enabled = false;
                serialPort1.Write("/?!\r\n");
            }
         }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (ProgramMode.Checked)
                {
                    serialPort1.Write("\x01" + "B0" + "\x03" + "q");
                    System.Threading.Thread.Sleep(1000);
                }
                
                serialPort1.Close();
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
                ReadData.Enabled = false;
                WriteData.Enabled = false;
                ProgramMode.Enabled = true;
               // richTextBox1.ReadOnly = true;
                comboBoxCOMPorts.Enabled = true;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            RxBuffer = RxBuffer + RxString;
            this.Invoke(new EventHandler(DisplayText));
            ProcessData();

        }
        private void ProcessData()
        {
            foreach (char c in RxString)
                if ( c == 0x0A )
                {
                    if (String.Compare("/ISK5", 0, RxBuffer, 0, 5) == 0)
                    {
                        if ( ProgramMode.Checked )
                            serialPort1.Write("\x06" + "051\r\n");
                        else
                            serialPort1.Write("\x06" + "050\r\n");
                        System.Threading.Thread.Sleep(250);
                        serialPort1.BaudRate = 9600;
                        serialPort1.DiscardInBuffer();
                    }

                    RxBuffer = "";
                }
                else if (c == 0x03 && ProgramMode.Checked)
                {
                    System.Threading.Thread.Sleep(250);
                    if (String.Compare("\x01" + "P0", 0, RxBuffer, 0, 3) == 0)
                    {
                        serialPort1.Write("\x01" + ReturnBCC("P1" + "\x02" + "(" + Password.Text + ")" + "\x03"));
                    }
                    RxBuffer = "";
                }



        }

        private void DisplayText(object sender, EventArgs e)
        {
            foreach (char c in RxString)
                if (c < ' ')
                {
                    richTextBox1.SelectionStart = richTextBox1.TextLength;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.AppendText("<"+((int)c).ToString()+">");
                    richTextBox1.SelectionColor = richTextBox1.ForeColor;
                    if (c=='\x0a')richTextBox1.AppendText(Convert.ToString(c));
                } else
                    richTextBox1.AppendText(Convert.ToString(c));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBoxCOMPorts.Items.Add(port);
            }
            if (comboBoxCOMPorts.Items.Count>0)
                comboBoxCOMPorts.SelectedIndex = 0;
        }

        private void comboBoxCOMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxCOMPorts.Text;
        }
//DISABLED!!!
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          // If the port is closed, don't try to send a character.

            if (!serialPort1.IsOpen) return;

            // If the port is Open, declare a char[] array with one element.
            char[] buff = new char[1];

            // Load element 0 with the key character.

            buff[0] = e.KeyChar;

            // Send the one character buffer.
            serialPort1.Write(buff, 0, 1);

            // Set the KeyPress event as handled so the character won't
            // display locally. If you want it to display, omit the next line.
            e.Handled = true;
        }

        private void ReadTime_Click(object sender, EventArgs e)
        {
            serialPort1.Write("\x01" +ReturnBCC("R1" + "\x02" + "0.9.1()" + "\x03"));
        }

        private string ReturnBCC(string input)
        {
           char bcc='\x0';
           foreach (char c in input)
               bcc ^= c;
           return input + bcc;
        }

        private void ReadData_Click(object sender, EventArgs e)
        {
             serialPort1.Write("\x01" + ReturnBCC("R1" + "\x02" + ReadOBIS.Text + "\x03"));
            //MessageBox.Show("#"+ReadOBIS.Text+"#");

        }

        private void WriteData_Click(object sender, EventArgs e)
        {
            serialPort1.Write("\x01" + ReturnBCC("W1" + "\x02" + WriteOBIS.Text + "\x03"));
        }


    }
}
