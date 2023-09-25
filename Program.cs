using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<human> humanlist = new List<human>();
            ConsoleKeyInfo info;
            do{
                human human = new human();
                human.ID = 0;
                info = Console.ReadKey();
                File.WriteAllText("f:\file.txt",human.ToString());
            }while (info.Key != ConsoleKey.Escape);
        }
        
    }
    class human
    {
        public string name;
        public int ID;
        public decimal salary;
    }
}
