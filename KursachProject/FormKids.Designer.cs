namespace KursachProject
{
    partial class FormKids
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
            label2 = new Label();
            buttonDownLoad1 = new Button();
            buttonExit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(945, 217);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold);
            label2.Location = new Point(59, 31);
            label2.Name = "label2";
            label2.Size = new Size(275, 46);
            label2.TabIndex = 21;
            label2.Text = "Данные о детях";
            // 
            // buttonDownLoad1
            // 
            buttonDownLoad1.Location = new Point(425, 318);
            buttonDownLoad1.Name = "buttonDownLoad1";
            buttonDownLoad1.Size = new Size(176, 56);
            buttonDownLoad1.TabIndex = 24;
            buttonDownLoad1.Text = "Обновить данные в таблице";
            buttonDownLoad1.UseVisualStyleBackColor = true;
            buttonDownLoad1.Click += buttonDownload_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(809, 318);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(176, 56);
            buttonExit.TabIndex = 23;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(618, 318);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(176, 56);
            buttonDelete.TabIndex = 22;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormKids
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1004, 398);
            Controls.Add(buttonDownLoad1);
            Controls.Add(buttonExit);
            Controls.Add(buttonDelete);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "FormKids";
            Text = "Дети";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Button buttonDownLoad1;
        private Button buttonExit;
        private Button buttonDelete;
    }
}