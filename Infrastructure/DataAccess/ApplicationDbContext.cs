using Microsoft.EntityFrameworkCore;
using TournamentsApi.Domain.Models;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Player> Players { get; set; }
    public DbSet<Prediction> Predictions { get; set; }
    public DbSet<PredictionHistory> PredictionHistory { get; set; }
    public DbSet<PredictionPick> PredictionPicks { get; set; }
    public DbSet<Round> Rounds { get; set; }
    public DbSet<Score> Scores { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<TournamentPlayer> TournamentPlayers { get; set; }

    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<TournamentPlayer>()
            .HasKey(tp => new { tp.TournamentId, tp.PlayerId });

        b.Entity<Round>()
            .HasIndex(r => new { r.TournamentId, r.Number })
            .IsUnique();

        b.Entity<Score>()
            .HasIndex(s => new { s.RoundId, s.PlayerId })
            .IsUnique();

        b.Entity<PredictionPick>()
            .HasKey(p => new { p.PredictionId, p.PlayerId });  // evita duplicados

        base.OnModelCreating(b);
    }
}