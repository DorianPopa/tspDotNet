using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Laborator5
{
    public class PhotographContext : DbContext
    {
        public DbSet<Photograph> Photographs { get; set; }
        public DbSet<PhotographFullImage> PhotographFullImages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photograph>()
            .HasRequired(p => p.PhotographFullImage)
            .WithRequiredPrincipal(p => p.Photograph);
            modelBuilder.Entity<Photograph>()
            .ToTable("Photograph", "BazaDeDate");
            modelBuilder.Entity<PhotographFullImage>()
            .ToTable("Photograph", "BazaDeDate");
        }
    }

    public class Photograph
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhotoId { get; set; }
        public string Title { get; set; }
        public byte[] ThumbnailBits { get; set; }
        [ForeignKey("PhotoId")]
        public virtual PhotographFullImage PhotographFullImage { get; set; }
    }

    public class PhotographFullImage
    {
        [Key]
        public int PhotoId { get; set; }
        public byte[] HighResolutionBits { get; set; }
        [ForeignKey("PhotoId")]
        public virtual Photograph Photograph { get; set; }
    }
}
