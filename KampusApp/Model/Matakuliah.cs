using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KampusApp.Model
{
    public class Matakuliah
    {
        [Key]
        public int IDMatakuliah { get; set; }

        [Required]
        public string NamaMatakuliah { get; set; }

        [Required]
        public int SKS { get; set; }
    }
}
