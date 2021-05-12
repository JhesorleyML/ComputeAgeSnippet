using System;

namespace ComputeAgeSnippet
{
    class Program
    {
        static void Main(string[] args)
        {
            //lets declare some variable
            int age = 0;

            //get the current date and display to console
            DateTime today = DateTime.Now;
            Console.WriteLine("Today: {0}", today.ToShortDateString());

            //lets ask the user his/her birthdate
            Console.WriteLine("Date of Birth (mm/dd/yyyy): ");
            string birthDateString = Console.ReadLine();

            //make sure its a valid date
            try
            {
                //lets convert to DateTime
                DateTime dob = DateTime.Parse(birthDateString);

                //compute for age
                age = today.Year - dob.Year;

                //consider some cases like birth month and day
                if ((today.Month < dob.Month) || (today.Month == dob.Month && today.Day < dob.Day))
                {
                    age--;
                }
                Console.WriteLine("Your age: {0}",age);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Birthdate");
            }
            Console.ReadKey();
        }
    }
}
