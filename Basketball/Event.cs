namespace Basketball
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        public int Id { get; set; }

        public TimeSpan Time { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public decimal Point { get; set; }

        public int MatchId { get; set; }

        public int PlayerId { get; set; }

        public int JudgeId { get; set; }

        public virtual Judge Judge { get; set; }

        public virtual Match Match { get; set; }

        public virtual Player Player { get; set; }
    }
}
