namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            Console.WriteLine("The task was made by Vladimir Rybin");

            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");

                // Task 1. Read choice input and assing it to new int variable

                int choosenOperator = int.Parse(Console.ReadLine());

                // Task 2. Check if user selected choice 5. If so then exit the loop

                if (choosenOperator == 5)
                    break;

                Console.Write("Enter first number: ");
                // Task 3. Get the first number and assing it to new double variable

                double firstvariable = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                // Task 4. Get the second number and assing it to new double variable

                double secondvariable = double.Parse(Console.ReadLine());

                // Task 5. Create double variable for default result value and assign it to be 0

                double result = 0;

                // Task 6. Handle choices using switch statement
                // Task 6.1 For each case create new function/method an call it inside the case
                //          - Case 1: Add 
                //          - Case 2: Subtract
                //          - Case 3: Multiply
                //          - Case 4: Divide, Note remeber to handle 0
                // Note: Think what the default choice should be
                // Note: Declare each case function/method outside Main method
                //       There is comment below where you can place your methods

                switch (choosenOperator)
                {
                    
                    case 1:
                        result = AddMethod(firstvariable, secondvariable);
                        break;
                    case 2:
                        result = SubtractMethod(firstvariable, secondvariable);
                        break;
                    case 3:
                        result = MultiplyMethod(firstvariable, secondvariable);
                        break;
                    case 4:
                        result = DivideMethod(firstvariable, secondvariable);
                        break;

                    default:
                        Console.WriteLine("There is no such action!");
                        break;
                }

                // Task 7. Print out the result
                Console.WriteLine($"The result is {result}");
            }
        }

        // Declare your methods/functions here
        static double AddMethod(double a, double b)
        {
            return a+b;
        }

        static double SubtractMethod(double a, double b)
        {
            return a - b;
        }

        static double MultiplyMethod(double a, double b)
        {
            return a*b;
        }

        static double DivideMethod(double a, double b)
        {
            return a/b;
        }
    }
}