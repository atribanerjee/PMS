using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDB.POCO
{
    [Table("Type")]
    public class Type
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime InserDate { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
