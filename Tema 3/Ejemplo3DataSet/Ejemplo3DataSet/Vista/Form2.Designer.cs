namespace Ejemplo3DataSet
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewCountry = new DataGridView();
            dataGridViewCity = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCity).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCountry
            // 
            dataGridViewCountry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCountry.Location = new Point(12, 12);
            dataGridViewCountry.Name = "dataGridViewCountry";
            dataGridViewCountry.RowHeadersWidth = 51;
            dataGridViewCountry.Size = new Size(776, 188);
            dataGridViewCountry.TabIndex = 0;
            // 
            // dataGridViewCity
            // 
            dataGridViewCity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCity.Location = new Point(12, 237);
            dataGridViewCity.Name = "dataGridViewCity";
            dataGridViewCity.RowHeadersWidth = 51;
            dataGridViewCity.Size = new Size(776, 188);
            dataGridViewCity.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewCity);
            Controls.Add(dataGridViewCountry);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountry).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCountry;
        private DataGridView dataGridViewCity;
    }
}