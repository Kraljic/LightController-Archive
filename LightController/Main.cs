using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSCore.CoreAudioAPI;

namespace LightController
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            var deviceList = MMDeviceEnumerator.EnumerateDevices(DataFlow.Render, DeviceState.Active);
            cbAudioDevices.Items.AddRange(deviceList.ToArray());
            cbAudioDevices.Text = Properties.Settings.Default.AudioDeviceName;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Arduino.Connect();
            LedController.Init(scrollIntensity);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            scrollIntensity.Value = scrollIntensity.Maximum;

            trackRed.Value = 10;
            trackGreen.Value = 10;
            trackBlue.Value = 10;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings(Properties.Settings.Default.Port, Properties.Settings.Default.Baud);

            if (settingsForm.ShowDialog() == DialogResult.Yes)
            {
                Properties.Settings.Default.Port = settingsForm.Port;
                Properties.Settings.Default.Baud = settingsForm.Baud;
                Properties.Settings.Default.Save();

                // Reconnect
                Arduino.Connect();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.AudioDeviceName = cbAudioDevices.Text;
            Properties.Settings.Default.Save();

            AudioController.Stop();
        }

        private void cbAudioDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAudioDevices.SelectedIndex > -1 && rbMusic.Checked)
            {
                AudioController.Start(cbAudioDevices.Text);
            }
        }

        private void ModeChanged(object sender, EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                return;

            AudioController.Stop();

            if (rbAutomatic.Checked)
            {
                LedController.Automatic();
            }
            else if (rbManual.Checked)
            {
                setRGBValue();
            }
            else if (rbMusic.Checked)
            {
                Console.WriteLine("Penis 56");
                AudioController.Start(cbAudioDevices.Text);
            }
        }

        private void trackRed_ValueChanged(object sender, EventArgs e)
        {
            setRGBValue();
        }

        private void setRGBValue()
        {
            LedController.Manual(trackRed.Value / 20f * 255, trackGreen.Value / 20f * 255, trackBlue.Value / 20f * 255);
        }

        private void scrollIntensity_ValueChanged(object sender, EventArgs e)
        {
            if (rbManual.Checked)
            {
                setRGBValue();
            }
        }
    }
}
