namespace INSERTION_SORT_ALGORITHM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A ARRAY SIZE:");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[n];
            for(int i=0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<n;i++)
            {
                for(int j = n; j >= 1; j--)
                {
                    if(arr[j - 1] > arr[j])
                    {
                        int temp = arr[j-1];
                        arr[j-1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for(int i=0;i<n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
