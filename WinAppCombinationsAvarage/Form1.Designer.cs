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
            lblImputData = new Label();
            dataAvarage = new DataGridView();
            lblError = new Label();
            btnCalculate = new Button();
            lblN = new Label();
            lblK = new Label();
            txtBoxN = new TextBox();
            txtBoxK = new TextBox();
            btnClear = new Button();
            txtBoxInputData = new TextBox();
            author = new Label();
            ((System.ComponentModel.ISupportInitialize)dataAvarage).BeginInit();
            SuspendLayout();
            // 
            // lblImputData
            // 
            lblImputData.AutoSize = true;
            lblImputData.Location = new Point(12, 73);
            lblImputData.Name = "lblImputData";
            lblImputData.Size = new Size(329, 20);
            lblImputData.TabIndex = 1;
            lblImputData.Text = "Enter an array of elements separated by a space:";
            // 
            // dataAvarage
            // 
            dataAvarage.AllowUserToAddRows = false;
            dataAvarage.AllowUserToDeleteRows = false;
            dataAvarage.AllowUserToResizeColumns = false;
            dataAvarage.AllowUserToResizeRows = false;
            dataAvarage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataAvarage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAvarage.BackgroundColor = Color.DimGray;
            dataAvarage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAvarage.Location = new Point(386, 2);
            dataAvarage.Name = "dataAvarage";
            dataAvarage.ReadOnly = true;
            dataAvarage.RowHeadersWidth = 51;
            dataAvarage.Size = new Size(675, 571);
            dataAvarage.TabIndex = 2;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(12, 126);
            lblError.Name = "lblError";
            lblError.Size = new Size(142, 20);
            lblError.TabIndex = 3;
            lblError.Text = "Incorrect array input";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.LimeGreen;
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.Location = new Point(249, 129);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(119, 49);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += BtnCalculate_Click;
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.Location = new Point(12, 21);
            lblN.Name = "lblN";
            lblN.Size = new Size(20, 20);
            lblN.TabIndex = 5;
            lblN.Text = "N";
            // 
            // lblK
            // 
            lblK.AutoSize = true;
            lblK.Location = new Point(170, 24);
            lblK.Name = "lblK";
            lblK.Size = new Size(18, 20);
            lblK.TabIndex = 6;
            lblK.Text = "K";
            // 
            // txtBoxN
            // 
            txtBoxN.Cursor = Cursors.Hand;
            txtBoxN.Location = new Point(38, 18);
            txtBoxN.Name = "txtBoxN";
            txtBoxN.Size = new Size(50, 27);
            txtBoxN.TabIndex = 7;
            // 
            // txtBoxK
            // 
            txtBoxK.Cursor = Cursors.Hand;
            txtBoxK.Location = new Point(194, 21);
            txtBoxK.Name = "txtBoxK";
            txtBoxK.Size = new Size(50, 27);
            txtBoxK.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Firebrick;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(249, 184);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 39);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtBoxInputData
            // 
            txtBoxInputData.Cursor = Cursors.Hand;
            txtBoxInputData.Location = new Point(12, 96);
            txtBoxInputData.Name = "txtBoxInputData";
            txtBoxInputData.Size = new Size(361, 27);
            txtBoxInputData.TabIndex = 10;
            txtBoxInputData.TextChanged += TxtBoxInputData_TextChanged;
            // 
            // author
            // 
            author.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            author.AutoSize = true;
            author.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 204);
            author.Location = new Point(2, 534);
            author.Name = "author";
            author.Size = new Size(184, 36);
            author.TabIndex = 11;
            author.Text = "Дмитриев Иван Александрович\r\nФундаментальная и прикладная химия\r\n2 группа";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1061, 576);
            Controls.Add(author);
            Controls.Add(txtBoxInputData);
            Controls.Add(btnClear);
            Controls.Add(txtBoxK);
            Controls.Add(txtBoxN);
            Controls.Add(lblK);
            Controls.Add(lblN);
            Controls.Add(btnCalculate);
            Controls.Add(lblError);
            Controls.Add(dataAvarage);
            Controls.Add(lblImputData);
            MinimumSize = new Size(1079, 608);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate Average";
            ((System.ComponentModel.ISupportInitialize)dataAvarage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label lblImputData;
        private DataGridView dataAvarage;
        private Label lblError;
        private Button btnCalculate;
        private Label lblN;
        private Label lblK;
        private TextBox txtBoxN;
        private TextBox txtBoxK;
        private Button btnClear;
        private TextBox txtBoxInputData;
        private Label author;
    }
}
