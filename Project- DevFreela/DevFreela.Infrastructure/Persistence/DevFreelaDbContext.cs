using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            new List<Project>
            {
                new Project("Project 1", "Description of project 1", 1, 2, 1000.00m),
                new Project("Project 2", "Description of project 2", 3, 4, 2000.00m),
                new Project("Project 3", "Description of project 3", 5, 6, 1500.00m)
            };
            new List<User>
            {
                new User("Luis felipe", "luisdev@", new DateTime(1995, 1, 1)),
                new User("Luis felipe", "luisdev@", new DateTime(1994, 1, 1)),
                new User("Luis felipe", "luisdev@", new DateTime(1993, 1, 1)),
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }

    }
}
