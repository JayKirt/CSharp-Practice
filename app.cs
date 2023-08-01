using System; // allows classes from the system namespace
// can anything else instead of System be used?

namespace HelloWorld // used to declare a scope that contains related objects - this is a container
// how / when would we access this namespace later?      
{
    class Program // basically an object?
    {
        static void Main (string []args) // the Main method
        {
            string name = "James";
            console.WriteLine(name);
            int age = 34;
            console.WriteLine(age);
            console.WriteLine ("Hello World"); // write to console
        }
    }
    
}