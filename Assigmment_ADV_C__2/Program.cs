namespace Assigmment_ADV_C__2
{
    internal class Program
    {
        #region q1
       /**/ class CountGreater
        {
            public static void Run()
            {
                string[] firstLine = Console.ReadLine().Split();
                int n = int.Parse(firstLine[0]);
                int q = int.Parse(firstLine[1]);

                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                for (int i = 0; i < q; i++)
                {
                    int x = int.Parse(Console.ReadLine());
                    int count = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (arr[j] > x)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(count);
                }
            }
        }
        #endregion

    }
}
