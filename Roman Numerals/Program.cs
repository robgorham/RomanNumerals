using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals
{
    class Program
    {

        /// <summary>
        /// getInt()
        /// grabs a non negative integer from the User through the Console
        /// </summary>
        /// <param name="prompt">Takes a String to display to User before readline</param>
        /// <returns>non Negative integer</returns>
        static int GetInt(string prompt)
        {
            int result = -1;
            string response = "";
            do
            {
                Console.Write(prompt);
                response = Console.ReadLine();

            } while (!int.TryParse(response, out result));
            return result;
        }

        /// <summary>
        /// Takes Non Negative Integer and Returns Roman Numeral Representation
        /// </summary>
        /// <param name="entry">integer greater than 1</param>
        /// <returns></returns>
        static string MakeRoman(int entry)
        {
            string result = "";
            while (entry > 0)
            {
                if (entry >= 1000)
                {
                    result += "M";
                    entry -= 1000;
                }
                else if (entry >= 900)
                {
                    result += "CM";
                    entry -= 900;
                }
                else if (entry >= 500)
                {
                    result += "D";
                    entry -= 500;
                }
                else if (entry >= 400)
                {
                    result += "CD";
                    entry -= 400;
                }
                else if (entry >= 100)
                {
                    result += "C";
                    entry -= 100;
                }
                else if (entry >= 90)
                {
                    result += "XC";
                    entry -= 90;
                }
                else if (entry >= 50)
                {
                    result += "L";
                    entry -= 50;
                }
                else if (entry >= 40)
                {
                    result += "XL";
                    entry -= 40;
                }
                else if (entry >= 10)
                {
                    result += "X";
                    entry -= 10;
                }
                else if (entry == 9)
                {
                    result += "IX";
                    entry -= 9;
                }
                else if ((entry <= 8) && (entry >= 5))
                {
                    result += "V";
                    entry -= 5;
                }
                else if (entry == 4)
                {
                    result += "IV";
                    entry -= 4;
                }
                else if (entry > 0)
                {
                    result += "I";
                    entry -= 1;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            string response = "";
            string result = "";
            int entry = 0;

            entry = GetInt("Enter a  Number:");
            result = MakeRoman(entry);   
            Console.WriteLine(result);
            Console.ReadLine();

            }
        }
    }

