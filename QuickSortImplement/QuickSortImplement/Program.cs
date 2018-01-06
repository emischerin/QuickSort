using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortImplement
{
        class Program
        {

                static void Print(int [] a)
                {
                        foreach (int element in a)
                        {
                                Console.Write((element + ","));
                        }
                }

                static void Fullfill(int [] a)
                {
                        Random rnd = new Random();

                        for (int i = 0; i < a.Length;i++)
                        {
                                a[i] = rnd.Next(1000, 5000);
                        }
                }

                static void QuickSort(int [] a, int low, int high)
                {
                        if (high <= low) return;

                        int pivot = Partition(a, low, high);

                        QuickSort(a, low, pivot - 1);
                        QuickSort(a, pivot + 1, high);
                }

                static int Partition(int [] a, int low, int high)
                {
                        int pivot = low;

                        for (int i = low; i < high;i++)
                        {
                                if (a[i] <= a[high])
                                {
                                        int tmp = a[pivot];
                                        a[pivot] = a[i];
                                        a[i] = tmp;
                                        pivot++;
                                }
                        }

                        int temp = a[pivot];
                        a[pivot] = a[high];
                        a[high] = temp;

                        return pivot;
                }
                static void Main(string[] args)
                {
                        int[] array = new int[150_000];
                        Fullfill(array);
                        QuickSort(array, 0, array.Length - 1);
                        Console.WriteLine("*******************SORTED ARRAY****************");
                        Print(array);
                        Console.ReadKey();
                        
                }
        }
}
