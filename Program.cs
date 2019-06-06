using System;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    string workingfolder = "/home/adrien/";
    StreamReader sr = new StreamReader(workingfolder + "input.txt");
    StreamWriter sw = new StreamWriter(workingfolder + "output.txt");
    string line = string.Empty;

    while ((line = sr.ReadLine()) != null)
    {
      sw.WriteLine(line);
    }
    sr.Close();
    sw.Close();
    Console.WriteLine("Hello World!");
  }
}

