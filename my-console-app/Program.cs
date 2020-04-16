using System;

namespace my_console_app
{
    class Glazercalc
    {
      

        static void Main(string[] args)
        {
            double width;
            double woodlength;
            width = 5;
            double height = 4;
            double glassArea;
            woodlength = (width + height) * 2 * 3.25;
          
            glassArea = ( width * height )*2 ;

            string value = "The length of the wood is " + woodlength + " feet";
            Console.WriteLine(value);
            Console.WriteLine( "The area of the glass is " +
            glassArea + " square metres" ) ;
        }
    }
}
