using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace MetodoBurbuja.models
{
    internal class Bubble
    {
        public void bubbleSort(int[] array)
        {
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; i++)
                    {
                        if (array[j] > array[1])
                        {
                            int temp = array[j];
                            array[j] = array[1];
                            array[1] = temp;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }
}   }
