﻿using HospitalManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalManagementSystem.Models.Patients
{
    public class PatientsDetailsModel
    {
       
        public   int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Range(1, 120)]
        public int Age { get; set; }

        [Required]
        public GenderOption Gender { get; set; }

      
        public string ImagePath { get; set; }

        [Required]
        public string Condition { get; set; }

        [Required]
        public StatusOption Status { get; set; }

        [Required]
        public int Room { get; set; }

        public string Doctor { get; set; }

        [Required]
        public string DoctorId { get; set; }

        public bool IsAuthor(string name)
        {
            return this.DoctorId == name;
        }

    }
}