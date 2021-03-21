using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = null;

            do
            {
                Console.Clear();

                ShowMenu();
                MenuPoints point = SetMenuPoint();

                if (point == 0) continue;

                if (point == MenuPoints.Exit)
                {
                    Console.WriteLine("Exit the program...");
                    Thread.Sleep(1500);
                    break;
                }

                switch (point)
                {
                    case MenuPoints.CreateCompany:
                        {
                            company = Company.GetCompanyInstance();
                            Console.WriteLine("Company was created!");
                            Thread.Sleep(3000);
                            break;
                        }
                    case MenuPoints.ShowEmployeesNumber:
                        {
                            if(company == null)
                            {
                                Console.WriteLine("Company is not created!");
                            }
                            else
                            {
                                Console.WriteLine($"{company.GetEmployeesNumber()} employees work for {company.CompanyName} company");
                                Thread.Sleep(1500);
                            }
                            break;
                        }
                    case MenuPoints.HireEmployee:
                        {
                            if (company == null)
                            {
                                Console.WriteLine("Company is not created!");
                            }
                            else
                            {
                                company.HireEmployee();
                                Console.WriteLine("Operation completed!");
                                Thread.Sleep(1500);
                            }
                            break;
                        }
                    case MenuPoints.DismissEmployee:
                        {
                            if (company == null)
                            {
                                Console.WriteLine("Company is not created!");
                            }
                            else
                            {
                                company.DissmisEmployee();
                                Console.WriteLine("Operation completed!");
                                Thread.Sleep(1500);
                            }
                            break;
                        }
                    default:
                        {
                            Console.Beep();
                            Console.WriteLine("Unknown command!");
                            Thread.Sleep(1500);
                            break;
                        }
                }

            } while (true);
        }

        static void ShowMenu()
        {
            Console.WriteLine("---------Menu---------");
            Console.WriteLine("1 - Create company");
            Console.WriteLine("2 - Show numbers of employee");
            Console.WriteLine("3 - Hire employee");
            Console.WriteLine("4 - Dismiss employee");
            Console.WriteLine("5 - Exit");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Command:");
        }

        static MenuPoints SetMenuPoint()
        {
            int choice;
            bool isNumber = int.TryParse(Console.ReadLine(), out choice);

            Console.ResetColor();

            if(isNumber)
            {
                return (MenuPoints)choice;
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Unknown command!");
                Thread.Sleep(1000);
                return 0;
            }
        }

        enum MenuPoints
        {
            CreateCompany = 1,
            ShowEmployeesNumber,
            HireEmployee,
            DismissEmployee,
            Exit
        }
    }
}
