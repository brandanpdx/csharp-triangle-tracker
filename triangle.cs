using System;
using System.Collections.Generic;

public class Triangle
{
  public int Side1;
  public int Side2;
  public int Side3;

  public Triangle(int side1, int side2, int side3)
  {
    Side1 = side1;
    Side2 = side2;
    Side3 = side3;
  }

  public void IsTriangle(int Side1, int Side2, int Side3)
  {

    if (Side1 + Side2 <= Side3 || Side2 + Side3 <= Side1 || Side3 + Side1 <= Side2)
    {
      Console.WriteLine("This is not a triangle!");
    }
    else if ((Side1 == Side2) && (Side2 == Side3) && (Side1 == Side3))
    {
      Console.WriteLine("This triangle is equilateral!");
    }
    else if ((Side1 == Side2 && Side1 != Side3 || Side1 == Side3 && Side1 != Side2 || Side2 == Side3 && Side2 != Side1))
    {
      Console.WriteLine("This triangle is isoceles!");
    }
    else if (Side1 != Side2 && Side1 != Side3 && Side2 != Side3)
    {
      Console.Write("This triangle is scalene!");
    }
    else 
    {
      Console.WriteLine("Nope");
    }
  }
}
public class TriChecker
{
    public static void Main()
  {
    Console.WriteLine("Please enter side 1!");
    string side1 = Console.ReadLine();
    int triangleside1 = int.Parse(side1);

    Console.WriteLine("Please enter side 2!");
    string side2 = Console.ReadLine();
    int triangleside2 = int.Parse(side2);

    Console.WriteLine("Please enter side 3!");
    string side3 = Console.ReadLine();
    int triangleside3 = int.Parse(side3);



    Triangle triangleChecker = new Triangle(triangleside1, triangleside2, triangleside3);
    triangleChecker.IsTriangle(triangleChecker.Side1, triangleChecker.Side2, triangleChecker.Side3);
  }

}

