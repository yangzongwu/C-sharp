using System;

namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            int i = 10;
            int j = 10;
            Console.WriteLine(i == j);//True
            Console.WriteLine(i.Equals(j));//True

            Direction direction1 = Direction.East;
            Direction direction2 = Direction.West;
            Console.WriteLine(direction1 == direction2);//False
            Console.WriteLine(direction1.Equals(direction2));//False


            Customer C1 = new Customer();
            C1.FirstName = "mike";
            C1.LastName = "john";
            Customer C2 = C1;
            Console.WriteLine(C1 == C2);//True
            Console.WriteLine(C1.Equals(C2));//True


            //before overwrite
            Customer C3 = new Customer();
            C3.FirstName = "mike";
            C3.LastName = "john";
            Console.WriteLine(C1 == C3);//False
            Console.WriteLine(C1.Equals(C3));//False

            //after overwrite
            Customer C4 = new Customer();
            C4.FirstName = "mike";
            C4.LastName = "john";
            Console.WriteLine(C1 == C4);//False
            Console.WriteLine(C1.Equals(C4));//True
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Customer))
            {
                return false;
            }
            return this.FirstName == ((Customer)obj).FirstName &&
                this.LastName == ((Customer)obj).LastName;
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

    }

    public enum Direction
    {
        East=1,
        West=2,
        North=3,
        South=4
    }
}

