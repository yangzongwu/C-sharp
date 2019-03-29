/*
索引器（Indexer） 允许一个对象可以像数组一样被索引。当您为类定义一个索引器时，该类的行为就会像一个 
虚拟数组（virtual array） 一样。您可以使用数组访问运算符（[ ]）来访问该类的实例。
*/

using System;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Session1"] = "Session 1 Data";
            Session["Session2"] = "Session 2 Data";

            Response.Write("Session 1 Data=" + Session[0].ToString());
            Response.Write("<br/>");
            Response.Write("Session 2 Data=" + Session["Session2"].ToString());
            //Session 1 Data=Session 1 Data
            //Session 2 Data = Session 2 Data
        }
    }
}

//================================================================================================
/*
ndexers allow instances of a class or struct to be indexed just like arrays. The indexed value can 
be set or retrieved without explicitly specifying a type or instance member. Indexers resemble 
properties except that their accessors take parameters.

The following example defines a generic class with simple get and set accessor methods to assign 
and retrieve values. The Program class creates an instance of this class for storing strings.
*/

using System;

class SampleCollection<T>
{
   // Declare an array to store the data elements.
   private T[] arr = new T[100];

   // Define the indexer to allow client code to use [] notation.
   public T this[int i]
   {
      get { return arr[i]; }
      set { arr[i] = value; }
   }
}

class Program
{
   static void Main()
   {
      var stringCollection = new SampleCollection<string>();
      stringCollection[0] = "Hello, World";
      Console.WriteLine(stringCollection[0]);
   }
}
// The example displays the following output:
//       Hello, World.
