
using System;

class EntryPoint
{
    static void Main()
    {
        // int type holds 32 bits numbers
        int someInteger = 5;
        Console.WriteLine(someInteger);
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        uint someUinteger = 1; // unsigned int
        Console.WriteLine(uint.MinValue);
        Console.WriteLine(uint.MaxValue);

        // byte type holds 8bit number

        byte someByte = 200;

        sbyte negativeByte = -1; // signed byte -128 to 127

        Console.WriteLine(byte.MinValue);
        Console.WriteLine(byte.MaxValue);
        Console.WriteLine(sbyte.MinValue);
        Console.WriteLine(sbyte.MaxValue);

        long someverylongnumber = 15364646132156;
        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);


    }
}

