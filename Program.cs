/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Methods
{
    class Program
    {
        // From C# 7, you can define a method inside a method:
        void WriteCubes()
        {
            Console.WriteLine(Cube(3));
            Console.WriteLine(Cube(4));
            Console.WriteLine(Cube(5));
            int Cube(int value) => value * value * value;
        }
        /* The local method (Cube, in this case) is visible only to the enclosing method 
         (WriteCubes). This simplifies the containing type and instantly signals to anyone
         looking at the code that Cube is used nowhere else. Another benefit of local 
         methods is that they can access the local variables and parameters of the 
         enclosing method. This has a number of consequences (CH.4) */

        /* Local methods can appear inside other function kinds, such as property 
         accessors, constructors, and so on. You can even put local methods inside other
         local methods, and inside lambda expressions that use a statement block (CH.4).
         Local methods can be iterators (CH.4) or asynchronous (CH.14) */

         /* The static modifier is invalid for local methods. They are implicitly static
          if the enclosing method is static. */
        static void Main()
        {

        }
    }
}
