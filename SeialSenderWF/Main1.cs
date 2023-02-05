using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace SeialSenderWF
{
    public partial class Main1 : Form
    {
        static Thread readThread;
        static bool _continue;
        static SerialPort _serialPort;

        static System.Windows.Forms.Timer CheckTimer = new System.Windows.Forms.Timer();
        string message;
        static String[] portname = {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9" };
        static int[] baudspeed = {  9600, 14400, 19200, 38400, 57600, 115200, 256000 };
        string msg = "";
        public Main1()
        {
            InitializeComponent();
            port_combo.SelectedIndex = config.Default.port;
            speed_combo.SelectedIndex = config.Default.speed;

            _continue = false;
            _serialPort = new SerialPort();

            CheckTimer.Tick += new EventHandler(Check);

            CheckTimer.Interval = 500;
            CheckTimer.Start();
        }
        private void Check(Object myObject, EventArgs myEventArgs)
        {
              if (string.Equals(message, "boot\r"))
              {
                    ok_label.ForeColor = Color.Green;
                    ok_label.Text = "Booting ok";
              }
              else
              {
                    ok_label.ForeColor = Color.Red;
                    ok_label.Text = "NG";
              }
        }
        private void Read()
        {
            while (_continue)
            {
                try
                {
                    message = _serialPort.ReadLine();
                    WriteLog(">>"+message);
                    Console.WriteLine(message);
                }
                catch (TimeoutException) 
                {
                    //Console.WriteLine(message + ";");
                }
            }            
        }
        public void WriteLog(string text)
        {
            if (log_textbox.InvokeRequired)
            {
                    Action safeWrite = delegate { WriteLog($"{text}"); };
                    log_textbox.Invoke(safeWrite);
            }
            else
                {
                    log_textbox.AppendText(text);
                }
        }
        private void send_button_Click(object sender, EventArgs e)
        {
            _serialPort.Write("boot\n");
            log_textbox.AppendText("<<boot\n");
        }
        private void write_button_Click(object sender, EventArgs e)
        {
            _serialPort.Write("222\n");
            log_textbox.AppendText("<<222\n");
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            if (string.Equals(message, "boot\r"))
            {
                ok_label.ForeColor = Color.Green;
                ok_label.Text = "OK";
            }
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            connect();
        }
        private void save_button_Click(object sender, EventArgs e)
        {
            config.Default.port = port_combo.SelectedIndex;
            config.Default.speed = speed_combo.SelectedIndex;
            config.Default.Save();
        }
        private void connect()
        {                      
            try
            {
                readThread = new Thread(Read);

                _serialPort.PortName = portname[config.Default.port];
                _serialPort.BaudRate = baudspeed[config.Default.speed];

                _serialPort.Parity = 0;
                _serialPort.DataBits = 8;
                _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1", true);
                _serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "0", true);
                _serialPort.DtrEnable = false;

                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 500;

                _serialPort.Open();
                WriteLog("<<Connected.\n");

                readThread.Start();
                _continue = true;
                //readThread.Join();
            }
            catch (Exception exc)
            {
                WriteLog("Error while connecting:\n");
                MessageBox.Show("Error while connecting:\n" + exc.Message);
            }
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            readThread.Abort();
            _serialPort.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _continue = false;
            readThread.Join();
            readThread.Abort();
            _serialPort.Close();            
        }
    }
}