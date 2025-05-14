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
            components = new System.ComponentModel.Container();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonGenerateChart = new Button();
            zedGraphControl = new ZedGraph.ZedGraphControl();
            textBoxEndDate = new TextBox();
            textBoxStartDate = new TextBox();
            buttonExit = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 541);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 32;
            label3.Text = "Конец";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 493);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 31;
            label2.Text = "Начало:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 454);
            label1.Name = "label1";
            label1.Size = new Size(402, 20);
            label1.TabIndex = 30;
            label1.Text = "Введите период, для которого производится статистика:";
            // 
            // buttonGenerateChart
            // 
            buttonGenerateChart.Location = new Point(353, 503);
            buttonGenerateChart.Name = "buttonGenerateChart";
            buttonGenerateChart.Size = new Size(184, 58);
            buttonGenerateChart.TabIndex = 29;
            buttonGenerateChart.Text = "Показать статистику";
            buttonGenerateChart.UseVisualStyleBackColor = true;
            buttonGenerateChart.Click += buttonGenerateChart_Click;
            // 
            // zedGraphControl
            // 
            zedGraphControl.Location = new Point(54, 23);
            zedGraphControl.Margin = new Padding(4, 5, 4, 5);
            zedGraphControl.Name = "zedGraphControl";
            zedGraphControl.ScrollGrace = 0D;
            zedGraphControl.ScrollMaxX = 0D;
            zedGraphControl.ScrollMaxY = 0D;
            zedGraphControl.ScrollMaxY2 = 0D;
            zedGraphControl.ScrollMinX = 0D;
            zedGraphControl.ScrollMinY = 0D;
            zedGraphControl.ScrollMinY2 = 0D;
            zedGraphControl.Size = new Size(600, 400);
            zedGraphControl.TabIndex = 28;
            zedGraphControl.UseExtendedPrintDialog = true;
            // 
            // textBoxEndDate
            // 
            textBoxEndDate.Location = new Point(165, 538);
            textBoxEndDate.Name = "textBoxEndDate";
            textBoxEndDate.Size = new Size(125, 27);
            textBoxEndDate.TabIndex = 27;
            // 
            // textBoxStartDate
            // 
            textBoxStartDate.Location = new Point(165, 488);
            textBoxStartDate.Name = "textBoxStartDate";
            textBoxStartDate.Size = new Size(125, 27);
            textBoxStartDate.TabIndex = 26;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(968, 512);
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
            dataGridView1.Location = new Point(678, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(466, 197);
            dataGridView1.TabIndex = 20;
            // 
            // VisitDataForParents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1163, 588);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonGenerateChart);
            Controls.Add(zedGraphControl);
            Controls.Add(textBoxEndDate);
            Controls.Add(textBoxStartDate);
            Controls.Add(buttonExit);
            Controls.Add(dataGridView1);
            Name = "VisitDataForParents";
            Text = "VisitDataForParents";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonGenerateChart;
        private ZedGraph.ZedGraphControl zedGraphControl;
        private TextBox textBoxEndDate;
        private TextBox textBoxStartDate;
        private Button buttonExit;
        private DataGridView dataGridView1;
    }
}