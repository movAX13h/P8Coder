using System.Drawing;

namespace P8Coder.Core
{
    public class Device
    {
        public static readonly Color[] Palette = new Color[]
		{
			Color.FromArgb(0, 0, 0),		// 0 black 
			Color.FromArgb(29, 43, 83),		// 1 dark blue 
			Color.FromArgb(126, 37, 83),	// 2 dark purple 
			Color.FromArgb(0, 135, 81),		// 3 dark green 
			Color.FromArgb(171, 82, 54),	// 4 brown 
			Color.FromArgb(95, 87, 79),		// 5 dark gray 
			Color.FromArgb(194, 195, 199),	// 6 light gray 
			Color.FromArgb(255, 241, 232),	// 7 white
			Color.FromArgb(255, 0, 77),		// 8 red 
			Color.FromArgb(255, 163, 0),	// 9 orange 
			Color.FromArgb(255, 255, 39),	// a yellow 
			Color.FromArgb(0, 231, 88),		// b light green 
			Color.FromArgb(41, 173, 255),	// c light blue 
			Color.FromArgb(131, 118, 156),	// d light purple 
			Color.FromArgb(255, 119, 168),	// e dark pink 
			Color.FromArgb(255, 204, 170)	// f light pink 
		};
    }
}
