
using ExceptionTask2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ExceptionTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListОfNames<string> nList = new ListОfNames<string>() { "Joe", "Ivan", "Petr", "Bob", "Irwin" };

            Sort sort = new();

            try
            {
                Console.WriteLine("Пожалуйста укажите 5 фамилий, с большой буквы");

                for (int i = 0; i < 5; i++)
                {
                    nList[i] = Convert.ToString(Console.ReadLine());
                    string str = nList[i];
                    if (!char.IsUpper(str[0])) throw new NoUpException();

                }

                Console.WriteLine("Введите значение 1 для сортировки списка в порядке от А до Я, либо 2 для сортировки от Я до А:");

                int number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:

                        Console.WriteLine("Сортировка списка от А до Я");
                        sort.SortList(nList);
                        break;
                    case 2:
                        Console.WriteLine("Сортировка списка от Я до А");
                        sort.RevSortList(nList);
                        break;

                }
                if (number != 1 && number != 2) throw new FormatException();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Введите 1 либо 2");
            }
            catch (NoUpException) 
            {
                Console.WriteLine("Фамилия должна быть введена с большой буквы");
            }

        }


    }

}


