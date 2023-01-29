using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_dengan_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            string pilihan;
            Console.Write("Kamu Lebih Suka Game Berbayar atau Gratis? \n'1' Bayar\n'2' Gratis\n'3' Crack\nkamu pilih apa ? ");
            pilihan = Console.ReadLine();
            switch(pilihan)
            {
                case "1":
                    Console.Write("Berbayar ga tuh, kelazz B)");
                    break;
                case "2":
                    Console.Write("Idiiih player gratisan :P");
                    break;
                default:
                    Console.Write("Mantap, member gw nihh. LANJUTKAN !!");
                    break;
            }
            Console.Read();
        }
    }
}
