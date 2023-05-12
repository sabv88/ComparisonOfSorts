

namespace kursa4
{
    public static class CreateArraysToSort
    {
        //полный рандом
        //length - длина массива, start - end - начало и конец диапазона для рандома, uniq - уникальность значений в массиве
        public static int[] AllRandom(int length, int start, int end)
        {
            int[] array = new int[length];
            var rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(start, end);
            }

            return array;
        }
        //массив разбит на 4 отсортированные части
        //length - длина массива, start - end - начало и конец диапазона для рандома

        public static int[] ParticalSorted(int length, int start, int end)
        {
            int[] array = new int[length];
            var rnd = new Random();
            for (int i = 0; i < length/ (length / 4); i++)
            {
                int rand = rnd.Next(start, end);
                Enumerable.Range(rand, length / 4).ToArray().CopyTo(array, i * (length / 4));
            }

            if (length % 2 > 0) /*если длинна массива нечетная*/
            {
                array[^1] = rnd.Next(start, end);
            }
            return array;
        }

        //отсортированный массив
        public static int[] Sorted(int length)
        {
            return Enumerable.Range(1, length).ToArray();
        }
        //отсортированный в обратном порядке массив
        public static int[] ReverseSorted(int length)
        {
            return Enumerable.Range(1, length).Reverse().ToArray();
        }
    }
}
