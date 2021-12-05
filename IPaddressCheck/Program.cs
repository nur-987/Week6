using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPaddressCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter IP address: ");
            string ipAddress = Console.ReadLine();
            Program p = new Program();
            if (p.Check(ipAddress))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
           
            Console.ReadLine();
        }

        public bool Check(string str)
        {
            //string str = "192.168.A.1";
            if (str.Any(Char.IsLetter))
            {
                Console.WriteLine(" Not Valid");
                return false;
            }
            string[] arrayOfNum = str.Split('.');  
            int count = arrayOfNum.Count();
            if (count < 4 && count >4)
            {
                Console.WriteLine(" Not Valid");
                return false;
            }
            //check that al/ numbers between 0 - 255
            foreach(string item in arrayOfNum)
            {
                int itemInt = Int32.Parse(item);
                if (itemInt < 0 || itemInt > 255)
                {
                    Console.WriteLine(" Not Valid");
                    return false;
                }
            }

            return true;
            
        }
    }




        
}
