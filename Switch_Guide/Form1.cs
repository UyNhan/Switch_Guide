using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Guide
{
    public partial class Form1 : Form
    {
        private ManagementEventWatcher arrival;
        private ManagementEventWatcher removal;

        public Form1()
        {
            InitializeComponent();
            UpdateSerialPortList();
            StartListeningForSerialPortChanges();
        }

        private void StartListeningForSerialPortChanges()
        {
            ManagementEventWatcher arrival = new ManagementEventWatcher("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");
            arrival.EventArrived += (sender, e) => UpdateSerialPortList();
            arrival.Start();

            ManagementEventWatcher removal = new ManagementEventWatcher("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3");
            removal.EventArrived += (sender, e) => UpdateSerialPortList();
            removal.Start();
        }

        private void UpdateSerialPortList()
        {
            if (comboBox_COM.InvokeRequired)
            {
                comboBox_COM.Invoke(new MethodInvoker(UpdateSerialPortList));
                return;
            }

            string[] ports = SerialPort.GetPortNames();
            comboBox_COM.Items.Clear();
            comboBox_COM.Items.AddRange(ports);    
        }


        private void InitializeSerialPort()
        {
            comboBox_COM.Items.Clear();

            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                //comboBox_COM.Items.Insert(0, port);
                comboBox_COM.Items.Add(port);
            }

            if (comboBox_COM.Items.Count > 0)
            {
                comboBox_COM.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Can not find com port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSerialPort();

            button_disconnect.Enabled = false;

            tabControl1.Enabled = false;

            textBox_timer_RF1.Enabled = false;
            textBox_timer_RF2.Enabled = false;
            textBox_timer_RF3.Enabled = false;
            textBox_timer_RF4.Enabled = false;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {

            if (comboBox_Baudrate.SelectedItem == null)
            {
                MessageBox.Show("Baudrate isn't choose!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        Control.CheckForIllegalCrossThreadCalls = false;
                        serialPort1.PortName = comboBox_COM.SelectedItem.ToString();
                        serialPort1.BaudRate = int.Parse(comboBox_Baudrate.SelectedItem.ToString());
                        serialPort1.Open();

                        comboBox_COM.Enabled = false;
                        comboBox_Baudrate.Enabled = false;
                        button_connect.Enabled = false;
                        button_disconnect.Enabled = true;

                        tabControl1.Enabled = true;
                    }
                    catch (UnauthorizedAccessException)
                    {
                    
                        MessageBox.Show("Access to the port is denied. Please check if the port is already in use or you do not have the necessary permissions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();

            comboBox_COM.Enabled = true;
            comboBox_Baudrate.Enabled = true;
            button_connect.Enabled = true;
            button_disconnect.Enabled = false;

            tabControl1.Enabled = false;
        }

        private void button_set_auto_Click(object sender, EventArgs e)
        {
           if(textBox_timer_auto.Text.Length > 0)
           {
                int timerAutoValue;
                if (int.TryParse(textBox_timer_auto.Text, out timerAutoValue))
                {
                    if (timerAutoValue >= 1 && timerAutoValue <= 60000)
                    {
                        serialPort1.Write(textBox_timer_auto.Text.PadLeft(5, '0'));
                        serialPort1.Write("\n");
                    }
                    else
                    {
                        MessageBox.Show("The value must be between 1 and 60000!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           else
           {
                MessageBox.Show("Timer is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
        }

        private void checkBox_RF1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_timer_RF1.Enabled = true;
            if (!checkBox_RF1.Checked)
            {
                textBox_timer_RF1.Enabled = false;
            }
        }

        private void checkBox_RF2_CheckedChanged(object sender, EventArgs e)
        {
            textBox_timer_RF2.Enabled = true;
            if (!checkBox_RF2.Checked)
            {
                textBox_timer_RF2.Enabled = false;
            }
        }

        private void checkBox_RF3_CheckedChanged(object sender, EventArgs e)
        {
            textBox_timer_RF3.Enabled = true;
            if (!checkBox_RF3.Checked)
            {
                textBox_timer_RF3.Enabled = false;
            }
        }

        private void checkBox_RF4_CheckedChanged(object sender, EventArgs e)
        {
            textBox_timer_RF4.Enabled = true;
            if (!checkBox_RF4.Checked)
            {
                textBox_timer_RF4.Enabled = false;
            }
        }

        private void button_set_man_Click(object sender, EventArgs e)
        {
            if (!checkBox_RF1.Checked && !checkBox_RF2.Checked && !checkBox_RF3.Checked && !checkBox_RF4.Checked)
            {
                MessageBox.Show("Timer is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (checkBox_RF1.Checked)
            {
                if (textBox_timer_RF1.Text.Length > 0)
                {
                    int timerManValue1;
                    if (int.TryParse(textBox_timer_RF1.Text, out timerManValue1))
                    {
                        if (timerManValue1 >= 1 && timerManValue1 <= 60000)
                        {
                            serialPort1.Write(textBox_timer_RF1.Text.PadLeft(5, '0'));
                        }
                        else
                        {
                            MessageBox.Show("The value TIMER 1 must be between 1 and 60000!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number of TIMER 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("TIMER 1 is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            else if (!checkBox_RF1.Checked)
            {
                serialPort1.Write("00000");
            }

            if (checkBox_RF2.Checked)
            {
                if (textBox_timer_RF2.Text.Length > 0)
                {
                    int timerManValue2;
                    if (int.TryParse(textBox_timer_RF2.Text, out timerManValue2))
                    {
                        if (timerManValue2 >= 1 && timerManValue2 <= 60000)
                        {
                            serialPort1.Write(textBox_timer_RF2.Text.PadLeft(5, '0'));
                        }
                        else
                        {
                            MessageBox.Show("The value TIMER 2 must be between 1 and 60000!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number of TIMER 2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("TIMER 2 is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (!checkBox_RF2.Checked)
            {
                serialPort1.Write("00000");
            }

            if (checkBox_RF3.Checked)
            {
                if (textBox_timer_RF3.Text.Length > 0)
                {
                    int timerManValue3;
                    if (int.TryParse(textBox_timer_RF3.Text, out timerManValue3))
                    {
                        if (timerManValue3 >= 1 && timerManValue3 <= 60000)
                        {
                            serialPort1.Write(textBox_timer_RF3.Text.PadLeft(5, '0'));
                        }
                        else
                        {
                            MessageBox.Show("The value TIMER 3 must be between 1 and 60000!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number of TIMER 3!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("TIMER 3 is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (!checkBox_RF3.Checked)
            {
                serialPort1.Write("00000");
            }

            if (checkBox_RF4.Checked)
            {
                if (textBox_timer_RF4.Text.Length > 0)
                {
                    int timerManValue4;
                    if (int.TryParse(textBox_timer_RF4.Text, out timerManValue4))
                    {
                        if (timerManValue4 >= 1 && timerManValue4 <= 60000)
                        {
                            serialPort1.Write(textBox_timer_RF4.Text.PadLeft(5, '0'));
                            serialPort1.Write("\n");
                        }
                        else
                        {
                            MessageBox.Show("The value TIMER 4 must be between 1 and 60000!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number of TIMER 4!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("TIMER 4 is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (!checkBox_RF4.Checked)
            {
                serialPort1.Write("00000\n");
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopListeningForSerialPortChanges();
        }

        private void StopListeningForSerialPortChanges()
        {
            if (arrival != null)
            {
                arrival.Stop();
                removal.Stop();
            }
        }
    }
}
