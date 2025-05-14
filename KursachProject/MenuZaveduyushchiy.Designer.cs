namespace KursachProject
{
    partial class MenuZaveduyushchiy
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
            buttonAboutChildren = new Button();
            buttonAboutGroups = new Button();
            buttonAboutMentors = new Button();
            buttonAboutPayment = new Button();
            buttonContractData = new Button();
            buttonVisitData = new Button();
            buttonParentData = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonAboutChildren
            // 
            buttonAboutChildren.Font = new Font("Segoe UI", 13.8F);
            buttonAboutChildren.Location = new Point(37, 40);
            buttonAboutChildren.Name = "buttonAboutChildren";
            buttonAboutChildren.Size = new Size(190, 45);
            buttonAboutChildren.TabIndex = 0;
            buttonAboutChildren.Text = "Дети";
            buttonAboutChildren.UseVisualStyleBackColor = true;
            buttonAboutChildren.Click += buttonAboutChildren_Click;
            // 
            // buttonAboutGroups
            // 
            buttonAboutGroups.Font = new Font("Segoe UI", 13.8F);
            buttonAboutGroups.Location = new Point(37, 111);
            buttonAboutGroups.Name = "buttonAboutGroups";
            buttonAboutGroups.Size = new Size(190, 45);
            buttonAboutGroups.TabIndex = 1;
            buttonAboutGroups.Text = "Группы";
            buttonAboutGroups.UseVisualStyleBackColor = true;
            buttonAboutGroups.Click += buttonAboutGroups_Click;
            // 
            // buttonAboutMentors
            // 
            buttonAboutMentors.Font = new Font("Segoe UI", 13.8F);
            buttonAboutMentors.Location = new Point(37, 255);
            buttonAboutMentors.Name = "buttonAboutMentors";
            buttonAboutMentors.Size = new Size(190, 45);
            buttonAboutMentors.TabIndex = 4;
            buttonAboutMentors.Text = "Воспитатели";
            buttonAboutMentors.UseVisualStyleBackColor = true;
            buttonAboutMentors.Click += buttonAboutMentors_Click;
            // 
            // buttonAboutPayment
            // 
            buttonAboutPayment.Font = new Font("Segoe UI", 13.8F);
            buttonAboutPayment.Location = new Point(37, 184);
            buttonAboutPayment.Name = "buttonAboutPayment";
            buttonAboutPayment.Size = new Size(190, 45);
            buttonAboutPayment.TabIndex = 5;
            buttonAboutPayment.Text = "Платежи";
            buttonAboutPayment.UseVisualStyleBackColor = true;
            buttonAboutPayment.Click += buttonAboutPayment_Click;
            // 
            // buttonContractData
            // 
            buttonContractData.Font = new Font("Segoe UI", 13.8F);
            buttonContractData.Location = new Point(37, 326);
            buttonContractData.Name = "buttonContractData";
            buttonContractData.Size = new Size(190, 45);
            buttonContractData.TabIndex = 6;
            buttonContractData.Text = "Договоры";
            buttonContractData.UseVisualStyleBackColor = true;
            buttonContractData.Click += buttonContractData_Click;
            // 
            // buttonVisitData
            // 
            buttonVisitData.Font = new Font("Segoe UI", 13.8F);
            buttonVisitData.Location = new Point(37, 393);
            buttonVisitData.Name = "buttonVisitData";
            buttonVisitData.Size = new Size(190, 45);
            buttonVisitData.TabIndex = 7;
            buttonVisitData.Text = "Посещение";
            buttonVisitData.UseVisualStyleBackColor = true;
            buttonVisitData.Click += buttonVisitData_Click;
            // 
            // buttonParentData
            // 
            buttonParentData.Font = new Font("Segoe UI", 13.8F);
            buttonParentData.Location = new Point(37, 462);
            buttonParentData.Name = "buttonParentData";
            buttonParentData.Size = new Size(190, 45);
            buttonParentData.TabIndex = 8;
            buttonParentData.Text = "Родители";
            buttonParentData.UseVisualStyleBackColor = true;
            buttonParentData.Click += buttonParentData_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExit.Location = new Point(37, 531);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(190, 45);
            buttonExit.TabIndex = 17;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // MenuZaveduyushchiy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(254, 600);
            Controls.Add(buttonExit);
            Controls.Add(buttonParentData);
            Controls.Add(buttonVisitData);
            Controls.Add(buttonContractData);
            Controls.Add(buttonAboutPayment);
            Controls.Add(buttonAboutMentors);
            Controls.Add(buttonAboutGroups);
            Controls.Add(buttonAboutChildren);
            Name = "MenuZaveduyushchiy";
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAboutChildren;
        private Button buttonAboutGroups;
        private Button buttonAboutMentors;
        private Button buttonAboutPayment;
        private Button buttonContractData;
        private Button buttonVisitData;
        private Button buttonParentData;
        private Button buttonExit;
    }
}