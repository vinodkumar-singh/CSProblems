using System;
using System.Collections.Generic;
using System.Text;

namespace CSProblems.Model
{
    public class HeapNode
    {
        public int Data { get; set; }

        public int ListNumber { get; set; }

        public HeapNode(int data, int listNumber)
        {
            this.Data = data;
            this.ListNumber = listNumber;
        }
    }
}
