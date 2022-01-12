// See https://aka.ms/new-console-template for more information

// Integer numeric values
Console.WriteLine("The byte type goes from " + byte.MinValue + " to " + byte.MaxValue); // 1 byte (8 bits)
Console.WriteLine("The sbyte type goes from " + sbyte.MinValue + " to " + sbyte.MaxValue); // 1 byte (8 bits)
Console.WriteLine("The short type goes from " + short.MinValue + " to " + short.MaxValue); // 2 bytes (16 bits)
Console.WriteLine("The ushort type goes from " + ushort.MinValue + " to " + ushort.MaxValue); // 2 bytes (16 bits)
Console.WriteLine("The int type goes from " + int.MinValue + " to " + int.MaxValue); // 4 bytes (32 bits)
Console.WriteLine("The uint type goes from " + uint.MinValue + " to " + uint.MaxValue); // 4 bytes (32 bits)
Console.WriteLine("The long type goes from " + long.MinValue + " to " + long.MaxValue); // 8 bytes (64 bits)
Console.WriteLine("The ulong type goes from " + ulong.MinValue + " to " + ulong.MaxValue); // 8 bytes (64 bits)
// Real numerical values
Console.WriteLine("The float type goes from " + float.MinValue + " to " + float.MaxValue); // up to 7 digits of precision, 4 bytes (16 bits)
Console.WriteLine("The double type goes from " + double.MinValue + " to " + double.MaxValue); // up to 15 digits of precision, 8 bytes (32 bits)
Console.WriteLine("The decimal type goes from " + decimal.MinValue+ " to " + decimal.MaxValue); // up to 28 digits of precision, 16 bytes (63 bits)
// Logical values
Console.WriteLine("The bool type accepts " + bool.FalseString + " or " + bool.TrueString); // 1 bit (True e False)

Console.ReadKey();

