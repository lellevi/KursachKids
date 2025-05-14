namespace KursachProject
{
    partial class FormAuthorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxLogin = new TextBox();
            label3 = new Label();
            textBoxPassword = new TextBox();
            button1 = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(160, 36);
            label1.Name = "label1";
            label1.Size = new Size(464, 46);
            label1.TabIndex = 0;
            label1.Text = "Авторизация пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 117);
            label2.Name = "label2";
            label2.Size = new Size(72, 26);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(160, 169);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(239, 27);
            textBoxLogin.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(160, 235);
            label3.Name = "label3";
            label3.Size = new Size(82, 26);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(160, 283);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(239, 27);
            textBoxPassword.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(159, 359);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Login_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(287, 359);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // FormAuthorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(button1);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAuthorization";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxLogin;
        private Label label3;
        private TextBox textBoxPassword;
        private Button button1;
        private Button ExitButton;
    }
}
