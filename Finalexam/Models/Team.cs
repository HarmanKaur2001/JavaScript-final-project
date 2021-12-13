namespace Finalexam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Team
    {
        public int TeamID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name  = "Team")]
        public string Name { get; set; }

        [Display(Name = "GP")]

        public int? Games { get; set; }
        [Display(Name = "W")]
        public int? Wins { get; set; }
        [Display(Name = "L")]
        public int? Losses { get; set; }
        [Display(Name = "OL")]
        public int? OvertimeLosses { get; set; }
        [Display(Name = "Pts")]
        public int? Points { get; set; }

        public int DivisionID { get; set; }

        [StringLength(100)]
        public string Logo { get; set; }

        public virtual Division Division { get; set; }
    }
}
