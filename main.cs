using System;

class MainClass {
  public static void Main (string[] args) {

  Console.WriteLine("What will be the base?");
  int B = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("What will be the exponent?");
  int E = Convert.ToInt32(Console.ReadLine());

  int answer = IntegerPower(B,E);

  Console.WriteLine ("Answer: " + answer);}

 public static int IntegerPower(int B , int E)
 { 
  int answer = 1;

 for (int counter = 0; counter <= E-1; counter++) 
  
  answer *= B;
  return answer;
  
 }
}