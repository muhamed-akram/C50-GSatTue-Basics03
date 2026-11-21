using System.Drawing;
using System.Security.Cryptography;
using System.Text;
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
            #region Question3
            //Create a StringBuilder, Append() the text "Book List", \
            //then Append() " - Updated" onto the same 
            //object.Print the final result.
            StringBuilder s = new StringBuilder();
            s.Append("Book List");
            s.Append(" - Updated");
            Console.WriteLine(s);
            #endregion
            #region Question 4
            //Using the StringBuilder from the question above,
            //use Replace() to change "Book List" into "Library". 
            //Print the result.
            s.Replace("Book List", "Library");
            Console.WriteLine(s);
            #endregion
            #region Question 5
            //Given string title = "Clean Code"; and int pages = 464;,
            //build the sentence "Book: Clean Code, 
            //Pages: 464" using the + operator.
            String Title = "Clean Code";
            int pages = 464;

            String sentence = "Book: " + Title + ",\nPages: " + pages;
            Console.WriteLine(sentence);
            #endregion
            #region Question 6
            //Build the same sentence as above, but using string interpolation ($"...").
            String Title2 = "Clean Code";
            int page = 464;
            string sentence1 = $"Book: {Title2},\n pages: {page}";
            Console.WriteLine(sentence1);
            #endregion
            #region Question 7
            //Build the same sentence again, but using string.Format().
            string Title3 = "Clean Code";
            int page3 = 464;
            string sentence3 = string.Format("Book: {0},\n Page: {1}", Title3 , page3);
            Console.WriteLine(sentence3);

            #endregion
            #region Question 8
            //Given int pages = 464;, write an if / else statement that prints "Long Book"
            //if pages is greater than 
            //300, otherwise prints "Short Book".
            int page4 = 464;
            if (page4 > 300)
                Console.WriteLine("Long Book");
            else Console.WriteLine("Short Book");
            #endregion
            #region Question 9
            //Given int pages = 464; and bool isAvailable = true;,
            //print "You can borrow this book" only if pages is 
            //greater than 300 and isAvailable is true.Use the && operator.
            int Pages5 = 464;
            bool isAvilable = true;
            if(Pages5 > 300 && isAvilable == true)
                Console.WriteLine("You can borrow this book");

            #endregion

        }
    }
}
