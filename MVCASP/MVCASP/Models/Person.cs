using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCASP.Models
{
    public class Person{
        // Our first data model
        [Key]
        public int Id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
    }
}
