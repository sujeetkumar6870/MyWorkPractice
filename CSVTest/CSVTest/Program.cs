using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace CSVTest
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\Users\kumasuje\Downloads\EmailList.txt"))
            {
                List<string> listA = new List<string>();
                var line = reader.ReadToEnd();
                var values = line.Split('\n');
                //int i = values.Length;
                //Console.WriteLine(i);


                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine("value[" + i + "]=" + values[i]);
                }


                //Console.WriteLine(line);
                //while (!reader.EndOfStream)
                //{
                //    var line = reader.ReadToEnd();
                //    //var values = line.Split(',');

                //    listA.Add(line);
                //}
                //for (int i = 0; i < listA.Capacity; i++)
                //{
                //    Console.WriteLine(listA[i].ToString());
                //}
            }
            Console.ReadLine();
        }
    }
}
