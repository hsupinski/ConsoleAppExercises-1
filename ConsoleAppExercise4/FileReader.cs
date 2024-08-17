namespace ConsoleAppExercise4
{
    internal class FileReader
    {
        public int ReadFileAndReturnInput()
        {
            string filePath = null;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            while (filePath == null || !File.Exists(filePath))
            {
                Console.WriteLine("Enter file name: ");

                filePath = Console.ReadLine();
                filePath = Path.Combine(projectDirectory, filePath);

                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File does not exist");
                    return -1;
                }
            }

            string[] lines = File.ReadAllLines(filePath);

            if (int.TryParse(lines[0], out int number) == false)
            {
                return -1;
            }

            return number;
        }
    }
    
}
