using System;

namespace Expected_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            string tryAgain = "y";
            while (tryAgain == "y")
            {
                string val;
                int res;

                // User will enter their expected grade.

                Console.WriteLine("Enter your expected grade:");
                val = Console.ReadLine();

                // Convert to integer

                res = Convert.ToInt32(val);

                // Display the line

                Console.WriteLine("input = {0}", letterGrade(res));

                //Users can determine if they want to input another grade.
                Console.WriteLine("Would you like to enter another grade? Type 'y' for yes or 'n' for no.");
                tryAgain = Console.ReadLine();
            }
           
            
        }
        
        //Method that returns grade based on expected grade.
        public static String letterGrade(double res)
            {
            if (res > 100)
                return "N/A";
            if (res < 0)
                return "N/A";
            if (res > 93)
                return "A";
            else if (res > 83 && res <= 86)
                return "B";
            else if (res > 73 && res <= 76)
                return "C";
            else if (res > 63 && res <= 66)
                return "D";
            else
                return "F";
            

          
        }
    }
}
