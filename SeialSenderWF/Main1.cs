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
        static bool _continue, _start, _boot;
        static SerialPort _serialPort;

        static System.Windows.Forms.Timer CheckTimer = new System.Windows.Forms.Timer();
        string message;
        static String[] portname = { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM25" };
        static int[] baudspeed = { 9600, 14400, 19200, 38400, 57600, 115200, 256000 };
        static public Task delay = Task.Delay(2000);
        public Main1()
        {
            InitializeComponent();
            port_combo.SelectedIndex = config.Default.port;
            speed_combo.SelectedIndex = config.Default.speed;

            _start = false;
            _continue = false;
            _boot = false;
            _serialPort = new SerialPort();

            CheckTimer.Tick += new EventHandler(Check);

            CheckTimer.Interval = 1000;
            CheckTimer.Start();


        }
        private void Check(Object myObject, EventArgs myEventArgs)
        {
            Console.WriteLine(message);
            if (_start)
            {
                if (!string.Equals(message, "AT+DH_BOOTING_STATE_RES:1\r") & !_boot)
                {
                    boot_cmd();
                }
                else
                {
                    _boot = true;
                    ok_label.ForeColor = Color.Green;
                    ok_label.Text = "Boot ok, writing PN";
                    writepn_cmd();
                    string pn = pn_box.Text + "\r";
                    readpn_cmd();
                    if (string.Equals(message.Substring(23), pn))
                    {
                        ok_label.Text = "Write OK";
                        _start = false;
                    }
                }
            }
        }
        private void Read()
        {
            while (_continue)
            {
                try
                {
                    message = _serialPort.ReadLine();
                    WriteLog(">>" + message);
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
            boot_cmd();
        }
        private void boot_cmd()
        {
            _serialPort.Write("AT+\r\n");
            delay.Wait();
            _serialPort.Write("AT+\r\n");
            log_textbox.AppendText("<<boot\n");
        }
        private void write_button_Click(object sender, EventArgs e)
        {
            _serialPort.Write("AT+\r\n");
        }
        private void writepn_cmd()
        {
            _serialPort.Write("AT+:" + pn_box.Text + "\r\n");
            delay.Wait();
            //log_textbox.AppendText("<<P/N writing " + pn_box.Text + "\n");
        }
        private void readpn_cmd()
        {
            _serialPort.Write("AT+\r\n");
            delay.Wait();
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            _start = true;
            _boot = false;
            ok_label.Text = "Starting";
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
            Environment.Exit(1);
            _continue = false;
            //readThread.Join();
            readThread.Abort();
            _serialPort.Close();
        }
    }
}