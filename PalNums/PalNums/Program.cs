using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalNums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = 1;
                while (num > 0)
                {
                    string counter = num.ToString();
                    bool Pal = true;
                    for (int i = 0; i < counter.Length / 2; i++)
                    {
                        if (counter[i] != counter[(counter.Length - 1) - i])
                        {
                            Pal = false;
                            break;
                        }
                    }
                    Console.WriteLine("The Palindrome Numbers are : ");
                    if (Pal)
                    {
                        Console.WriteLine("Palindrome :" + num);
                    }
                    num++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught ");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
