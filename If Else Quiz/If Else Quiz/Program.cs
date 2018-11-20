using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace If_Else_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            String numstring;
            int num;
            

            Write("Please pick a number, either 1,2,or 3");
            numstring = ReadLine();
            num = Convert.ToInt32(numstring);

            if (num == 1 || num == 3)
            {
                Write("You Lost, hahahahaha\n ");
            }
            else if (num == 2)
            {
                Write("You're a winner\n ");
            }
            else 
            {
                Write("Error\n");
            }










        }
    }
}
