using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessProject.Data
{
    public class Gym
    {
        [Key]
        public int Gym_id { get; set; }

        [Required]
        public String Name { get; set; }

        public bool Is_deleted { get; set; } = false;
    }
}
