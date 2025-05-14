using ZedGraph;

namespace KursachProject
{
    partial class FormVisitData
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
        private ZedGraphControl zedGraphControl; // Добавляем переменную для графика
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            buttonExit = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            buttonDownload = new Button();
            textBoxStartDate = new TextBox();
            textBoxEndDate = new TextBox();
            zedGraphControl = new ZedGraphControl();
            buttonGenerateChart = new Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            buttonAddRow = new Button();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(686, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(466, 197);
            dataGridView1.TabIndex = 1;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(1050, 368);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(176, 69);
            buttonExit.TabIndex = 12;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1050, 272);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(176, 51);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(868, 272);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(176, 51);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Отредактировать";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(686, 368);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(176, 69);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Выбрать ребёнка для добавления";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDownload
            // 
            buttonDownload.Location = new Point(686, 272);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(176, 51);
            buttonDownload.TabIndex = 7;
            buttonDownload.Text = "Обновить данные в таблице";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // textBoxStartDate
            // 
            textBoxStartDate.Location = new Point(775, 504);
            textBoxStartDate.Name = "textBoxStartDate";
            textBoxStartDate.Size = new Size(125, 27);
            textBoxStartDate.TabIndex = 13;
            // 
            // textBoxEndDate
            // 
            textBoxEndDate.Location = new Point(775, 554);
            textBoxEndDate.Name = "textBoxEndDate";
            textBoxEndDate.Size = new Size(125, 27);
            textBoxEndDate.TabIndex = 14;
            // 
            // zedGraphControl
            // 
            zedGraphControl.Location = new Point(37, 175);
            zedGraphControl.Margin = new Padding(4, 5, 4, 5);
            zedGraphControl.Name = "zedGraphControl";
            zedGraphControl.ScrollGrace = 0D;
            zedGraphControl.ScrollMaxX = 0D;
            zedGraphControl.ScrollMaxY = 0D;
            zedGraphControl.ScrollMaxY2 = 0D;
            zedGraphControl.ScrollMinX = 0D;
            zedGraphControl.ScrollMinY = 0D;
            zedGraphControl.ScrollMinY2 = 0D;
            zedGraphControl.Size = new Size(600, 402);
            zedGraphControl.TabIndex = 15;
            zedGraphControl.UseExtendedPrintDialog = true;
            // 
            // buttonGenerateChart
            // 
            buttonGenerateChart.Location = new Point(963, 519);
            buttonGenerateChart.Name = "buttonGenerateChart";
            buttonGenerateChart.Size = new Size(184, 58);
            buttonGenerateChart.TabIndex = 16;
            buttonGenerateChart.Text = "Показать статистику";
            buttonGenerateChart.UseVisualStyleBackColor = true;
            buttonGenerateChart.Click += buttonGenerateChart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(686, 470);
            label1.Name = "label1";
            label1.Size = new Size(402, 20);
            label1.TabIndex = 17;
            label1.Text = "Введите период, для которого производится статистика:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(687, 509);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 18;
            label2.Text = "Начало:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(687, 557);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 19;
            label3.Text = "Конец";
            // 
            // buttonAddRow
            // 
            buttonAddRow.Location = new Point(868, 368);
            buttonAddRow.Name = "buttonAddRow";
            buttonAddRow.Size = new Size(176, 69);
            buttonAddRow.TabIndex = 20;
            buttonAddRow.Text = "Добавить выбранную строку";
            buttonAddRow.UseVisualStyleBackColor = true;
            buttonAddRow.Click += buttonAddRow_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold);
            label4.Location = new Point(37, 40);
            label4.Name = "label4";
            label4.Size = new Size(339, 46);
            label4.TabIndex = 21;
            label4.Text = "Данные о посещении";
            // 
            // FormVisitData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1241, 614);
            Controls.Add(label4);
            Controls.Add(buttonAddRow);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonGenerateChart);
            Controls.Add(zedGraphControl);
            Controls.Add(textBoxEndDate);
            Controls.Add(textBoxStartDate);
            Controls.Add(buttonExit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDownload);
            Controls.Add(dataGridView1);
            Name = "FormVisitData";
            Text = "FormVisitData";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button buttonExit;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private Button buttonDownload;
        private TextBox textBoxStartDate;
        private TextBox textBoxEndDate;
        private Button buttonGenerateChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Button buttonAddRow;
        private System.Windows.Forms.Label label4;
    }
}