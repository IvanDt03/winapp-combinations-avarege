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
            textBox1 = new TextBox();
            lblImputData = new Label();
            dataGridView1 = new DataGridView();
            lblError = new Label();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 27);
            textBox1.TabIndex = 0;
            // 
            // lblImputData
            // 
            lblImputData.AutoSize = true;
            lblImputData.Location = new Point(12, 25);
            lblImputData.Name = "lblImputData";
            lblImputData.Size = new Size(329, 20);
            lblImputData.TabIndex = 1;
            lblImputData.Text = "Enter an array of elements separated by a space:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(402, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(398, 449);
            dataGridView1.TabIndex = 2;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(12, 79);
            lblError.Name = "lblError";
            lblError.Size = new Size(142, 20);
            lblError.TabIndex = 3;
            lblError.Text = "Incorrect array input";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(212, 89);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(119, 49);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(lblError);
            Controls.Add(dataGridView1);
            Controls.Add(lblImputData);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblImputData;
        private DataGridView dataGridView1;
        private Label lblError;
        private Button btnCalculate;
    }
}
