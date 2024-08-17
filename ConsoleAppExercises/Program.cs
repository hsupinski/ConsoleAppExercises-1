// 1.Write a program, that accepts distance in kilometers, converts it into meters and then
// displays the result in the console. Result should be also writed into text File.

Console.WriteLine("Enter distance in kilometers: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int value) == false)
{
    Console.WriteLine("Invalid input");
    return;
}

else
{
    int result = value * 1000;
    Console.WriteLine(result);

    Console.WriteLine("\nEnter file name (with extension): ");
    string fileName = Console.ReadLine();

    string workingDirectory = Environment.CurrentDirectory;
    string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
    string filePath = Path.Combine(projectDirectory, fileName);

    if (File.Exists(filePath))
    {
        Console.WriteLine("File already exists");
        return;
    }

    else
    {
        using (StreamWriter sw = File.CreateText(filePath))
        {
            sw.WriteLine(result);
        }
    }
}