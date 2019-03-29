/*
1.A partial class or a struct can cantain partial methods

2.A patial method is created using the partial keywords

3.A partial method declaration consists of two parts.
1) The definition (only the menthod signature)
2)The implementation
These may be in separate parts of a partial class, or in the same part

4.The implementation for a partial method is optional.If we don't provide 
the implementation, the compiler removes the signature and all calls to the method

5.Partial methods are private by default,and it is a complie time error to 
include any access modifiers,including private

6.It is a compile error, to include declaration and implementation at the 
same time for a partial method

7.A partial method return type must be void.Including any other return type
is a compile time error.

8.Signature of the partial method declaration, must match with the signature
of the implementation

9.A partial method must be declared with a partial class or partial struct.A
non partial class or struct cannot include partial methods.

10.A partial method can be implemented only once.
*/

//=======================Program.cs=================================================
using part1_ConsoleApp1;

namespace Program
{
    public class MainClass
    {
        private static void Main()
        {
            PartialCustomer PC = new PartialCustomer();
            PC.PublicMethod();
            //PublicMethod Invoked
            //SampleParialMethod Invoked
        }
    }
}
//========================PartialCustomerOne.cs=================================================
using System;

namespace part1_ConsoleApp1
{
    public partial class PartialCustomer
    {
        partial void SampleParialMethod();

        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod Invoked");
            SampleParialMethod();//ignore
        }
    }
}
//========================PartialCustomerTwo.cs=================================================
using System;

namespace part1_ConsoleApp1
{
    public partial class PartialCustomer
    {
        partial void SampleParialMethod()
        {
            Console.WriteLine("SampleParialMethod Invoked");
        }       
    }
}
