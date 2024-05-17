namespace WinAppCombinationsAvarage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxInputData = new TextBox();
            lblImputData = new Label();
            dataAvarage = new DataGridView();
            lblError = new Label();
            btnCalculate = new Button();
            lblN = new Label();
            lblK = new Label();
            txtBoxN = new TextBox();
            txtBoxK = new TextBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataAvarage).BeginInit();
            SuspendLayout();
            // 
            // txtBoxInputData
            // 
            txtBoxInputData.Location = new Point(2, 106);
            txtBoxInputData.Name = "txtBoxInputData";
            txtBoxInputData.Size = new Size(329, 27);
            txtBoxInputData.TabIndex = 0;
            txtBoxInputData.TextChanged += TxtBoxInputData_TextChanged;
            // 
            // lblImputData
            // 
            lblImputData.AutoSize = true;
            lblImputData.Location = new Point(2, 83);
            lblImputData.Name = "lblImputData";
            lblImputData.Size = new Size(329, 20);
            lblImputData.TabIndex = 1;
            lblImputData.Text = "Enter an array of elements separated by a space:";
            // 
            // dataAvarage
            // 
            dataAvarage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAvarage.Location = new Point(337, -1);
            dataAvarage.Name = "dataAvarage";
            dataAvarage.RowHeadersWidth = 51;
            dataAvarage.Size = new Size(519, 478);
            dataAvarage.TabIndex = 2;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(2, 136);
            lblError.Name = "lblError";
            lblError.Size = new Size(142, 20);
            lblError.TabIndex = 3;
            lblError.Text = "Incorrect array input";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(212, 139);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(119, 49);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += BtnCalculate_Click;
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.Location = new Point(12, 15);
            lblN.Name = "lblN";
            lblN.Size = new Size(20, 20);
            lblN.TabIndex = 5;
            lblN.Text = "N";
            // 
            // lblK
            // 
            lblK.AutoSize = true;
            lblK.Location = new Point(176, 15);
            lblK.Name = "lblK";
            lblK.Size = new Size(18, 20);
            lblK.TabIndex = 6;
            lblK.Text = "K";
            // 
            // txtBoxN
            // 
            txtBoxN.Location = new Point(38, 12);
            txtBoxN.Name = "txtBoxN";
            txtBoxN.Size = new Size(50, 27);
            txtBoxN.TabIndex = 7;
            // 
            // txtBoxK
            // 
            txtBoxK.Location = new Point(200, 12);
            txtBoxK.Name = "txtBoxK";
            txtBoxK.Size = new Size(50, 27);
            txtBoxK.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 438);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 39);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 580);
            Controls.Add(btnClear);
            Controls.Add(txtBoxK);
            Controls.Add(txtBoxN);
            Controls.Add(lblK);
            Controls.Add(lblN);
            Controls.Add(btnCalculate);
            Controls.Add(lblError);
            Controls.Add(dataAvarage);
            Controls.Add(lblImputData);
            Controls.Add(txtBoxInputData);
            MinimumSize = new Size(818, 497);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataAvarage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInputData;
        private Label lblImputData;
        private DataGridView dataAvarage;
        private Label lblError;
        private Button btnCalculate;
        private Label lblN;
        private Label lblK;
        private TextBox txtBoxN;
        private TextBox txtBoxK;
        private Button btnClear;
    }
}
