using System;
using System.IO;

namespace TopTenFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] downloadPaths = Directory.GetFiles(@"C:\Users\Nedas\Downloads\");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(downloadPaths[i]);
            }

        }
    }
}
