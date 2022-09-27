using DataLogger.lib;

namespace DataLogger.App
{
    public partial class MainForm : Form
    {
        public CSVLoader csvLoader = new CSVLoader();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog CSV = new ();
            CSV.Filter = "CSV-File| *.csv";
            CSV.ShowDialog();
        }
    }
}