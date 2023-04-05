namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 7, 9, 16, 21 };
            InsertArray(ref num1, 38, 39);
            for (int i = 0; i < num1.Length; i++)
            {
                Console.WriteLine(num1[i]);

            }








        }
        public static void InsertArray( ref int[] arr ,  params int[] number )
        {
            int[] num2 = new int[arr.Length+ number.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                num2[i] = arr[i];
            }

            arr = num2;






        }



    }
}