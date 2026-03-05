using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Adv_Ass_1
{
    class Helper
    {
        public static void BubbleSort<T>( T[] Arr) where T:IComparable
        {
            bool swapped;
            if (Arr.Length > 0)
            {
                swapped = false;
                for (int i=0 ; i < Arr.Length; i++)
                {
                    for (int j =0; j < Arr.Length - 1-i; j++) 
                    {
                        if (Arr[j].CompareTo(Arr[j + 1])>0)
                        {
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                            swapped = true;
                        }
                    }
                    if (!swapped) break;
                }
                Printarray(Arr);
            }
        }
        public static void SWAP <T>(ref T x,ref T y) 
        {
            T temp = x;
            x = y;
            y = temp;
        }
        public static void Printarray<T>(T[] Arr)
        {
            foreach(T p in Arr)
            {
                Console.Write(p+" ");
            }
        }
    }
}
