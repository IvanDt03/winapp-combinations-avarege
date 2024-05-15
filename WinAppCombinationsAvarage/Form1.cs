namespace WinAppCombinationsAvarage
{
    public partial class Form1 : Form
    {
        private Combinations listCombination = new Combinations();
        public Form1()
        {
            InitializeComponent();

            // DGV.Rows[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataAvarage.Columns.Add("¹", "¹");
            dataAvarage.Columns["¹"].Width = 50;

            dataAvarage.Columns.Add("Combinations", "Combinations");
            dataAvarage.Columns["Combinations"].Width = 230;

            dataAvarage.Columns.Add("Average value", "Average value");
            dataAvarage.Columns["Average value"].Width = 150;

            dataAvarage.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataAvarage.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lblError.Visible = false;
            btnCalculate.Visible = false;
        }

        private void TxtBoxInputData_TextChanged(object? sender, EventArgs e) =>  btnCalculate.Visible = true;

        private void BtnCalculate_Click(object? sender, EventArgs e)
        {
            

            txtBoxK.BackColor = Color.White;
            txtBoxN.BackColor = Color.White;
            if (!ParseTextBox()) return;

            if (!TryParseData(txtBoxInputData.Text)) { lblError.Visible = true; return; }
            else lblError.Visible = false;


            double[] imputData = ParseData(txtBoxInputData.Text);
            listCombination.N = int.Parse(txtBoxN.Text);
            listCombination.K = int.Parse(txtBoxK.Text);

            listCombination.GenerateCombinations(imputData, listCombination.N, listCombination.K, new List<double>(), 0);

            int row = 0;
            foreach (var combination in listCombination.combinations)
            {
                dataAvarage.Rows.Add();
                dataAvarage["¹", row].Value = row + 1;
                dataAvarage["Combinations", row].Value = string.Join(',', listCombination.combinations[row]);
                dataAvarage["Average value", row].Value = listCombination.combinations[row].Average();
                row++;
            }
        }


        private bool ParseTextBox()
        {
            if (txtBoxN.Text == string.Empty || txtBoxK.Text == string.Empty || !int.TryParse(txtBoxN.Text, out _) || !int.TryParse(txtBoxK.Text, out _))
            {
                if (txtBoxK.Text == string.Empty || int.TryParse(txtBoxN.Text, out _)) txtBoxK.BackColor = Color.IndianRed;
                if (txtBoxN.Text == string.Empty || int.TryParse(txtBoxK.Text, out _)) txtBoxN.BackColor = Color.IndianRed;
                return false;
            }
            return true;
        }
        private double[] ParseData(string data)
        {
            return data.Split(' ').Select(x => double.Parse(x)).ToArray();
        }
        private bool TryParseData(string data)
        {
            data = data.Trim();
            if (data == string.Empty) return false;

            string[] strsData = data.Split(' ');
            foreach (var str in strsData)
            {
                if (!double.TryParse(str, out _))
                    return false;
            }
            if (strsData.Length != int.Parse(txtBoxN.Text)) return false;

            return true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxInputData.Clear();
            dataAvarage.Rows.Clear();
            listCombination.combinations.Clear();
        }
    }
}
