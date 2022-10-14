using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LightController
{
    public partial class Settings : Form
    {
        public uint Baud { get; private set; } = 9600;
        public string Port { get; private set; } = "";

        private readonly List<string> _baudSpeeds = new List<string>() {"1200", "9600", "19200", "38400", "57600", "115200", "250000"};

        public Settings(string port, uint baud)
        {
            InitializeComponent();
            
            // Get serial ports
            var portList = SerialPort.GetPortNames().ToList();
            // Copy items to combobox
            cbPort.Items.AddRange(portList.ToArray());
            // Select item in combobox
            cbPort.Text = port;
            
            // Copy items to combobox
            cbBaud.Items.AddRange(_baudSpeeds.ToArray());
            // Select item in combobox
            var baudIndex = _baudSpeeds.FindIndex(b => b == baud.ToString());
            if (baudIndex > -1)
                cbBaud.SelectedIndex = baudIndex;
            else if (_baudSpeeds.Count > 0)
                cbBaud.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Baud = uint.Parse((string)cbBaud.SelectedItem);
            Port = cbPort.Text;

            this.DialogResult = DialogResult.Yes;
        }
    }
}
