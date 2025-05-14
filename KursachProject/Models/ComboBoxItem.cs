using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachProject.Models
{
    public class ComboBoxItem
    {
        public int ID { get; set; } 
        public string Name { get; set; } 
    }

    public interface IBaseEntity
    {
        public int Id { get; set; }
    }

    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }

    public class GroupData : BaseEntity
    { 
        public int GroupId { get; set; }        // Связано с group_id (число)
        public string NameOfGroup { get; set; } // Связано с name_of_group (текст)
        public int MentorId { get; set; }       // Связано с mentor_id (число)
        public int CountOfKids { get; set; }    // Связано с count_of_kids (число)
    }
}
