using System;

namespace part1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Program";
            Console.WriteLine(Name);
            string Name2 = "\"Program\"";
            Console.WriteLine(Name2);
            Console.WriteLine("one\ntwo\nthree");
            string s = "C:\\Users\\yzw\\Desktop\\C#";
            Console.WriteLine(s);
            //Verbatim Literal
            string s1 = @"C:\Users\yzw\Desktop\C#";
            Console.WriteLine(s1);

            //https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=vs-2017
            /*   
             Escape Sequence	Represents
                \a	            Bell (alert)
                \b	            Backspace
                \f	            Formfeed
                \n          	New line
                \r          	Carriage return
                \t          	Horizontal tab
                \v          	Vertical tab
                \'          	Single quotation mark
                \"          	Double quotation mark
                \\          	Backslash
                \?          	Literal question mark
                \ ooo       	ASCII character in octal notation
                \x hh       	ASCII character in hexadecimal notation
                \x hhhh	        Unicode character in hexadecimal notation if this escape sequence is used in a wide-character constant or a Unicode string literal.
             */



        }
    }
}
