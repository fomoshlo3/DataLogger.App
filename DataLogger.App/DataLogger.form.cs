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

        private void btn_CSVLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog CSV = new();
            CSV.Filter = "CSV-File| *.csv";
            CSV.ShowDialog();
            try
            {
                csvLoader.ImportCSV(CSV.FileName);
            }
            catch
            {
                MessageBox.Show("fehlerhaftes CSV-File");
            }
        }
    }
}