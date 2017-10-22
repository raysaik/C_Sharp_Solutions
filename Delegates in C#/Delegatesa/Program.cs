using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Delegatesa
{
    public delegate void Print(string s);     //Delegate Declaration.Can be done outside or inside a class.A Sealed class with the name of 'PRINT' is formed
    public class deledemo
    {
        public void Del1(string str1)  //Method signature and delegate Signature must be same,otherwise Complie time error.
        {
            Console.WriteLine("Hello in method del1 and " + str1);
        }

        public void Del2(string str2)
        {
            Console.WriteLine("Hello in method del2 and " + str2);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            deledemo demo = new deledemo();
            Print newdel = new Print(demo.Del1);   //Method reference added to the Delegate
            newdel("Saikat");                      //Calls the In-Built Invoke() function of the delegate,which in turn calls the DEL1 method with the parameter. Asynchronous delegates
            newdel += new Print(demo.Del2);        //Becomes a multicast delegate
            newdel("AP");                          //Calls both Del1 & Del2
            newdel -= new Print(demo.Del1);
            newdel("UP"); 
        }
    }
}
