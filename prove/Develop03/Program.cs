using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";

        Reference myReference = new Reference("John", 3, 16, 17);
        /*myRefernce.book = "John";
        myRefernce.chapter = 3;
        myRefernce.startVerse = 16;
        myRefernce.endVerse = 17;*/
        Console.WriteLine(myReference.GetDisplayText());

        Console.WriteLine("John 3: 16 - 17");
        string myString =   "16 For God so loved the world, that he gave his only begotten Son,\n" +
                            "that whosoever believeth in him should not perish, but have everlasting life.\n" +
                            "17 For God sent not his Son into the world to condemn the world; but that the world through\n" +
                            "him might be saved.";
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(myString);

        while (input != "quit")
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();
        }
        


    }
}