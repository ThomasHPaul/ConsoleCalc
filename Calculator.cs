using System.Collections.Generic;

namespace ConsoleCalc
{
    public class Calculator
    {
                public static void CalculateCycle()
        {
            Calculator calc = new Calculator();
            string userStmt = calc.GetInput();
            List<char> splitInput = calc.SplitInput(userStmt);
            int num1 = calc.ConvertNum(splitInput[0]);
            int num2 = calc.ConvertNum(splitInput[2]);
            var result = calc.Calculate(num1, num2, splitInput[1]);
            Console.WriteLine(result);
        }

        private int Calculate(int num1, int num2, char opToPerform)
        {
            return opToPerform switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' => num1 / num2,
                '%' => num1 % num2,
                _ => num1 + num2
            };
        }

        private int ConvertNum(char num)
        {
            int convertedNum;
            if (int.TryParse(num.ToString(), out convertedNum))
            {
                return convertedNum;
            }
            else
            {
                throw new System.Exception("not yet handled intelligently");
            }
        }

        private string GetInput()
        {
            Console.WriteLine($"Please type the expression to evaluate:");
            string result = Console.ReadLine();
            if (result is null)
            {
                result = "";
            }
            return result;
        }

        private List<char> SplitInput(string input)
        {
            List<char> splitInput = new List<char>();
            foreach (char character in input)
            {
                splitInput.Add(character);
            }

            return splitInput;
        }
    }
}