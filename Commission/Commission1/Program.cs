using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commission1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sales = new double[9];
            string[] lastName = new string[9];
            string[] range = { "$200-299", "$300-399", "$400-499", "$500-599", "$600-699", "$700-799", "$800-899", "$900-999", "$1000 and over" };
            double[] netSale = new double[9];
            int[] counter = new int[9];
            for (int i = 0; i < 9; i++)
                counter[i] = 0;
            GetInformation(sales, lastName);
            CalcNetSales(netSale, sales, counter);
            DisplayInformation(lastName, netSale);
            DisplayChart(range, counter, lastName);
        }

        static void GetInformation(double[] sales, string[] lastName)
        {

            
            for (int i = 0; i < 8; i++)
            {
                Write("Enter the salesperson " + i + " last name: " );
                lastName[i] = ReadLine();
                Write("Please enter " + lastName[i] + "'s weekly gross pay: " );
                sales[i] = Convert.ToInt32(ReadLine());

                Write("\nwould you like to continue? Press the letter 'Y' or 'N': ");
                string entry = Convert.ToString(ReadLine());

                if (entry == "n")
                    break;
                else if (entry == "y")
                    continue;
                else
                    WriteLine("\nError! That was not a 'y' or 'n'.\nYou have been automaticlly continued.\n"); 
            }

        }

        private static void CalcNetSales(double[] netSale, double[] sales, int[] counter)
        {
            for (int i = 0; i <= sales.Length-1; i++)
            {
                netSale[i] = 200 + ((sales[i] * 9) / 100);
                if (netSale[i] >= 200 && netSale[i] <= 299)
                    counter[0]++;
                else if (netSale[i] >= 300 && netSale[i] <= 399)
                    counter[1]++;
                else if (netSale[i] >= 400 && netSale[i] <= 499)
                    counter[2]++;
                else if (netSale[i] >= 500 && netSale[i] <= 599)
                    counter[3]++;
                else if (netSale[i] >= 600 && netSale[i] <= 699)
                    counter[4]++;
                else if (netSale[i] >= 700 && netSale[i] <= 799)
                    counter[5]++;
                else if (netSale[i] >= 800 && netSale[i] <= 899)
                    counter[6]++;
                else if (netSale[i] >= 900 && netSale[i] <= 999)
                    counter[7]++;
                else
                    counter[8]++;
            }
        }

        private static void DisplayInformation(string[] lastName, double[] netSale)
        {
            WriteLine("____________________________________________________________");
            WriteLine("************************************************************");
            WriteLine(" Employee Information is :\n");
            for (int i = 0; i < 8; i++)
            {
                if (lastName[i] != null)
                    WriteLine(lastName[i] + " Weekly Salary is : $" + netSale[i]);
                else if (lastName == null)
                    break;
            }
        }

        private static void DisplayChart(string[] range, int[] counter, string[] lastName)
        {
            
            WriteLine("\nEmployee range count:");
            for (int i = 0; i < 9; i++)
            {
                WriteLine(range[i] + ": " + counter[i]);
                

               
            }
            ReadLine();
        }
    }
}

