using System;


namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
      
            Console.WriteLine("What is your name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Your name is: " + firstName);

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("The course is: " + courseName);

            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are on page: " + pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool needHelp = bool.Parse(Console.ReadLine());
            if (needHelp)
            {
                Console.WriteLine("Yes,I would like help.");
            }
            else
            {
                Console.WriteLine("No, I dont need help.");
            }

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Positive notes: " + positiveExp);

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("Feedback: " + feedback);

            Console.WriteLine("How many hours did you study today?");
            int hoursStudy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You studied: " + hoursStudy);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
