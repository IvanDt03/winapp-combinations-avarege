using System.Diagnostics;

namespace WinAppCombinationsAvarage
{
    public partial class Form1 : Form
    {
        private Combinations listCombination = new Combinations();
        public Form1()
        {
            InitializeComponent();


            dataAvarage.Columns.Add("№", "№");
            dataAvarage.Columns["№"].ReadOnly = true;

            dataAvarage.Columns.Add("Average value", "Average value");
            dataAvarage.Columns["Average value"].ReadOnly = true;

            dataAvarage.Columns.Add("Standard deviation", "Standard deviation");
            dataAvarage.Columns["Standard deviation"].ReadOnly = true;

            dataAvarage.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataAvarage.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lblError.Visible = false;
            btnCalculate.Visible = false;
        }

        private void TxtBoxInputData_TextChanged(object? sender, EventArgs e) => btnCalculate.Visible = true;

        private void BtnCalculate_Click(object? sender, EventArgs e)
        {
            // Провека корректности цвета и входных данных N и K
            ColorChange(txtBoxN, txtBoxK);
            if (!ParseTextBox()) return;
            // Конец

            // Конвертация входных данных из строки в массив типа double
            if (!TryParseData(txtBoxInputData.Text, out double[] imputData))
            {
                lblError.Visible = true;
                return;
            }
            else lblError.Visible = false;
            // Конец

            if (listCombination.combinations is not null) Clear();

            listCombination.N = int.Parse(txtBoxN.Text);
            listCombination.K = int.Parse(txtBoxK.Text);

            listCombination.GenerateCombinations(imputData, listCombination.N, listCombination.K, new List<double>(), 0);

            PrintData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxInputData.Clear();
            Clear();
        }
        private void Clear()
        {
            dataAvarage.Rows.Clear();
            listCombination.combinations.Clear();
            RemoveColumns();
        }
        private void RemoveColumns()
        {
            for (int i = dataAvarage.Columns["№"].Index + 1; i <= listCombination.K; ++i)
            {
                if (dataAvarage.Columns.Contains($"{i}"))
                    dataAvarage.Columns.Remove($"{i}");
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
        private void ColorChange(TextBox txtBoxN, TextBox txtBoxK)
        {
            if (txtBoxN.BackColor == Color.IndianRed) txtBoxN.BackColor = Color.White;
            if (txtBoxK.BackColor == Color.IndianRed) txtBoxK.BackColor = Color.White;
        }
        private bool TryParseData(string textData, out double[] data)
        {
            data = Array.Empty<double>();

            textData = textData.Trim();
            if (textData == string.Empty) return false;

            string[] strsData = textData.Split(' ', '\t', '\n');
            foreach (var str in strsData)
            {
                if (!double.TryParse(str, out _))
                    return false;
            }
            if (strsData.Length != int.Parse(txtBoxN.Text)) return false;

            data = strsData.Select(x => double.Parse(x)).ToArray();
            return true;
        }
        private void PrintData()
        {
            CreateColumns();

            for (int numberRow = 0; numberRow < listCombination.combinations.Count; ++numberRow)
            {
                dataAvarage.Rows.Add();
                dataAvarage["№", numberRow].Value = numberRow + 1;
                FillRowCombination(numberRow);
                dataAvarage["Average value", numberRow].Value = Math.Round(listCombination.combinations[numberRow].Average(), 3);
                dataAvarage["Standard deviation", numberRow].Value = listCombination.StandardDeviation(numberRow);
            }
        }
        private void FillRowCombination(int numberRow)
        {
            for (int i = dataAvarage.Columns["№"].Index + 1, k = 0; i <= listCombination.K; ++i, ++k)
                dataAvarage[$"{i}", numberRow].Value = listCombination.combinations[numberRow][k];
        }
        private void CreateColumns()
        {
            for (int i = dataAvarage.Columns["№"].Index + 1; i <= listCombination.K; ++i)
            {
                dataAvarage.Columns.Insert(i, new DataGridViewColumn()
                {
                    Name = $"{i}",
                    HeaderText = "",
                    ValueType = typeof(double),
                    CellTemplate = new DataGridViewTextBoxCell(),
                    ReadOnly = true,
                });
                dataAvarage.EnableHeadersVisualStyles = false;
                dataAvarage.Columns[$"{i}"].HeaderCell.Style.BackColor = Color.Black;
            }
        }
    }


}
