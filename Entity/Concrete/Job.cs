using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }

        public int UserId { get; set; }
        //public virtual  User User{ get; set; }

        public int WorkTypeId { get; set; }
        //public virtual WorkType WorkType { get; set; }




    }
}
