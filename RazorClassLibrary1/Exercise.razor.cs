namespace RazorClassLibrary1
{
    public partial class Exercise
    {

        private int fibbonaciNumber = 4000000;
        private int solution2;


        private void ExecuteExercise2()
        {
            solution2 = GetFibonacci(fibbonaciNumber);

        }

        private int GetFibonacci(int x)
        {
            int first = 1;
            int second = 2;
            int i = 2;
            int sumEvenTerms = 0;
            while (i < 4000000)
            {

                if (i % 2 == 0)
                {
                    sumEvenTerms += i;
                }

                i = first + second;

                first = second;
                second = i;
            }

            return sumEvenTerms;

        }

        private int recursiveMultiplers = 999;
        private int solution1;

        private void ExecuteExercise1()
        {
            solution1 = GetRecMultiplier(recursiveMultiplers) - 1;
        }

        private int GetRecMultiplier(int x)
        {
            if (x > 1)
            {
                int y = 0;
                if (x % 3 == 0 || x % 5 == 0)
                {
                    y = x;
                }

                int value = GetRecMultiplier(x - 1) + y;

                return value;


            }
            else
            {
                return 1;
            }


        }

    }
}
