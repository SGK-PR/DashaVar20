using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DashaVar20
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Введите код специальности:");
            s = Convert.ToString(Console.ReadLine());

            string[] vs = s.Split('-');
            if(s.Length<9 && s.Length>7)
            {
                Console.WriteLine("Код верный");
            }
            else 
            {
                Console.WriteLine("Код неверный");
            }
            Console.ReadLine();
        }
         
      
        
    }
}
