using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    public static class InsertionSort
    {
        // простая сортировка вставками
        //  array - массив, который нужно сортировать
        static public uint Sort(int[] array)
        {
            uint count = 0;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0 && array[j] < array[j - 1]; j--)
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    count++;
                }
            }
            return count;
        }
    }
}
