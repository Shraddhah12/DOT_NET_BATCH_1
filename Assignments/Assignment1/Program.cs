using System;
using DataType;
class MainClass
{
    public static void Main(String[] args)
    {
    _INT  a= new _INT(10);
    _INT b= new _INT(20);
    Console.WriteLine(a.addition(a,b));
    Console.WriteLine(b.substraction(a,b));

      _FLOAT c = new _FLOAT(10);
      _FLOAT d = new _FLOAT(20);

    Console.WriteLine(c.addition(c,d));
    Console.WriteLine(d.substraction(c,d));
    }
    
}
