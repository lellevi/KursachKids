namespace KursachProject
{
    partial class ContractDataForMentors
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
            buttonExit = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(532, 332);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(176, 40);
            buttonExit.TabIndex = 19;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(673, 228);
            dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold);
            label1.Location = new Point(40, 25);
            label1.Name = "label1";
            label1.Size = new Size(326, 46);
            label1.TabIndex = 20;
            label1.Text = "Данные о договорах";
            // 
            // ContractDataForMentors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(731, 392);
            Controls.Add(label1);
            Controls.Add(buttonExit);
            Controls.Add(dataGridView1);
            Name = "ContractDataForMentors";
            Text = "ContractDataForMentors";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonExit;
        private DataGridView dataGridView1;
        private Label label1;
    }
}