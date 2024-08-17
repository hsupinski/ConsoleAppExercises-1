// 2 - FizzBuzz.Write out numbers from 1 to 100 in the console, with numbers divisible by 3 replaced by with the word “Fizz”, 
//    numbers divisible by 5, replace with “Buzz”, while numbers divisible by 3 and by 5, replace with “FizzBuzz.”

for(int i = 1; i <= 100; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(i + ": ");
    Console.ForegroundColor = ConsoleColor.White;

    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if(i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if(i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}
