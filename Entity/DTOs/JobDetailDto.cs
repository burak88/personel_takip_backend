using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public  class JobDetailDto
    {
        public int JobId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int WorkTypeId { get; set; }
        public string WorkTypeName { get; set; }
    }
}
