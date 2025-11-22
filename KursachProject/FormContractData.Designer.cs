namespace KursachProject
{
    partial class FormContractData
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
            dataGridView1 = new DataGridView();
            buttonExit = new Button();
            buttonDelete = new Button();
            buttonDownLoad1 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(908, 228);
            dataGridView1.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(767, 326);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(176, 56);
            buttonExit.TabIndex = 12;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(576, 326);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(176, 56);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonDownLoad1
            // 
            buttonDownLoad1.Location = new Point(383, 326);
            buttonDownLoad1.Name = "buttonDownLoad1";
            buttonDownLoad1.Size = new Size(176, 56);
            buttonDownLoad1.TabIndex = 13;
            buttonDownLoad1.Text = "Обновить данные в таблице";
            buttonDownLoad1.UseVisualStyleBackColor = true;
            buttonDownLoad1.Click += buttonDownLoad1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 52);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold);
            label3.Location = new Point(35, 26);
            label3.Name = "label3";
            label3.Size = new Size(326, 46);
            label3.TabIndex = 21;
            label3.Text = "Данные о договорах";
            // 
            // FormContractData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(969, 394);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonDownLoad1);
            Controls.Add(buttonExit);
            Controls.Add(buttonDelete);
            Controls.Add(dataGridView1);
            Name = "FormContractData";
            Text = "FormContractData";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonDownload;
        private Button buttonExit;
        private Button buttonDelete;
        private Button buttonDownLoad1;
        private Label label2;
        private Label label3;
    }
}