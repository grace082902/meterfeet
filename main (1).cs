/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
        double feet, meter;
        Console.Write("Enter the value for feet: ");
        feet = Convert.ToDouble(Console.ReadLine());

        meter = feet * 0.305;
        Console.Write(feet + " feet is " + meter + " meters");
  }
}