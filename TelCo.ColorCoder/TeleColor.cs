using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TelCo.ColorCoder
{
    public class TeleColor
    {
        internal static Color[] colorMapMajor;
        internal static Color[] colorMapMinor;
       
        internal class ColorPair
        {
            internal Color majorColor;
            internal Color minorColor;
            public override string ToString()
            {
                return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
            }
        }
        static TeleColor()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }
}
