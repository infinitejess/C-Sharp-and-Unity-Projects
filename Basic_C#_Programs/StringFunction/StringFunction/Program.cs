using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said \\Hello\", Jesse. \n Hello on a new line \n \t Hello on a tab line";
            //string fileName = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //StringBuilder sb = new StringBuilder();
            //sb.Append("My name is Jesse");

            string fname = "Jess " + "Fellows " + "rules!";
            fname = fname.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append("To be or not to be");
            sb.AppendLine("\nThat is the question");
            sb.AppendLine("Whether it be nobler in the mind");
            sb.AppendLine("To suffer the slings and arrows");


            Console.WriteLine(sb);
            Console.ReadLine();



        }
    }
}
