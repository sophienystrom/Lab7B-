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
 for (int counter = 0; counter == E; counter++) {
  int answer = B * B; }
  return answer;
  }
}