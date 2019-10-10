using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {

    string charsInFile = File.ReadAllText("individualletters.txt");
    int count = charsInFile.Length;
    StreamReader reader = new StreamReader("individualletters.txt");
    string line = reader.ReadLine();

    Console.WriteLine("There are " + count + " characters in this file");

  }
}
