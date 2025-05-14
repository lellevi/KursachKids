using KursachProject.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachProject.Repositories
{
    public interface IRepository<TEntity>
    {
        public int Create(TEntity entity);
        public TEntity GetById(int id);
        public List<TEntity> GetAll();
        public void Update(TEntity entity);
        public void DeleteById(int id);
    }

    public class GroupSqlRepository : IRepository<GroupData>
    {
        private string connectionString { get; set; }

        public GroupSqlRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int Create(GroupData entity)
        {
            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                
                string query = "INSERT INTO [GroupData] ([name_of_group], [mentor_id], [count_of_kids]) " +
                            "VALUES (@NameOfGroup, @MentorId, @CountOfKids)";

                using (var command = new OleDbCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@NameOfGroup", entity.NameOfGroup);
                    command.Parameters.AddWithValue("@MentorId", entity.MentorId);
                    command.Parameters.AddWithValue("@CountOfKids", entity.CountOfKids);


                    command.ExecuteNonQuery();

                    string getIdQuery = "SELECT @@IDENTITY";
                    using (var getIdCommand = new OleDbCommand(getIdQuery, connection))
                    {
                        var result = getIdCommand.ExecuteScalar();
                        return Convert.ToInt32(result);
                    }
                }
            }
        }

        public GroupData GetById(int id)
        {
            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT [GroupData].[group_id], [GroupData].[name_of_group], [GroupData].[mentor_id], [GroupData].[count_of_kids] " +
                            "FROM [GroupData] WHERE [GroupData].[group_id] = @GroupId";

                using (var command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupId", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new GroupData
                            {
                                GroupId = Convert.ToInt32(reader["group_id"]),
                                NameOfGroup = reader["name_of_group"].ToString(),
                                MentorId = Convert.ToInt32(reader["mentor_id"]),
                                CountOfKids = Convert.ToInt32(reader["count_of_kids"])
                            };
                        }
                    }
                }
            }

            return null; 
        }

        public List<GroupData> GetAll()
        {
            var groups = new List<GroupData>();

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                
                string query = "SELECT [GroupData].[group_id], [GroupData].[name_of_group], [GroupData].[mentor_id], [GroupData].[count_of_kids] " +
                            "FROM [GroupData]";

                using (var command = new OleDbCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            groups.Add(new GroupData
                            {
                                GroupId = Convert.ToInt32(reader["group_id"]),
                                NameOfGroup = reader["name_of_group"].ToString(),
                                MentorId = Convert.ToInt32(reader["mentor_id"]),
                                CountOfKids = Convert.ToInt32(reader["count_of_kids"])
                            });
                        }
                    }
                }
            }

            return groups;
        }

        public void Update(GroupData entity)
        {
            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE [GroupData] SET [name_of_group] = @NameOfGroup, [mentor_id] = @MentorId, [count_of_kids] = @CountOfKids " +
                            "WHERE [group_id] = @GroupId";

                using (var command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NameOfGroup", entity.NameOfGroup);
                    command.Parameters.AddWithValue("@MentorId", entity.MentorId);
                    command.Parameters.AddWithValue("@CountOfKids", entity.CountOfKids);
                    command.Parameters.AddWithValue("@GroupId", entity.GroupId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteById(int id)
        {
            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM [GroupData] WHERE [group_id] = @GroupId";

                using (var command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupId", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
