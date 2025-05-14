using Newtonsoft.Json;
using System.Data.OleDb;
using System.Net;

namespace KursachProject
{
    public partial class FormAuthorization : Form
    {
        private const string _settingsFilePath = "../../../settings.json";

        private readonly string _connectionString;
        public FormAuthorization()
        {
            _connectionString = ReadFromConfiguration();

            InitializeComponent();
        }

        private string ReadFromConfiguration()
        {
            string configurationString = File.ReadAllText(_settingsFilePath);

            if (string.IsNullOrEmpty(configurationString))
            {
                MessageBox.Show("Отсутствует строка соединения!", "Ошибка!");
                Close();

                return null;
            }
            else
            {
                var config = JsonConvert.DeserializeObject<Dictionary<string, object>>(configurationString);
                
                return config["ConnectionString"] as string;
            }
        }
        private void Login_Click(object sender, EventArgs e)
        {
            string enteredLogin = textBoxLogin.Text;
            string enteredPassword = textBoxPassword.Text;

            if (string.IsNullOrEmpty(enteredLogin) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Ошибка: поля не должны быть пустыми.");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT 'Admin' AS UserType FROM AdminData WHERE login = @login AND password = @password
                UNION ALL
                SELECT 'Parent' FROM ParentsData WHERE login = @login AND password = @password
                UNION ALL
                SELECT 'Mentor' FROM MentorsData WHERE login = @login AND password = @password";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", enteredLogin);
                        command.Parameters.AddWithValue("@password", enteredPassword);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string userType = reader["UserType"].ToString();
                                switch (userType)
                                {
                                    case "Admin":
                                        OpenMenu(new MenuZaveduyushchiy(_connectionString));
                                        break;
                                    case "Parent":
                                        OpenMenu(new MenuParent(_connectionString));
                                        break;
                                    case "Mentor":
                                        OpenMenu(new MenuMentor(_connectionString));
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ошибка: неверный логин или пароль.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
            }
        }
        private void OpenMenu(Form menuForm)
        {
            Visible = false;
            menuForm.ShowDialog();

            if (menuForm.DialogResult == DialogResult.Cancel)
            {
                Visible = true;
            }

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
