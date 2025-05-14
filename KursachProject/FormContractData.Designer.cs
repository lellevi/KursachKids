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
            label1 = new Label();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            buttonDownLoad1 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(673, 228);
            dataGridView1.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(767, 327);
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
            label1.Location = new Point(767, 40);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 11;
            label1.Text = "Действия с данными:";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(767, 267);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(176, 40);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(767, 209);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(176, 40);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Отредактировать";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(767, 149);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(176, 40);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDownLoad1
            // 
            buttonDownLoad1.Location = new Point(767, 72);
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
            label3.Location = new Point(58, 40);
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
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
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
        private Label label1;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private Button buttonDownLoad1;
        private Label label2;
        private Label label3;
    }
}