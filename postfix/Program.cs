
using System.Text.RegularExpressions;
class jeki
{
    static void Main()
    {
        //string input = "127 +(16 * 128)/72^16";
        //  string input = "10 ^ 4 /(5*2) + 2";
        string input  = "2 + 3 * 4";

        GetPostfix(input);
    }


    static void PostfixEvaluate(string postfix)
    {
       
    }
  
    // @"\D+" => for get operand,   @"\d+" => for get operator, @"" => for get every character

    static void GetPostfix(string input)
    {
        string patternForOperators = @"";
        string[] operatorsArray = Regex.Split(input, patternForOperators);

        string word = "";

        for (int i = 0; i < operatorsArray.Length; i++)
        {
            word += operatorsArray[i];
        }
        word += " ";

        string infixView = "";
        for (int i = 0; i < word.Length; i++)
        {
            infixView += word[i];
            if (IsNumber(word[i]))
            {
                if (IsOperator(word[i + 1]))
                {
                    infixView += " ";
                }
            }
            else if (IsOperator(word[i]))
            {
                infixView += " ";
            }
        }

        /////until here we have the infix view of the expression

        var list = infixView.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

        Stack<string> stack = new Stack<string>();
        stack.Push("#");
        Queue<string> queue = new Queue<string>();


        for (int i = 0; i < list.Count; i++)
        {
            if (!IsOperator(list[i]))
            {
                queue.Enqueue(list[i]);
            }
            else if (list[i] == "(")
            {
                stack.Push(list[i]);
            }
            else if (list[i] == "^")
            {
                stack.Push(list[i]);
            }
            else if (list[i] == ")")
            {
                while (stack.Peek() != "#" && stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());

                }
                stack.Pop();
            }
            else
            {
                if (preced(list[i]) > preced(stack.Peek()))
                {
                    stack.Push(list[i]);
                }
                else
                {
                    while (stack.Peek() != "#" && preced(list[i]) <= preced(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                    stack.Push(list[i]);
                }
            }
        }


        while (stack.Peek() != "#")
        {
            queue.Enqueue(stack.Pop());
        }

        foreach (var item in queue)
        {
            Console.Write(item + " ");
        }

    }


    static int preced(string ch)
    {
        if (ch == "+" || ch == "-")
        {
            return 1;              //Precedence of + or - is 1
        }
        else if (ch == "*" || ch == "/")
        {
            return 2;            //Precedence of * or / is 2
        }
        else if (ch == "^")
        {
            return 3;            //Precedence of ^ is 3
        }
        else
        {
            return 0;
        }
    }

    static bool IsNumber(char input) => input switch
    {
        '0' => true,
        '1' => true,
        '2' => true,
        '3' => true,
        '4' => true,
        '5' => true,
        '6' => true,
        '7' => true,
        '8' => true,
        '9' => true,
        _ => false
    };

    static bool IsOperator(char input) => input switch
    {
        '+' => true,
        '-' => true,
        '*' => true,
        '/' => true,
        '(' => true,
        ')' => true,
        '^' => true,
        '%' => true,
        _ => false
    };
    static bool IsOperator(string input) => input switch
    {
        "+" => true,
        "-" => true,
        "*" => true,
        "/" => true,
        "(" => true,
        ")" => true,
        "^" => true,
        "%" => true,
        _ => false
    };
}