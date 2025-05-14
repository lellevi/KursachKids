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
            buttonExit = new Button();
            label1 = new Label();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            buttonDownload = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(730, 241);
            dataGridView1.TabIndex = 1;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(801, 339);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(176, 40);
            buttonExit.TabIndex = 12;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(801, 52);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 11;
            label1.Text = "Действия с данными:";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(801, 279);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(176, 40);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(801, 221);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(176, 40);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Обновить";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(801, 161);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(176, 40);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDownload
            // 
            buttonDownload.Location = new Point(801, 88);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(176, 52);
            buttonDownload.TabIndex = 7;
            buttonDownload.Text = "Обновить данные в таблице";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
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
            // FormParentData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1018, 461);
            Controls.Add(label2);
            Controls.Add(buttonExit);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDownload);
            Controls.Add(dataGridView1);
            Name = "FormParentData";
            Text = "FormParentData";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button buttonExit;
        private Label label1;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private Button buttonDownload;
        private Label label2;
    }
}