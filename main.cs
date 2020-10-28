using System;

class MainClass {
  public static void Main (string[] args) {
    Cat snowbell = new Cat("snowbell",  1111, 3);
    Cat unknown = new Cat(); //constructer w no params
    snowbell.Intro();
  }
}