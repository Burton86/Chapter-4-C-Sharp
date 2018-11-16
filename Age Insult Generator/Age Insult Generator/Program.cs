using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Age_Insult_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ageString;
            string yesString;
            int yes;
            
            
            Write("Welcome to the famous Age Insult Generator");
            Write("Please enter your supposed age?");
            ageString = ReadLine();
            age = Convert.ToInt32(ageString);

            if (age < 18)
            {
                Write("You are a minor, hahahaha. And you cannot vote");
            }
            else if (age >= 18 && age < 25)
            {
                Write("You should be in college or done with college by now. Do not be a dead beat");
            }
            else if (age >= 25 && age < 32)
            {
                Write("Do you have a job? 1 for yes 2 for no");
                yesString = ReadLine();
                yes = Convert.ToInt32(yesString);
                if (yes == 1)
                    Write("Good for you");
                else
                    Write("Get a job hippie");
            }
            else if (age >= 32 && age < 42)
            {
                Write("HaHaHaHa. Youre getting old");
            }
            else if (age >= 42 && age < 52)
            {
                Write("Youre getting really old now");
            }
            else if (age >= 52 && age < 62)
            {
                Write("Youre ancient now, HaHaHa");
            }
            else  if (age > 62)
            {
                Write("Omg youre still alive!!! Hurry up and Die!");
            }
        }

    }
}
