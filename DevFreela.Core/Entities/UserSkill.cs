using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class UserSkill : BaseEntity
    {
        public string IdUser { get; private set; }
        public int IdSkill { get; private set; }
    }
}
