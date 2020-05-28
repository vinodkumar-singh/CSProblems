using CSProblems.Model;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSProblems.Heap
{
    public static class HeapProblem
    {
        public static void Run()
        {
            MaxHeap heap = new MaxHeap(5);
            heap.Insert(1,0);
            heap.Insert(2, 0);
            heap.Insert(3, 0);
            heap.Insert(4, 0);
            heap.Insert(5, 0);
            heap.Print();
        }
    }

    public class MaxHeap
    {
        HeapNode[] maxHeap;
        int position;

        public MaxHeap(int size)
        {
            maxHeap = new HeapNode[size];
            position = -1;
        }

        public void Insert(int data, int listNumber)
        {
            if (position < 0 )
            {
                maxHeap[++position] = new HeapNode(data, listNumber);
            }
            else
            {
                maxHeap[++position] = new HeapNode(data, listNumber);
                ChangeToMaxHeapWhileInserting();
            }
        }

        public void ChangeToMaxHeapWhileInserting()
        {
            int pos = position;
            int parent = (pos - 1) / 2;
            while(pos > 0 && maxHeap[parent].Data < maxHeap[pos].Data)
            {
                HeapNode temp = maxHeap[parent];
                maxHeap[parent] = maxHeap[pos];
                maxHeap[pos] = temp;
                pos = parent;
                parent = (pos - 1) / 2;
            }
        }

        public void MaxHeapify()
        {
            int pos = position;
            while (pos <= position && pos >= 0)
            {
                if (((2 * pos + 1) <= position || ((2 * pos) + 2) <= position))
                {
                    if (maxHeap[pos].Data < maxHeap[2 * pos + 2].Data && (2 * pos + 2) <= position)
                    {
                        var temp = maxHeap[pos];
                        maxHeap[pos] = maxHeap[2 * pos + 1];
                        maxHeap[2 * pos + 2] = temp;
                    }

                    if (maxHeap[pos].Data < maxHeap[2 * pos + 1].Data && (2 * pos + 1) <= position)
                    {
                        var temp = maxHeap[pos];
                        maxHeap[pos] = maxHeap[2 * pos + 1];
                        maxHeap[2 * pos + 1] = temp;
                    }
                }
                pos--;
            }  
        }

        public void Max_Heapify(HeapNode[] maxHeap, int pos)
        {
            int l = 2 * pos;
            int r = 2 * pos + 1;
            int largest;
            if (l <= position && maxHeap[l].Data > maxHeap[pos].Data)
                largest = l;
            else
                largest = pos;

            if (r <= position && maxHeap[r].Data > maxHeap[largest].Data)
                largest = r;
            
            if(largest != pos)
            {
                var temp = maxHeap[pos];
                maxHeap[pos] = maxHeap[largest];
                maxHeap[largest] = temp;
            }
            Max_Heapify(maxHeap, largest);
        }

        public void Print()
        {
            for (int i = 0; i <= this.position; i++)
            {
                Console.Write("[{0}] ", this.maxHeap[i].Data);
            }
            Console.WriteLine();
        }
    }
}
