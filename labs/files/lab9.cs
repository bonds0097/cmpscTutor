using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tutoring_lab9
{
    class Program
    {
        public const int MAX_SIZE = 5;      // Max Number of Data Points to Store
        static void Main(string[] args)
        {
            double[] data;      // Numbers read from file.
            int logSize;        // Logical Size of Data
            StreamReader reader;

            data = new double[MAX_SIZE];
            logSize = 0;

            reader = File.OpenText("C:\\input.txt");

            while (reader.Peek() != -1)
            {
                data[logSize] = Convert.ToDouble(reader.ReadLine());

                Console.WriteLine(data[logSize]);
                logSize++;
            }
        }
    }
}
