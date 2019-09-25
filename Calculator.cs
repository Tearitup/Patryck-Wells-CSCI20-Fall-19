using System;

class MainClass {
  public static void Main (string[] args) {
    int num1, num2;
    string operand;
    ConsoleKeyInfo status;
    float answer;

    while (true)
    {
      Console.Write("Please enter the first number: ");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter the second number: ");
      num2 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Please enter an operand (+, -, /, *): ");
      operand = Console.ReadLine();

      if (operand == "-")
      {
        answer = num1 - num2;
      }
      else if (operand == "+")
      {
        answer = num1 + num2;
      }
      else if (operand == "/")
      {
        answer = num1 / num2;
      }
      else if (operand == "*")
      {
        answer = num1 * num2;
      }
      else
      {
        answer = 0;
        Console.WriteLine("Please use a valid operand.");
      }

      Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());

      Console.WriteLine("\n\n Do you want to start over?(Y):");
      status = Console.ReadKey();
      if(status.Key==ConsoleKey.Y)
      {
        break;
      }
      Console.Clear();
    }
  }
}
