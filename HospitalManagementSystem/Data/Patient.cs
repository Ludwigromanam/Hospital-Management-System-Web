﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace HospitalManagementSystem.Data
{
    using System.ComponentModel.DataAnnotations;
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Range(1,120)]
        public int Age { get; set; }

        [Required]
        public GenderOption Gender { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        public string Condition { get; set; }

        [Required]
        public StatusOption Status { get; set; }

        [Required]
        public int Room { get; set; }

        [Required]
        public string DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

    }
}