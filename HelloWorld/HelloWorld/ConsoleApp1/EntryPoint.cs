using System;

class EntryPoint
{
    static void Main()
    {
        int count = 0;
        
        while (count < 10)
        {
            Console.WriteLine(count);
            count += 1;
        }

        string[] myArray = { "nick", "dom", "tiff" };

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}
