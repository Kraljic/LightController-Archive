using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace LightController
{
    public static class Arduino
    {
        private static readonly SerialPort Serial = new SerialPort();

        public static void Connect()
        {
            Disconnect();

            try
            {
                Serial.PortName = Properties.Settings.Default.Port;
                Serial.BaudRate = (int)Properties.Settings.Default.Baud;

                Serial.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void Disconnect()
        {
            try
            {
                Serial.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void Send(byte[] data)
        {
            try
            {
                Serial.Write(data, 0, data.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void Send(char data)
        {
            Send(new []{(byte)data });
        }
        public static void Send(byte data)
        {
            Send(new[] { data });
        }
        public static void Send(string data)
        {
            Send(Encoding.UTF8.GetBytes(data));
        }
        public static void SendLine(string data)
        {
            Send(Encoding.UTF8.GetBytes(data + '\n'));
        }
    }
}
