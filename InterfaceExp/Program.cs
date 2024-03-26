using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExp
{
    public interface ISample
    {
        void Print();
    }
    internal class Program:ISample
    {
        public void Print()
        {
            Console.WriteLine("Interface Here");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Print();
        }
    }
}
