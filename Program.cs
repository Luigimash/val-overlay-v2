using System.Drawing;
using System.IO;
// See https://aka.ms/new-console-template for more information
// USE VALORANT ON MAIN/DEFAULT MONITOR, DO NOT OBS ON SECONDARY MONITOR
Console.WriteLine("Hello, World!");

Console.WriteLine(GetColorAt(418,51) + " def (left) color");
Console.WriteLine(GetColorAt(1504,50) + " atk (right) color");

Color defColor = GetColorAt(418,51);
Color atkColor = GetColorAt(1504,50);
string[] output = new string[2];
if (defColor.G >= defColor.R) {
    Console.WriteLine("defSide");
    output[0] = "true";
}
else {
    Console.WriteLine("defSide = false");
        output[0] = "false";
}

if (atkColor.R >= atkColor.G) {
    Console.WriteLine("atkSide");
    output[1] = "true";
}
else {
    Console.WriteLine("atkSide = false");
        output[1] = "false";
}
File.WriteAllLinesAsync("sideColors.txt", output);


Color GetColorAt(int x, int y)
{
    Bitmap bmp = new Bitmap(1, 1);
    Rectangle bounds = new Rectangle(x, y, 2, 2); 
    //new Rectangle (posX, posY, xWidth, yHeight);
    //use MouseLoc to find specific coordinates of cursor quickly 
    using (Graphics g = Graphics.FromImage(bmp))
        g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
    return bmp.GetPixel(0, 0);
}
//Test C# VSCODE project for a script that checks the color value of a pixel at a specific location 