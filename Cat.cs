using System;
class Cat
{
  private string name;
  private int id;
  private int age;
  
  public Cat()

  {
    id = 0;
    age = 0;
    name = "unknown";
    Console.WriteLine("A new cat object has been created");
  }

  public Cat(string catname, int catid, int catage)
  {
    name = catname;
    id = catid;
    age = catage;
  }

  public void Intro()
  {
    Console.WriteLine("My name is" + " " + name);
    
  }
}