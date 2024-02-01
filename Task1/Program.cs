using ExceptionTask;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace ExceptionPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[5] { new MyException(), new DriveNotFoundException(), new DirectoryNotFoundException(), new FileNotFoundException(), new PathTooLongException() };
            string userInput = string.Empty;
            foreach (Exception e in exceptions)
            {
                try
                {

                    Console.WriteLine("Please show the link to the .txt file");
                    userInput = Console.ReadLine();
                    throw e;

                }
                catch (MyException ex)
                {
                    var regex = new Regex(@".txt");
                    if (!regex.IsMatch(userInput))
                    {
                        Console.WriteLine(ex.message);
                    }
                }
                catch (DriveNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (PathTooLongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}