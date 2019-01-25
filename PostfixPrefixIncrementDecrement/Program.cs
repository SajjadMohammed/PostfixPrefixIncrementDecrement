using System;

namespace PostfixPrefixIncrementDecrement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var x = 1;
            var y = 1;

            //Console.WriteLine(x++); // postfix inside: will print 1 then increment x by 1
            //Console.WriteLine(++y); // prefix inside: increment y by 1 and will print 2


            // var result = x++ + ++y + x;
            // Console.WriteLine(result); // will print 5

            var result = x++ + ++y + x++;
            Console.WriteLine(result); // also will print 5
            // print x value
            Console.WriteLine(x); // will print 3

            Console.ReadLine();
        }
    }
}