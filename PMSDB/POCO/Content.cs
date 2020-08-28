using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDB.POCO
{
    [Table("Content")]
    public class Content
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int TypeID { get; set; }
        public string Description { get; set; }
        public int? ParentID { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string ImageText { get; set; }

    }
}
