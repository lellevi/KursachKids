namespace KursachProject
{
    partial class MenuParent
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
            buttonVisitData = new Button();
            buttonAboutPayment = new Button();
            buttonAboutMentors = new Button();
            buttonAboutGroups = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonVisitData
            // 
            buttonVisitData.Font = new Font("Segoe UI", 13.8F);
            buttonVisitData.Location = new Point(52, 263);
            buttonVisitData.Name = "buttonVisitData";
            buttonVisitData.Size = new Size(190, 45);
            buttonVisitData.TabIndex = 14;
            buttonVisitData.Text = "Посещение";
            buttonVisitData.UseVisualStyleBackColor = true;
            buttonVisitData.Click += buttonVisitData_Click;
            // 
            // buttonAboutPayment
            // 
            buttonAboutPayment.Font = new Font("Segoe UI", 13.8F);
            buttonAboutPayment.Location = new Point(52, 123);
            buttonAboutPayment.Name = "buttonAboutPayment";
            buttonAboutPayment.Size = new Size(190, 45);
            buttonAboutPayment.TabIndex = 12;
            buttonAboutPayment.Text = "Платежи";
            buttonAboutPayment.UseVisualStyleBackColor = true;
            buttonAboutPayment.Click += buttonAboutPayment_Click;
            // 
            // buttonAboutMentors
            // 
            buttonAboutMentors.Font = new Font("Segoe UI", 13.8F);
            buttonAboutMentors.Location = new Point(52, 194);
            buttonAboutMentors.Name = "buttonAboutMentors";
            buttonAboutMentors.Size = new Size(190, 45);
            buttonAboutMentors.TabIndex = 11;
            buttonAboutMentors.Text = "Воспитатели";
            buttonAboutMentors.UseVisualStyleBackColor = true;
            buttonAboutMentors.Click += buttonAboutMentors_Click;
            // 
            // buttonAboutGroups
            // 
            buttonAboutGroups.Font = new Font("Segoe UI", 13.8F);
            buttonAboutGroups.Location = new Point(52, 50);
            buttonAboutGroups.Name = "buttonAboutGroups";
            buttonAboutGroups.Size = new Size(190, 45);
            buttonAboutGroups.TabIndex = 10;
            buttonAboutGroups.Text = "Группы";
            buttonAboutGroups.UseVisualStyleBackColor = true;
            buttonAboutGroups.Click += buttonAboutGroups_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExit.Location = new Point(52, 330);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(190, 45);
            buttonExit.TabIndex = 17;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // MenuParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(308, 387);
            Controls.Add(buttonExit);
            Controls.Add(buttonVisitData);
            Controls.Add(buttonAboutPayment);
            Controls.Add(buttonAboutMentors);
            Controls.Add(buttonAboutGroups);
            Name = "MenuParent";
            Text = "MenuParent";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonVisitData;
        private Button buttonAboutPayment;
        private Button buttonAboutMentors;
        private Button buttonAboutGroups;
        private Button buttonExit;
    }
}