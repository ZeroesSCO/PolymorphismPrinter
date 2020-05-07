using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymophismPrinter{
    class Program{
        static void Main(string[] args){
            PrinterWindows Device = new PrinterWindows() ;
            Console.WriteLine("Select Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("Pilih Nomor Printer [1/2/3] : ");

            int PrinterCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            if(PrinterCode == 1){
                Device = new Epson();
            }
            else if(PrinterCode == 2){
                Device = new Canon();
            }
            else{
                Device = new LaserJet();
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}