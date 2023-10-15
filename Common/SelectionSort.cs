using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Common
{
    public class SelectionSort : ISortingAlgorithm
    {
        

        public void Sort(int[] A)
        {
            //TODO #1: Implement SelectionSort

            int aux;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j <= A.Length - 1; j++)
                {
                    if (A[i] > A[j])
                    {
                        aux = A[i];
                        A[i] = A[j];
                        A[j] = aux;
                    }

                }

            }
        }

        public bool CheckIsCorrect()
        {
            int n = 10;
            int[] A = Utils.CreateIntArray(n);

            Console.WriteLine("1.1 Checking Sort()");
            Sort(A);
            if (!Utils.IsOrdered(A))
            {
                Console.WriteLine("FAILED");
                return false;
            }
            Console.WriteLine("PASSED");
            return true;
        }
    }
}
