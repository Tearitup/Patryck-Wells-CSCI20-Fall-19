using System;

class MainClass {
  public static void Main (string[] args) {
    int eo;

    Console.Write("Enter a number: ");
    eo = int.Parse(Console.ReadLine());
    if (eo % 2 == 0) 
    {
      Console.Write("The number you entered is even");
      Console.Read();
    }
    else 
    {
      Console.Write("The number you entered is odd");
      Console.Read();
    }
  
  }
}
