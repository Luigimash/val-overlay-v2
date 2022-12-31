using System.Drawing;
using System.IO;
// See https://aka.ms/new-console-template for more information
// USE VALORANT ON MAIN/DEFAULT MONITOR, DO NOT OBS ON SECONDARY MONITOR
const int PULLRATE = 500; //Amount of time (milliseconds) per pixel check loop
Console.WriteLine("Program.cs started, beginning to check pixels:");

Console.WriteLine(GetColorAt(418,51) + " def (left) color");
Console.WriteLine(GetColorAt(1504,50) + " atk (right) color");
while (true) {
    Color defColor = GetColorAt(418,51);
    Color atkColor = GetColorAt(1504,50);
    string[] output = new string[2];
    if (defColor.G >= defColor.R) {
        Console.WriteLine("defSide is green");
        output[0] = "true";
    }
    else {
        Console.WriteLine("defSide is red");
            output[0] = "false";
    }

    if (atkColor.R >= atkColor.G) {
        Console.WriteLine("atkSide is red");
        output[1] = "true";
    }
    else {
        Console.WriteLine("atkSide is green");
            output[1] = "false";
    }
    await File.WriteAllLinesAsync("sideColors.txt", output);
    await Task.Delay(PULLRATE);
}

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