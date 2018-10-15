using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SortingAlgorithms
{
    public partial class Form1 : Form
    {
        private const int ArrSize = 1000;
        private Array arr;
        private Array resetArr;
        private delegate void StatusStripChange(string text);
        private delegate void PrintOn();

        public Form1()
        {
            InitializeComponent();
            arr = new Array(ArrSize);
            resetArr = new Array(arr);
            PrintOnArr();
            ChangeStatusStrip("Start time: " + DateTime.Now.ToString("HH:MM"));
        }

        private void PrintOnArr()
        {
            //label1.Text = arr.ToString();
            textBox1.Text = arr.ToString();
        }
        private void ChangeStatusStrip(string text)
        {
            statusStrip1.Items.Clear();
            statusStrip1.Items.Add(text);
        }

        private void ResetArr()
        {
            arr = new Array(resetArr);
            PrintOnArr();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetArr();
        }

        private void BubbleSort(dynamic array)
        {
            arr = (Array)array;

            dynamic watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < arr.Count; ++i)
            {
                for (int j = 0; j < arr.Count - 1; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        arr.Swap(j, j + 1);
                    }
                }               
            }

            watch.Stop();
            long time = watch.ElapsedMilliseconds;

            StatusStripChange change = ChangeStatusStrip;
            statusStrip1.Invoke((Action) (() => change($"Bubble sorted. Time elapsed: { time.ToString()} ms")));

            PrintOn p = PrintOnArr;
            label1.Invoke(p);
        }
        private void Bubble_Click(object sender, EventArgs e)
        {
            dynamic param = arr;
            Thread t = new Thread(BubbleSort);
            t.Start(param);
        }

        private void InsertionSort(dynamic array)
        {
            arr = (Array)array;

            dynamic watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < arr.Count - 1; ++i)
            {
                for (int j = i + 1; j > 0; --j)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        arr.Swap(j - 1, j);
                    }
                }
            }

            watch.Stop();
            long time = watch.ElapsedMilliseconds;

            StatusStripChange change = ChangeStatusStrip;
            statusStrip1.Invoke((Action)(() => change($"Insertion sorted. Time elapsed: { time.ToString()} ms")));

            PrintOn p = PrintOnArr;
            label1.Invoke(p);
        }
        private void Insertion_Click(object sender, EventArgs e)
        {
            dynamic param = arr;
            Thread t = new Thread(InsertionSort);
            t.Start(param);
        }

        private void SelectionSort(dynamic array)
        {
            arr = (Array)array;

            dynamic watch = System.Diagnostics.Stopwatch.StartNew();

            int min;
            for (int i = 0; i < arr.Count - 1; ++i)
            {
                min = i;
                for (int j = i + 1; j < arr.Count; ++j)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                arr.Swap(i, min);
            }

            watch.Stop();
            long time = watch.ElapsedMilliseconds;

            StatusStripChange change = ChangeStatusStrip;
            statusStrip1.Invoke((Action)(() => change($"Selection sorted. Time elapsed: { time.ToString()} ms")));

            PrintOn p = PrintOnArr;
            label1.Invoke(p);
        }
        private void Selection_Click(object sender, EventArgs e)
        {
            dynamic param = arr;
            Thread t = new Thread(SelectionSort);
            t.Start(param);
        }

        private Array MergeSort(dynamic array)
        {
            Array arr = (Array)array;
            if (array.Count <= 1)
            {
                return arr;
            }

            Array left = new Array();
            Array right = new Array();

            int middle = arr.Count / 2;
            for (int i = 0; i < middle; ++i)
            {
                left.Add(arr[i]);
            }
            for (int i = middle; i < arr.Count; ++i)
            {
                right.Add(arr[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }
        private Array Merge(Array left, Array right)
        {
            Array result = new Array();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])
                    {
                        result.Add(left[0]);
                        left.Remove(left[0]);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.Remove(right[0]);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.Remove(left[0]);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.Remove(right[0]);
                }
            }
            return result;
        }
        private void MergeSortFinalStep()
        {
            dynamic watch = System.Diagnostics.Stopwatch.StartNew();

            arr = MergeSort(arr);

            watch.Stop();
            long time = watch.ElapsedMilliseconds;

            StatusStripChange change = ChangeStatusStrip;
            statusStrip1.Invoke((Action)(() => change($"Merge sorted. Time elapsed: { time.ToString()} ms")));

            PrintOn p = PrintOnArr;
            label1.Invoke(p);
        }
        private void MergeSortButton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(MergeSortFinalStep);
            t.Start();
        }

        public void QuickSort(Array arr, int left, int right)
        {
            int i = left, j = right;
            int curr;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }
                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    curr = arr[i];
                    arr[i] = arr[j];
                    arr[j] = curr;
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(arr, left, j);
            }
            if (i < right)
            {
                QuickSort(arr, i, right);
            }
        }
        public void QuickSortFinalStep()
        {
            dynamic watch = System.Diagnostics.Stopwatch.StartNew();

            QuickSort(arr, 0, arr.Count - 1);

            watch.Stop();
            long time = watch.ElapsedMilliseconds;

            StatusStripChange change = ChangeStatusStrip;
            statusStrip1.Invoke((Action)(() => change($"Quick sorted. Time elapsed: { time.ToString()} ms")));

            PrintOn p = PrintOnArr;
            label1.Invoke(p);
        }
        private void QuickSortButton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(QuickSortFinalStep);
            t.Start();
        }
    }
}
