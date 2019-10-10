using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TaskModel
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CratedDate { get; private set; }
    }
}
