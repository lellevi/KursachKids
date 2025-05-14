namespace KursachProject
{
    partial class MenuMentor
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
            buttonParentData = new Button();
            buttonVisitData = new Button();
            buttonContractData = new Button();
            buttonAboutPayment = new Button();
            buttonAboutGroups = new Button();
            buttonAboutChildren = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonParentData
            // 
            buttonParentData.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonParentData.Location = new Point(60, 360);
            buttonParentData.Name = "buttonParentData";
            buttonParentData.Size = new Size(190, 45);
            buttonParentData.TabIndex = 15;
            buttonParentData.Text = "Родители";
            buttonParentData.UseVisualStyleBackColor = true;
            buttonParentData.Click += buttonParentData_Click;
            // 
            // buttonVisitData
            // 
            buttonVisitData.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonVisitData.Location = new Point(60, 293);
            buttonVisitData.Name = "buttonVisitData";
            buttonVisitData.Size = new Size(190, 45);
            buttonVisitData.TabIndex = 14;
            buttonVisitData.Text = "Посещение";
            buttonVisitData.UseVisualStyleBackColor = true;
            buttonVisitData.Click += buttonVisitData_Click;
            // 
            // buttonContractData
            // 
            buttonContractData.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonContractData.Location = new Point(60, 228);
            buttonContractData.Name = "buttonContractData";
            buttonContractData.Size = new Size(190, 45);
            buttonContractData.TabIndex = 13;
            buttonContractData.Text = "Договоры";
            buttonContractData.UseVisualStyleBackColor = true;
            buttonContractData.Click += buttonContractData_Click;
            // 
            // buttonAboutPayment
            // 
            buttonAboutPayment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAboutPayment.Location = new Point(60, 163);
            buttonAboutPayment.Name = "buttonAboutPayment";
            buttonAboutPayment.Size = new Size(190, 45);
            buttonAboutPayment.TabIndex = 12;
            buttonAboutPayment.Text = "Оплата";
            buttonAboutPayment.UseVisualStyleBackColor = true;
            buttonAboutPayment.Click += buttonAboutPayment_Click;
            // 
            // buttonAboutGroups
            // 
            buttonAboutGroups.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAboutGroups.Location = new Point(60, 99);
            buttonAboutGroups.Name = "buttonAboutGroups";
            buttonAboutGroups.Size = new Size(190, 45);
            buttonAboutGroups.TabIndex = 10;
            buttonAboutGroups.Text = "Группы";
            buttonAboutGroups.UseVisualStyleBackColor = true;
            buttonAboutGroups.Click += buttonAboutGroups_Click;
            // 
            // buttonAboutChildren
            // 
            buttonAboutChildren.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAboutChildren.Location = new Point(60, 35);
            buttonAboutChildren.Name = "buttonAboutChildren";
            buttonAboutChildren.Size = new Size(190, 45);
            buttonAboutChildren.TabIndex = 9;
            buttonAboutChildren.Text = "Дети";
            buttonAboutChildren.UseVisualStyleBackColor = true;
            buttonAboutChildren.Click += buttonAboutChildren_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExit.Location = new Point(60, 426);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(190, 45);
            buttonExit.TabIndex = 16;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // MenuMentor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(311, 505);
            Controls.Add(buttonExit);
            Controls.Add(buttonParentData);
            Controls.Add(buttonVisitData);
            Controls.Add(buttonContractData);
            Controls.Add(buttonAboutPayment);
            Controls.Add(buttonAboutGroups);
            Controls.Add(buttonAboutChildren);
            Name = "MenuMentor";
            Text = "MenuMentor";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonParentData;
        private Button buttonVisitData;
        private Button buttonContractData;
        private Button buttonAboutPayment;
        private Button buttonAboutGroups;
        private Button buttonAboutChildren;
        private Button buttonExit;
    }
}