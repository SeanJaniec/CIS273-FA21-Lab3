using System;
using System.Collections;

namespace MeanMode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool MeanMode(int[] array)
        {
            if (computeMode(array) == 0)
            {
                return false;
            }
            return computeMode(array) == computeAverage(array);
        }

        // TODO
        private static double computeAverage(int[] array)
        {
            int total = 0;
            foreach (int num in array)
            {
                total += num;
            }
            return total/array.Length;
        }

        // TODO
        private static double? computeMode(int[] array)
        {

            return null;

/*            Hashtable my_hashtable1 = new Hashtable();
            int count = 1;
            foreach (int num in array)
            {
                my_hashtable1.Add(num, count);
                count++;
            }

            foreach (var item in my_hashtable1)
            {
                if(my_hashtable1.ContainsKey())
            }*/










            /*int index = 0;
            int mode = array[index];
            
            int count = 1;*/

                /*foreach (int num in array)
                {
                    if(array[index] == array[index+1])
                    {
                        count++;

                    }
                    else
                    {
                        if(count == mode)
                        {
                            return 0;
                        }
                        else if(count > mode)
                        {
                            mode = array[index];
                        }
                    }
                    index++;
                }

                return mode;*/


                /*while(array[index] == array[index+1])
                {

                    count++;
                    index++;

                }*/
        }
    }
}
