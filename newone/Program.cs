/*for 1st one
name:iphone 14
price:$340.5
category:smart phone
available:true
sold:5 */

using System;

class Test
{
  public static void Main(string[] args)
    {
        string prouduct,category;
        prouduct ="iphone 14";
        category ="smart phone";
        double pr= 340.4;
        bool avail = true;
        Console.Write("Name:");
        Console.WriteLine(prouduct);
        Console.WriteLine("price:",pr);
        Console.WriteLine("category:",category);
        Console.WriteLine("available:",avail);
        Console.WriteLine("sold:5");

    }
}

