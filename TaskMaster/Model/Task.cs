using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster.Model
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DueDate { get; set; }

        public int StatusId { get; set; }

        public Status Status { get; set; }
    }
}
