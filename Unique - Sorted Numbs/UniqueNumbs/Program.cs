namespace UniqueNumbs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = new int[10];

            GetUnique(numbs);
        }
        static void GetUnique(int[] array)
        {
            bool isunique;

            for(int i = 0; i < array.Length; i++)
            {
                do
                {
                    array[i] = Random.Shared.Next(11);
                    isunique = true;

                    for (int j = 0; j < i; j++)
                    {
                        if (array[i] == array[j])
                        {
                            isunique = false;
                            break;
                        }
                    }
                } while (isunique == false);
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"numbs[{i}]= {array[i]}");
            }
        }
    }
}
