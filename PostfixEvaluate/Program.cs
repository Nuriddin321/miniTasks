
class Program
{

    public static void Main(string[] args)
    {
        string input = "100 200 + 2 / 5 * 7 +";
        PostfixEvaluate(input);

    }

    static void PostfixEvaluate(string input)
    {
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < input.Length; i++)
        {
            char characterOfInput = input[i];

            if (char.IsDigit(characterOfInput))
            {
                int number = 0;

                while (char.IsDigit(characterOfInput))
                {
                    number = number * 10 + (int)(characterOfInput - '0');
                    i++;
                    characterOfInput = input[i];
                }
                i--;
                stack.Push(number);
            }
            else if (characterOfInput == ' ')
            {
                continue;
            }
            else
            {
                int val1 = stack.Pop();
                int val2 = stack.Pop();

                switch (characterOfInput)
                {
                    case '+':
                        stack.Push(val2 + val1);
                        break;
                    case '-':
                        stack.Push(val2 - val1);
                        break;
                    case '*':
                        stack.Push(val2 * val1);
                        break;
                    case '/':
                        stack.Push(val2 / val1);
                        break;
                    case '^':
                        stack.Push((int)Math.Pow(val2, val1));
                        break;
                }
            }
        }
        Console.WriteLine(stack.Pop());
    }
}
