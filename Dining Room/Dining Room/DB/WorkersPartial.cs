using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dining_Room.DB
{
    partial class Workers
    {
        public string fullName
        {
            get
            {
                return Surname + " " + Name + " " + Patronymic + "; Должность - " + Post;
            }
        }

        public string secondFullName
        {
            get
            {
                return Surname + " " + Name + " " + Patronymic;
            }
        }
    }
}
