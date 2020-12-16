using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;


namespace Lab_4
{
    public class Task2
    {
        private static readonly string DefaultPathDir = $@"{Directory.GetCurrentDirectory()}\pict\";

        private int count = 0;

        public void method()
        {
            Regex regex = new Regex("^((.bmp)|(.gif)|(.tiff?)|(.jpe?g)|(.png))$", RegexOptions.IgnoreCase);
            string[] picts = Directory.GetFiles(DefaultPathDir);
            
            foreach (string pict in picts)
            {
                try
                {
                    if (regex.IsMatch(Path.GetExtension(pict)))
                    {
                        Bitmap bitmap = new Bitmap(pict);
                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipY);
                        string fileName = Path.GetFileNameWithoutExtension(pict);
                        bitmap.Save(DefaultPathDir + fileName + "-mirrored.gif");
                        bitmap.Dispose();
                        count++;
                    }
                    else
                        throw new Exception($"File [{Path.GetFileName(pict)}] not a image!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}