namespace KursachProject
{
    partial class VisitDataForParents
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
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(541, 323);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(176, 40);
            buttonExit.TabIndex = 25;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(705, 226);
            dataGridView1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold);
            label4.Location = new Point(22, 18);
            label4.Name = "label4";
            label4.Size = new Size(339, 46);
            label4.TabIndex = 26;
            label4.Text = "Данные о посещении";
            // 
            // VisitDataForParents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(729, 385);
            Controls.Add(label4);
            Controls.Add(buttonExit);
            Controls.Add(dataGridView1);
            Name = "VisitDataForParents";
            Text = "VisitDataForParents";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonExit;
        private DataGridView dataGridView1;
        private Label label4;
    }
}