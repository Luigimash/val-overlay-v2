using System.Drawing;
using System.Drawing.Common;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(GetColorAt(1,2));

Color GetColorAt(int x, int y)
{
    Bitmap bmp = new Bitmap(1, 1);
    Rectangle bounds = new Rectangle(x, y, 1, 1);
    using (Graphics g = Graphics.FromImage(bmp))
        g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
    return bmp.GetPixel(0, 0);
}