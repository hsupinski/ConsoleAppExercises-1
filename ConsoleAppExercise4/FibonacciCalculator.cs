namespace ConsoleAppExercise4
{
    internal class FibonacciCalculator
    {
        int x = 0;
        int y = 1;

        public int CalculateFibonacciByIndex(int number)
        {
            if(number < 0)
            {
                return -1;
            }

            if (number == 0)
            {
                return 0;
            }

            if (number == 1)
            {
                return 1;
            }

            for (int i = 2; i <= number; i++)
            {
                x = x + y;

                if (x > y) //swap
                {
                    int temp = x;
                    x = y;
                    y = temp;
                }     
            }

            return y;
        }
    }
}
