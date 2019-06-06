using System;
using System.IO;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    string workingfolder = "/home/adrien/";
    StreamReader sr = new StreamReader(workingfolder + "input.txt");
    StreamWriter sw = new StreamWriter(workingfolder + "output.txt");
    string line = string.Empty;

    List<Customer> myCustomers = new List<Customer>();

    while ((line = sr.ReadLine()) != null)
    {
      string[] linevalues = line.Split(',');

      Customer myCust = new Customer();
      myCust.ID = linevalues[0];
      myCust.Name = linevalues[1];
      myCust.Gender = linevalues[2];

      myCustomers.Add(myCust);
    }
    sr.Close();
    sw.Close();
    Console.WriteLine("Hello World!");
  }
}


public class Customer
{
  public string ID;
  public string Name;
  public string Gender;
}
