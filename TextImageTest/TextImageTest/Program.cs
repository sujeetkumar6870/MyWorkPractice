using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TextImageTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstText = "Hello David, How are you doing, Is Everything good";
            string secondText = "World is very  beautyful";

            PointF firstLocation = new PointF(150f, 200f);
            PointF secondLocation = new PointF(200f, 230f);

            string imageFilePath = @"c:\users\kumasuje\source\repos\TextImageTest\TextImageTest\Resources\1.bmp";
            string imageFilePath1 = @"c:\users\kumasuje\source\repos\TextImageTest\TextImageTest\1.bmp";
            Bitmap bitmap = (Bitmap)Image.FromFile(imageFilePath);//load the image file

            Console.WriteLine(bitmap.Height);
            Console.WriteLine(bitmap.Width);

            try
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Font arialFont = new Font("Arial", 2))
                    {
                        graphics.DrawString(firstText, arialFont, Brushes.Blue, firstLocation);
                        graphics.DrawString(secondText, arialFont, Brushes.Red, secondLocation);
                    }
                }

                bitmap.Save(imageFilePath1);//save the image file
                Console.WriteLine("Success");
                Console.ReadKey();
            }
            catch (Exception pEx)
            {

                Console.WriteLine(pEx.Message);
            }
            
        }
    }
}
