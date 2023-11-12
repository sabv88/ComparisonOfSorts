using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursa4
{
    internal class ShellSort
    {
        //  сортировка Шелла
        //  array - массив, который нужно сортировать

        static public uint Sort(int[] array)
        {
            int h = 1;
            uint count = 0;
            while (h <= array.Length / 3)
            {
                h = h * 3 + 1;
            }

            while (h > 0)
            {
                for (int outer = h; outer < array.Length; outer++)
                {
                    int tmp = array[outer];
                    int inner = outer;
                    while (inner > h - 1 && array[inner - h] > tmp)
                    {
                        array[inner] = array[inner - h];
                        inner -= h;
                        count++;
                    }

                    array[inner] = tmp;
                }

                h = (h - 1) / 3;
            }
            return count;
        }
    }
}
