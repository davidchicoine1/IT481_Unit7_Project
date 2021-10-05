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
    public partial class frmViewAllResults : Form
    {
        public List<SortResult> IN_lstResults = new List<SortResult>();
        public int IN_TotalResults = 0;
        public frmViewAllResults()
        {
            InitializeComponent();
        }

        private void frmViewAllResults_Load(object sender, EventArgs e)
        {
            //Load enumerations
            cmbAlgorithm.Items.Clear();
            foreach (AlgorithmName v in (AlgorithmName[])Enum.GetValues(typeof(AlgorithmName)))
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = v.ToString();
                item.Value = (int)v;
                cmbAlgorithm.Items.Add(item);
            }

            cmbDataset.Items.Clear();
            foreach (DatasetType v in (DatasetType[])Enum.GetValues(typeof(DatasetType)))
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = v.ToString();
                item.Value = (int)v;
                cmbDataset.Items.Add(item);
            }

            cmbRunNumber.Items.Clear();
            for (int i = 1; i <= this.IN_TotalResults; i++)
                cmbRunNumber.Items.Add(i);
        }

        private void btnDisplayResult_Click(object sender, EventArgs e)
        {
            lblStartTime.Text = "";
            lblEndTime.Text = "";
            lblDiff.Text = "";

            if (cmbAlgorithm.SelectedItem != null && cmbDataset.SelectedItem != null && cmbRunNumber.SelectedItem != null)
            {
                int AlgorithmNo = Convert.ToInt32((cmbAlgorithm.SelectedItem as ComboboxItem).Value);
                int DatasetNo = Convert.ToInt32((cmbDataset.SelectedItem as ComboboxItem).Value);
                int RunNumber = Convert.ToInt32(cmbRunNumber.SelectedItem.ToString());

                foreach(SortResult sr in this.IN_lstResults)
                {
                    if (sr.Algorithm == (AlgorithmName)AlgorithmNo && sr.Dataset == (DatasetType)DatasetNo && sr.RunNumber == RunNumber)
                    {
                        lblStartTime.Text = sr.StartTime.ToString("HH:mm:ss.fffff");
                        lblEndTime.Text = sr.EndTime.ToString("HH:mm:ss.fffff");
                        lblDiff.Text = string.Format("{0}:{1}:{2}.{3}", sr.TimeElapsed.Hours, sr.TimeElapsed.Minutes, sr.TimeElapsed.Seconds, sr.TimeElapsed.ToString("fffff"));
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select all the three fields.");
            }
        }
    }
}
