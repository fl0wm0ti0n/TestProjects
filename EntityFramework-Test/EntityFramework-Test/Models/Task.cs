using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Test.Models
{
    class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DueDate { get; set; } // Das Fragezeichen macht den Datentyp "nullable"
        public int StatusId { get; set; }
        public Status Status { get; set; } 
    }
}
