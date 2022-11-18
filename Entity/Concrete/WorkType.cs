using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class WorkType
    {
        [Key]
        public int WorkTypeId { get; set; }
        public string WorkTypeName { get; set; }
        //public virtual Job Job { get; set; }
    }
}
