using System;
using System.Runtime.InteropServices;

class Program
{
  static void Main(string[] args)
  {
    string name = Console.ReadLine();
    WelcomePerson(name);
    passbyvalueoutref();
  }

  static void WelcomePerson(string name)
  {
    Console.WriteLine("Welcome " + name);
  }

  #region SumofTwoNumbers

  private static int Add(int a, int b)
  {
    return a + b;
  }
  #endregion


  #region MethodOverloading
  private static string Add(string a, string b)
  {
    return a + b;
  }
  #endregion

  #region optionalparameters
  private static int Add(int a, int b, int c = 0)
  {
    return a + b + c;
  }
  #endregion

  #region params

  int res = AddanyNumbers(1, 23, 4, 55, 6);
  private static int AddanyNumbers(params int[] n)
  {

    int temp = 0;
    for (int i = 0; i < n.Length; i++)
    {
      temp += n[i];

    }
    return temp;
  }


  #endregion

  #region passbyvalueoutref

  static void passbyvalueoutref()
  {
    int i1 = 10, i2 = 10, i3 = 10;
    abc(i1, out i2, ref i3);
    Console.WriteLine(i1 + " " + i2 + " " + i3);
  }

  private static void abc(int a, out int b, ref int c)
  {
    a++;
    b = 10;
    c++;
  }

  #endregion
}

