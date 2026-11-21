using System.Drawing;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace C__Basics_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //Declare string title = "clean code";. Call title.ToUpper()
            //and store it in a new variable upperTitle. Print 
            //both title and upperTitle to show that title did not change.
            string title = "clean code";
             title.ToUpper();
            string upperTitle = title;
            Console.WriteLine(title +"\n" + upperTitle);

            #endregion
            #region Question2
            //Declare two separate string variables,
            //both set to the literal "Clean Code". Use ReferenceEquals() 
            //to check if they point to the same object in memory.

            string s1 = "Clean Code";
            string s2 = "Clean Code";

            Console.WriteLine(ReferenceEquals(s1, s2)); 

            #endregion

        }
    }
}
