﻿using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            bool loop = true;
            
            while (loop)
            {
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Subtract");
                Console.WriteLine("3 - Multiply");
                Console.WriteLine("4 - Divide");
                Console.WriteLine("5 - Exit");
                Console.Write("Your option? ");
                int choise = Convert.ToInt32(Console.ReadLine());
                
                switch (choise)
                {
                    default:
                        double a_real, b_real, a_imaginary, b_imaginary;
                        Complex result;
                        break;

                    case 1:
 
                        Console.Clear();
                        Console.WriteLine("a_real: ");
                        a_real = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("a_imaginary: ");
                        a_imaginary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b_real: ");
                        b_real = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b_imaginary: ");
                        b_imaginary = Convert.ToDouble(Console.ReadLine());
                        result = client.Add(a_real, a_imaginary, b_real, b_imaginary);
                        if(result.Imaginary > 0)
                        {
                            Console.WriteLine("Result:" + result.Real + "+" + result.Imaginary + "i");
                        }
                        else
                            Console.WriteLine("Result:" + result.Real +  result.Imaginary + "i");
                        break;


                    case 2:
                        Console.Clear();
                        Console.WriteLine("a_real: ");
                        a_real = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("a_imaginary: ");
                        a_imaginary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b_real: ");
                        b_real = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b_imaginary: ");
                        b_imaginary = Convert.ToDouble(Console.ReadLine());
                        result = client.Substract(a_real, a_imaginary, b_real, b_imaginary);
                        if (result.Imaginary > 0)
                        {
                            Console.WriteLine("Result:" + result.Real + "+" + result.Imaginary + "i");
                        }
                        else
                            Console.WriteLine("Result:" + result.Real + result.Imaginary + "i");
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("a_real: ");
                        a_real = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("a_imaginary: ");
                        a_imaginary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b_real: ");
                        b_real = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b_imaginary: ");
                        b_imaginary = Convert.ToDouble(Console.ReadLine());
                        result = client.Multiply(a_real, a_imaginary, b_real, b_imaginary);
                        if (result.Imaginary > 0)
                        {
                            Console.WriteLine("Result:" + result.Real + "+" + result.Imaginary + "i");
                        }
                        else
                            Console.WriteLine("Result:" + result.Real + result.Imaginary + "i");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("a_real: ");
                        a_real = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("a_imaginary: ");
                        a_imaginary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b_real: ");
                        b_real = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b_imaginary: ");
                        b_imaginary = Convert.ToDouble(Console.ReadLine());
                        result = client.Divide(a_real, a_imaginary, b_real, b_imaginary);
                        if (result.Imaginary > 0)
                        {
                            Console.WriteLine("Result:" + result.Real + "+" + result.Imaginary + "i");
                        }
                        else
                            Console.WriteLine("Result:" + result.Real + result.Imaginary + "i");
                        break;

                    case 5:
                        Console.Write("Press any key to close the Calculator console app...");
                        Console.ReadKey();
                        loop = false;
                        break;
                }
                
                
            }
            
        }
    }
}

