namespace Basketball
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Match")]
    public partial class Match
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Match()
        {
            Event = new HashSet<Event>();
        }

        public int Id { get; set; }

		public int Round { get; set; }

		public DateTime Date { get; set; }

		public bool IsFinished { get; set; }

		public int RequestId1 { get; set; }

        public int RequestId2 { get; set; }

        public int Score1 { get; set; }

        public int Score2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Event { get; set; }

        public virtual Request Request { get; set; }

        public virtual Request Request1 { get; set; }

    }
}
