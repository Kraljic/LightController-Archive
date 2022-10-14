using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LightController
{
    public static class LedController
    {
        private static ScrollBar _intensity;
        private static TrackBar _red;
        private static TrackBar _green;
        private static TrackBar _blue;

        public static void Init(ScrollBar intensity)
        {
            _intensity = intensity;
        }

        public static void Manual(float r, float g, float b)
        {
            r = r * (_intensity.Value / 100f);
            g = g * (_intensity.Value / 100f);
            b = b * (_intensity.Value / 100f);
            
            Arduino.Send(new[] { (byte)'1', ToByte(r), ToByte(g), ToByte(b) });
        }

        private static byte ToByte(float val)
        {
            if (val > 255)
                val = 255;
            else if (val < 0)
                val = 0;

            return (byte) val;
        }

        public static void Automatic()
        {
            Arduino.Send('2');
        }
    }
}
