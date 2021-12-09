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

            int count = 0;
            int mode = 0;
            int mode_count = 0;
            /*Hashtable my_hashtable1 = new Hashtable();*/
            
           /* foreach (int num in array)
            {
                my_hashtable1.Add(num, count);
                count++;
            }*/

            foreach (int num in array)
            {
                count++;
                    
                if(num != mode)
                {
                    if(mode_count < count)
                    {
                        mode = num;
                        mode_count = count;
                        count = 0;

                    }
                }
            }
            return mode;










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
