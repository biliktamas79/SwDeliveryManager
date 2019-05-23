using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ResourceMgr.Domain.Model
{
    public class EmployeeAvailability
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [Required]
        public DateTime FromUtc { get; set; }

        [Required]
        public DateTime UntilUtc { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public Employee Employee { get; set; }

        [Required]
        public Availability Availability { get; set; }
    }
}
