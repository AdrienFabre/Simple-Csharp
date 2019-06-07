using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
class Program
{
  static void Main(string[] args)
  {
    List<Customer> myCustomers = new List<Customer>();
    myCustomers = GetCustomersFromFile();

    List<Customer> women = new List<Customer>();
    women = myCustomers.Where(x => x.Gender == "F").ToList();

    List<Customer> men = new List<Customer>();
    men = myCustomers.Where(x => x.Gender == "M").ToList();

    StreamWriter sw = new StreamWriter("/home/adrien/men.txt");

    foreach (Customer mydude in men)
    {
      sw.WriteLine(mydude.ID + " " + mydude.Name + " " + mydude.Gender);
    }
    sw.Close();

    sw = new StreamWriter("/home/adrien/women.txt");

    foreach (Customer mylady in women)
    {
      sw.WriteLine(mylady.ID + " " + mylady.Name + " " + mylady.Gender);
    }
    sw.Close();

    Console.WriteLine("Hello World!");
  }

  static public List<Customer> GetCustomersFromFile()
  {
    List<Customer> myCustomers = new List<Customer>();

    string workingfolder = "/home/adrien/";
    StreamReader sr = new StreamReader(workingfolder + "input.txt");
    StreamWriter sw = new StreamWriter(workingfolder + "output.txt");
    string line = string.Empty;

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
    return myCustomers;

  }
}


public class Customer
{
  public string ID;
  public string Name;
  public string Gender;
}
