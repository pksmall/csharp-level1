using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace task0504
{
    class GenerateList
    {

        public void Generate(string path = "db.txt", int count = 100)
        {
            //RandEnum();
            NewNumber();
            File.Delete(path);
            System.IO.File.AppendAllText(path, $"{count}\n");
            for (int i = 0; i < count; i++)
            {
                System.IO.File.AppendAllText(path,
                    $"Иванов_{i + 1} Иван_{i + 1} {GetRand()} {GetRand()} {GetRand()}\n"
                );
            }
        }
        private int GetRand()
        {
            Random r = new Random();
            return r.Next(1, 6);
        }

        private uint[] RandEnum()
        {
            var r = new Random();
            var s = Enumerable.Range(0x00, 0xff);

            // shuffle a large set of int.MaxValue
            var hh = s.OrderBy(x => r.Next()).ToArray();
            var hl = s.OrderBy(x => r.Next()).ToArray();
            var lh = s.OrderBy(x => r.Next()).ToArray();
            var ll = s.OrderBy(x => r.Next()).ToArray();

            // Draw 255 unique unsigned integers from 0 to uint.MaxValue
            var ints = new uint[255];
            for (var i = 0; i < 255; i++)
                ints[i] = (uint)(hh[i] << 24 | hl[i] << 16 | lh[i] << 8 | ll[i]);

            // Print them
            for (var i = 0; i < 255; i++)
            {
                Console.WriteLine(ints[i]);
            }

            return ints;
        }
        // replace from new Random(DateTime.Now.Ticks.GetHashCode());
        // Since similar code is done in default constructor internally
        public Random a = new Random();
        public List<int> randomList = new List<int>();
        int MyNumber = 0;
        private void NewNumber()
        {
            MyNumber = a.Next(1, 10);
            if (!randomList.Contains(MyNumber))
            {
                randomList.Add(MyNumber);

            }
            foreach(var item in randomList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
