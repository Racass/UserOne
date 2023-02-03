using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserCreatorJsonModel
    {
        public List<UserFieldModel>? UserFields { get; set; }
        public List<UserTableModel>? UserTables { get; set; }
        public List<UserObjectModel>? UserObjects { get; set; }
    }
}
