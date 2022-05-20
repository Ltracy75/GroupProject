﻿using System.ComponentModel.DataAnnotations;

namespace GroupProjectLibrary
    {
    public class Work   
        {
        public int Id { get; set; } = 0;

        public int ProjectId { get; set; } = 0;

        public int ResourceID { get; set; } = 0;
        [StringLength(100)]
        public string Description { get; set; } = null!;

        public int Hours { get; set; } = 0;

        }
    }