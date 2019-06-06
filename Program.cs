using System;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    string workingfolder = "/home/adrien/";
    StreamReader sr = new StreamReader(workingfolder + "input.txt");

    string line = string.Empty;

    while ((line = sr.ReadLine()) != null)
    {
      string s = line;
    }

    Console.WriteLine("Hello World!");
  }
}

