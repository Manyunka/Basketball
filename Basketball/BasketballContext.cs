namespace Basketball
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class BasketballContext : DbContext
	{
		public BasketballContext()
			: base("name=Basketball")
		{
		}

		public virtual DbSet<Event> Event { get; set; }
		public virtual DbSet<Judge> Judge { get; set; }
		public virtual DbSet<Match> Match { get; set; }
		public virtual DbSet<Player> Player { get; set; }
		public virtual DbSet<Request> Request { get; set; }
		public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }
		public virtual DbSet<Team> Team { get; set; }
		public virtual DbSet<Competition> Competition { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Event>()
				.Property(e => e.Point)
				.HasPrecision(1, 0);

			modelBuilder.Entity<Judge>()
				.HasMany(e => e.Event)
				.WithRequired(e => e.Judge)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Match>()
				.HasMany(e => e.Event)
				.WithRequired(e => e.Match)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Player>()
				.HasMany(e => e.Event)
				.WithRequired(e => e.Player)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Request>()
				.HasMany(e => e.Match)
				.WithRequired(e => e.Request)
				.HasForeignKey(e => e.RequestId1)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Request>()
				.HasMany(e => e.Match1)
				.WithRequired(e => e.Request1)
				.HasForeignKey(e => e.RequestId2)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Team>()
				.HasMany(e => e.Player)
				.WithRequired(e => e.Team)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Team>()
				.HasMany(e => e.Request)
				.WithRequired(e => e.Team)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Team>()
				.HasMany(e => e.Competition)
				.WithOptional(e => e.Team)
				.HasForeignKey(e => e.WinnerId);

			modelBuilder.Entity<Competition>()
				.HasMany(e => e.Request)
				.WithRequired(e => e.Competition)
				.HasForeignKey(e => e.TeamId)
				.WillCascadeOnDelete(false);
		}
	}
}
