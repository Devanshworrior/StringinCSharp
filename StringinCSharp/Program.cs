using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringinCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. String Length
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The Length of Text : " + txt.Length);

            //2. Other Methods
            Console.WriteLine("Upper Case : " + txt.ToUpper());
            Console.WriteLine("Lower Case : " + txt.ToLower());

            //3. Concatenation String
            //Console.WriteLine("This is Alphabets : " +txt);
            string name = "Devansh Jangid.";
            Console.WriteLine(string.Concat("My Name is ",name ));

            //4. Interpolation
            string a = Console.ReadLine();
            string Candies = Console.ReadLine();
            Console.WriteLine($"Your Name is {a}. You Get {Candies} Candies.");

            //5. Access String
            string myString = "Hello World This is Harry";
            Console.WriteLine(myString[5]);
            Console.WriteLine(myString.IndexOf("is"));
            Console.WriteLine(myString.Substring(6));

            //6. Special Characters
            string t = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(t);
            string x = "It\'s alright.";
            Console.WriteLine(x);
            string p = "The character \\ is called backslash.";
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
