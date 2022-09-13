namespace MergeArrays
{

    public class Program
    {
        

        public static void Main(string[] args)
        {

        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {


            int count1 = array1.Length;
            int count2 = array2.Length;
            int[] arrayResult = new int[count1 + count2];

            int one = 0, two = 0, three = 0;   

       
            while (one < count1 && two < count2)
            {
                if (array1[one] <= array2[two])
                {
                    arrayResult[three++] = array1[one++];
                }
                else
                {
                    arrayResult[three++] = array2[two++];
                }
            }
            if (one < count1)
            {
                
                for (int i = one; i < count1; i++)
                {
                    arrayResult[three++] = array1[i];
                }
            }
            else
            {
              
                for (int i = two; i < count2; i++)
                {
                    arrayResult[three++] = array2[i];
                }
            }



            return arrayResult;

         
        }
        

    }
    

}


