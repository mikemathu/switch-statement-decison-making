namespace SwitchStatement
{
    class Switchstatement
    {
        static void Main(string[] args)
        {
            //SWITCH GRADING SYSTEM
            //Console.WriteLine("Enter your score");
            //string score = Console.ReadLine();
            //int grade = Convert.ToInt32(score);

            //switch (grade)
            //{
            //   case >= 80:
            //Console.WriteLine("Your grade is A");
            //break;
            //case >= 60:
            //Console.WriteLine("Your grade is B");
            //break ;
            //case >= 50:
            //Console.WriteLine("Your grade is C");
            //break;
            //default:
            //Console.WriteLine("You failed!");
            //break;
            //}

            //CALCULATOR
            Console.WriteLine("Enter the first number");
            string firstInput = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstInput);

            Console.WriteLine("Enter the second number");
            string secondInput = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondInput);


            Console.WriteLine("Enter the computation sign");
            string computationSign = Console.ReadLine();

            int answer = firstNumber + secondNumber;

            //Console.WriteLine("Your answer is "+ answer);
            Console.WriteLine("Your answer is {0}", answer);

        }
    }
}