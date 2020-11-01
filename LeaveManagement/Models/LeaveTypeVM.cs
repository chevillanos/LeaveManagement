using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {        
        public int Id { get; set; }        
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
