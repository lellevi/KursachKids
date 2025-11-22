namespace KursachProject
{
    partial class FormParentData
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
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(959, 241);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold);
            label2.Location = new Point(41, 52);
            label2.Name = "label2";
            label2.Size = new Size(348, 46);
            label2.TabIndex = 21;
            label2.Text = "Данные о родителях";
            // 
            // buttonDownLoad1
            // 
            buttonDownLoad1.Location = new Point(431, 385);
            buttonDownLoad1.Name = "buttonDownLoad1";
            buttonDownLoad1.Size = new Size(176, 56);
            buttonDownLoad1.TabIndex = 25;
            buttonDownLoad1.Text = "Обновить данные в таблице";
            buttonDownLoad1.UseVisualStyleBackColor = true;
            buttonDownLoad1.Click += buttonDownload_Click;
            // 
            // button2
            // 
            button2.Location = new Point(815, 385);
            button2.Name = "button2";
            button2.Size = new Size(176, 56);
            button2.TabIndex = 24;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonExit_Click;
            // 
            // button3
            // 
            button3.Location = new Point(624, 385);
            button3.Name = "button3";
            button3.Size = new Size(176, 56);
            button3.TabIndex = 23;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonDelete_Click;
            // 
            // FormParentData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1018, 461);
            Controls.Add(buttonDownLoad1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "FormParentData";
            Text = "FormParentData";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label2;
        private Button buttonDownLoad1;
        private Button button2;
        private Button button3;
    }
}