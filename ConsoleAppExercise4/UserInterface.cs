namespace ConsoleAppExercise4
{
    internal class UserInterface
    {
        int choice = 0;
        public int PrintMenuAndReturnIndex()
        {
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("1. Read from console");
                Console.WriteLine("2. Read from text file");

                if (int.TryParse(Console.ReadLine(), out choice) == false)
                {
                    Console.WriteLine("Invalid input");
                }

                else
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter a number: ");

                            if (int.TryParse(Console.ReadLine(), out int number) == false)
                            {
                                break;
                            }
                            
                            return number;

                        case 2:
                            FileReader fileReader = new FileReader();
                            return fileReader.ReadFileAndReturnInput();

                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
            }

            return -1;
        }
    }
}
