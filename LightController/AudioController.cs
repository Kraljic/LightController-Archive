using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;

namespace LightController
{
    public static class AudioController
    {
        private static Thread _runThread;
        private static bool _run;

        private static string _deviceName;
        private static WasapiLoopbackCapture _audioDevice;
        

        public static void Start(string deviceName)
        {
            _deviceName = deviceName;

            Stop();

            _runThread = new Thread(Run);
            _runThread.Start();
        }

        public static void Stop()
        {
            try
            {
                _run = false;
                _runThread.Abort();
                _audioDevice.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        private static void Run()
        {
            var deviceList = MMDeviceEnumerator.EnumerateDevices(DataFlow.Render, DeviceState.Active).ToList();

            Arduino.Connect();
            _audioDevice = new WasapiLoopbackCapture(50, new WaveFormat(44100, 32, 1));
            _audioDevice.DataAvailable += _audioDevice_DataAvailable;
            _audioDevice.Initialize();
            _audioDevice.Device = deviceList.Find(d => d.FriendlyName == _deviceName);
            _audioDevice.Start();

            Console.WriteLine("Starting audio controller: ");
            Console.WriteLine(_audioDevice.Device.FriendlyName);

            _run = true;
            while (_run)
            {

            }
        }

        private static void _audioDevice_DataAvailable(object sender, DataAvailableEventArgs e)
        {
            Console.WriteLine("New data");
        }


    }
}
