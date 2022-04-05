namespace SwitchStatement
{
    class Switchstatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score");
            string score = Console.ReadLine();
            int grade = Convert.ToInt32(score);

            switch (grade)
            {
                case >= 80:
                    Console.WriteLine("Your grade is A");
                    break;
                case >= 60:
                    Console.WriteLine("Your grade is B");
                    break ;
                case >= 50:
                    Console.WriteLine("Your grade is C");
                    break;
                default:
                    Console.WriteLine("You failed!");
                    break;
            }



        }
    }
}