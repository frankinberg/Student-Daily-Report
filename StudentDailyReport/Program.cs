using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine(yourName);

            Console.WriteLine("What course are you on?");
            string courseYourOn = Console.ReadLine();
            Console.WriteLine(courseYourOn);

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine(pageNum);

            Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\"");
            string needsHelp = Console.ReadLine();
            if(needsHelp == "true" || needsHelp == "false")
            {
                bool needHelp = Convert.ToBoolean(needsHelp);
                Console.WriteLine(needHelp);
            } else
            {
                Console.WriteLine("You did not put in \"true\" or \"false\"!");

            }
           
           

            Console.WriteLine("Were there any positive experiences you'd like to share? \nPlease give specifics.");
            string postiveExperiences = Console.ReadLine();
            Console.WriteLine(postiveExperiences);

            Console.WriteLine("Is there other feedback you'd like to provide? \nPlease be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine(feedback);

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int timeStudied = Convert.ToInt32(hoursStudied);
            Console.WriteLine(timeStudied);

            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");

            Console.ReadLine();
        }
    }
}
