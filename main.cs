using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {


    int[] Num = new int[10];
    int[] EvenNum = new int[10];
    int[] OddNum = new int [10];

    for(int i=0; i < 10; i++)
    {
    Console.WriteLine ("Insert a number");
    Num[i] = Convert.ToInt32(Console.ReadLine()); 

    
    if(Num[i] % 2 == 1 && Num[i] != 0) //number is odd 
    {
    OddNum[i] = Num[i];
    }
    
    else if(Num[i] % 2 == 0 && Num[i] != 0)
    {
    EvenNum[i] = Num[i];
    }
    
    else
    {
      Console.WriteLine("Not a valid number! Please try again.");
    }
    }

    Array.Reverse(OddNum);
    Console.WriteLine("Odd numbers in a descending order are:");
    foreach(int i in OddNum)
    {
      
      Console.WriteLine(i);
    }

    Array.Sort(EvenNum);
    Console.WriteLine("Even numbers in an ascending order are:");
    foreach(int i in EvenNum)
    {
      
      Console.WriteLine(i);
    }
    
    int OddSum = OddNum.Sum();
    int EvenSum = EvenNum.Sum();

    Console.WriteLine("Sum of odd numbers is " + OddSum);
    Console.WriteLine("Sum of even numbers is " + EvenSum);


  }
}