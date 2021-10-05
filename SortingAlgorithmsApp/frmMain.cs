using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmsApp
{
    public partial class frmMain : Form
    {
        int[] DataSet_Small = new int[1000];
        int[] DataSet_Medium = new int[10000];
        int[] DataSet_Large = new int[30000];
        bool Datasets_Are_Initialized = false;
        List<SortResult> lstAllResults = new List<SortResult>();
        int RunNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            //1...Initialize Datasets
            this.Cursor = Cursors.WaitCursor;
            lblStatus.Text = "Initializing datasets...";
            if (!this.Datasets_Are_Initialized)
            {
                RandomGenerator rg = new RandomGenerator();
                for (int i = 0; i <= this.DataSet_Small.Length - 1; i++)
                    this.DataSet_Small[i] = rg.RandomNumber(1, 100000);
                for (int i = 0; i <= this.DataSet_Medium.Length - 1; i++)
                    this.DataSet_Medium[i] = rg.RandomNumber(1, 100000);
                for (int i = 0; i <= this.DataSet_Large.Length - 1; i++)
                    this.DataSet_Large[i] = rg.RandomNumber(1, 100000);
            }
            lblStatus.Text = "Datasets initialization complete.";

            RunNumber++;
            SortResult sr = new SortResult();

            //2...Call Bubble Sort
            int[] temp1 = new int[this.DataSet_Small.Length];
            int[] temp2 = new int[this.DataSet_Medium.Length];
            int[] temp3 = new int[this.DataSet_Large.Length];

            //small dataset
            lblStatus.Text = "Sorting Bubble Sort (Conventional) with small dataset...";
            Application.DoEvents();
            this.DataSet_Small.CopyTo(temp1, 0);
            DateTime st = DateTime.Now;
            this.BubbleSortConventional(temp1);
            DateTime et = DateTime.Now;
            TimeSpan ts = et - st;                       
            lblBSSStartTime.Text = st.ToString("HH:mm:ss.fffff");
            lblBSSEndTime.Text = et.ToString("HH:mm:ss.fffff");
            lblBSSDiff.Text = string.Format("{0}:{1}:{2}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.ToString("fffff"));
            lblStatus.Text = "Sorting Bubble Sort (Conventional) with small dataset complete.";
            Application.DoEvents();
            sr = new SortResult();
            sr.RunNumber = this.RunNumber;
            sr.Algorithm = AlgorithmName.BubbleSort_Conventional;
            sr.Dataset = DatasetType.Small;
            sr.StartTime = st;
            sr.EndTime = et;
            sr.TimeElapsed = ts;
            this.lstAllResults.Add(sr);

            //medium dataset
            lblStatus.Text = "Sorting Bubble Sort (Conventional) with medium dataset...";
            Application.DoEvents();
            this.DataSet_Medium.CopyTo(temp2, 0);
            st = DateTime.Now;
            this.BubbleSortConventional(temp2);
            et = DateTime.Now;
            ts = et - st;
            lblBSMStartTime.Text = st.ToString("HH:mm:ss.fffff");
            lblBSMEndTime.Text = et.ToString("HH:mm:ss.fffff");
            lblBSMDiff.Text = string.Format("{0}:{1}:{2}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.ToString("fffff"));
            lblStatus.Text = "Sorting Bubble Sort (Conventional) with medium dataset complete.";
            Application.DoEvents();
            sr = new SortResult();
            sr.RunNumber = this.RunNumber;
            sr.Algorithm = AlgorithmName.BubbleSort_Conventional;
            sr.Dataset = DatasetType.Medium;
            sr.StartTime = st;
            sr.EndTime = et;
            sr.TimeElapsed = ts;
            this.lstAllResults.Add(sr);

            //large dataset
            lblStatus.Text = "Sorting Bubble Sort (Conventional) with large dataset...";
            Application.DoEvents();
            this.DataSet_Large.CopyTo(temp3, 0);
            st = DateTime.Now;
            this.BubbleSortConventional(temp3);
            et = DateTime.Now;
            ts = et - st;
            lblBSLStartTime.Text = st.ToString("HH:mm:ss.fffff");
            lblBSLEndTime.Text = et.ToString("HH:mm:ss.fffff");
            lblBSLDiff.Text = string.Format("{0}:{1}:{2}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.ToString("fffff"));
            lblStatus.Text = "Sorting Bubble Sort (Conventional) with large dataset complete.";
            Application.DoEvents();
            sr = new SortResult();
            sr.RunNumber = this.RunNumber;
            sr.Algorithm = AlgorithmName.BubbleSort_Conventional;
            sr.Dataset = DatasetType.Large;
            sr.StartTime = st;
            sr.EndTime = et;
            sr.TimeElapsed = ts;
            this.lstAllResults.Add(sr);

            //3...Call Bubble Sort with Improvement
            //small dataset
            lblStatus.Text = "Sorting Bubble Sort (My Improvement) with small dataset...";
            Application.DoEvents();
            this.DataSet_Small.CopyTo(temp1, 0);
            st = DateTime.Now;
            this.BubbleSortWithMyImprovement(temp1);
            et = DateTime.Now;
            ts = et - st;
            lblBSISStartTime.Text = st.ToString("HH:mm:ss.fffff");
            lblBSISEndTime.Text = et.ToString("HH:mm:ss.fffff");
            lblBSISDiff.Text = string.Format("{0}:{1}:{2}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.ToString("fffff"));
            lblStatus.Text = "Sorting Bubble Sort (My Improvement) with small dataset complete.";
            Application.DoEvents();
            sr = new SortResult();
            sr.RunNumber = this.RunNumber;
            sr.Algorithm = AlgorithmName.BubbleSort_MyImprovement;
            sr.Dataset = DatasetType.Small;
            sr.StartTime = st;
            sr.EndTime = et;
            sr.TimeElapsed = ts;
            this.lstAllResults.Add(sr);

            ////medium dataset
            lblStatus.Text = "Sorting Bubble Sort (My Improvement) with medium dataset...";
            Application.DoEvents();
            this.DataSet_Medium.CopyTo(temp2, 0);
            st = DateTime.Now;
            this.BubbleSortWithMyImprovement(temp2);
            et = DateTime.Now;
            ts = et - st;
            lblBSIMStartTime.Text = st.ToString("HH:mm:ss.fffff");
            lblBSIMEndTime.Text = et.ToString("HH:mm:ss.fffff");
            lblBSIMDiff.Text = string.Format("{0}:{1}:{2}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.ToString("fffff"));
            lblStatus.Text = "Sorting Bubble Sort (My Improvement) with medium dataset complete.";
            Application.DoEvents();
            sr = new SortResult();
            sr.RunNumber = this.RunNumber;
            sr.Algorithm = AlgorithmName.BubbleSort_MyImprovement;
            sr.Dataset = DatasetType.Medium;
            sr.StartTime = st;
            sr.EndTime = et;
            sr.TimeElapsed = ts;
            this.lstAllResults.Add(sr);

            ////large dataset
            lblStatus.Text = "Sorting Bubble Sort (My Improvement) with large dataset...";
            Application.DoEvents();
            this.DataSet_Large.CopyTo(temp3, 0);
            st = DateTime.Now;
            this.BubbleSortWithMyImprovement(temp3);
            et = DateTime.Now;
            ts = et - st;
            lblBSILStartTime.Text = st.ToString("HH:mm:ss.fffff");
            lblBSILEndTime.Text = et.ToString("HH:mm:ss.fffff");
            lblBSILDiff.Text = string.Format("{0}:{1}:{2}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.ToString("fffff"));
            lblStatus.Text = "Sorting Bubble Sort (My Improvement) with large dataset complete.";
            Application.DoEvents();
            sr = new SortResult();
            sr.RunNumber = this.RunNumber;
            sr.Algorithm = AlgorithmName.BubbleSort_MyImprovement;
            sr.Dataset = DatasetType.Large;
            sr.StartTime = st;
            sr.EndTime = et;
            sr.TimeElapsed = ts;
            this.lstAllResults.Add(sr);

            //4...Call Quick Sort
            //small dataset
            lblStatus.Text = "Sorting Quick Sort with small dataset...";
            Application.DoEvents();
            this.DataSet_Small.CopyTo(temp1, 0);
            st = DateTime.Now;
            this.Quick_Sort(temp1, 0, temp1.Length - 1);
            et = DateTime.Now;
            ts = et - st;
            lblQSSStartTime.Text = st.ToString("HH:mm:ss.fffff");
            lblQSSEndTime.Text = et.ToString("HH:mm:ss.fffff");
            lblQSSDiff.Text = string.Format("{0}:{1}:{2}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.ToString("fffff"));
            lblStatus.Text = "Sorting Quick Sort with small dataset complete.";
            Application.DoEvents();
            sr = new SortResult();
            sr.RunNumber = this.RunNumber;
            sr.Algorithm = AlgorithmName.QuickSort;
            sr.Dataset = DatasetType.Small;
            sr.StartTime = st;
            sr.EndTime = et;
            sr.TimeElapsed = ts;
            this.lstAllResults.Add(sr);

            ////medium dataset
            lblStatus.Text = "Sorting Quick Sort with medium dataset...";
            Application.DoEvents();
            this.DataSet_Medium.CopyTo(temp2, 0);
            st = DateTime.Now;
            this.Quick_Sort(temp2, 0, temp2.Length - 1);
            et = DateTime.Now;
            ts = et - st;
            lblQSMStartTime.Text = st.ToString("HH:mm:ss.fffff");
            lblQSMEndTime.Text = et.ToString("HH:mm:ss.fffff");
            lblQSMDiff.Text = string.Format("{0}:{1}:{2}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.ToString("fffff"));
            lblStatus.Text = "Sorting Quick Sort with medium dataset complete.";
            Application.DoEvents();
            sr = new SortResult();
            sr.RunNumber = this.RunNumber;
            sr.Algorithm = AlgorithmName.QuickSort;
            sr.Dataset = DatasetType.Medium;
            sr.StartTime = st;
            sr.EndTime = et;
            sr.TimeElapsed = ts;
            this.lstAllResults.Add(sr);

            ////large dataset
            lblStatus.Text = "Sorting Quick Sort with large dataset...";
            Application.DoEvents();
            this.DataSet_Large.CopyTo(temp3, 0);
            st = DateTime.Now;
            this.Quick_Sort(temp3, 0, temp3.Length - 1);
            et = DateTime.Now;
            ts = et - st;
            lblQSLStartTime.Text = st.ToString("HH:mm:ss.fffff");
            lblQSLEndTime.Text = et.ToString("HH:mm:ss.fffff");
            lblQSLDiff.Text = string.Format("{0}:{1}:{2}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.ToString("fffff"));
            lblStatus.Text = "Sorting Quick Sort with large dataset complete.";
            Application.DoEvents();
            sr = new SortResult();
            sr.RunNumber = this.RunNumber;
            sr.Algorithm = AlgorithmName.QuickSort;
            sr.Dataset = DatasetType.Large;
            sr.StartTime = st;
            sr.EndTime = et;
            sr.TimeElapsed = ts;
            this.lstAllResults.Add(sr);

            this.Cursor = Cursors.Default;
            MessageBox.Show("Process completed.");
            lblStatus.Text = "Process completed.";
        }

        //reference url: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-3.php
        private void BubbleSortConventional(int[] dataset)
        {
            int temp;
            for (int j = 0; j <= dataset.Length - 2; j++)
            {
                for (int i = 0; i <= dataset.Length - 2; i++)
                {
                    if (dataset[i] > dataset[i + 1])
                    {
                        temp = dataset[i + 1];
                        dataset[i + 1] = dataset[i];
                        dataset[i] = temp;
                    }
                }
            }
        }

        private void BubbleSortWithMyImprovement(int[] dataset)
        {
            int temp;
            for (int j = 0; j <= dataset.Length - 2; j++)
            {
                bool swapped = false;
                for (int i = 0; i <= dataset.Length - 2; i++)
                {
                    if (dataset[i] > dataset[i + 1])
                    {
                        temp = dataset[i + 1];
                        dataset[i + 1] = dataset[i];
                        dataset[i] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }

        //reference url: https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-9.php
        private void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        private void btnViewAllResults_Click(object sender, EventArgs e)
        {
            if (this.lstAllResults.Count == 0)
                MessageBox.Show("No data found.");
            else
            {
                frmViewAllResults frm = new frmViewAllResults();
                frm.IN_lstResults = this.lstAllResults;
                frm.IN_TotalResults = this.RunNumber;
                frm.ShowDialog();
            }
        }
    }
}
