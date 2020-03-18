using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ModelCodeFirst
{
    public class ModelSelfReferences : DbContext
    {
        public ModelSelfReferences() : base("name=ModelSelfReferences") { }
        public virtual DbSet<SelfReference> SelfReferences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SelfReference>()
            .HasMany(m => m.References)
            .WithOptional(m => m.ParentSelfReference);
        }
    }

    public class SelfReference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SelfReferenceId { get; private set; }
        public string Name { get; set; }
        public int? ParentSelfReferenceId { get; private set; }
        [ForeignKey("ParentSelfReferenceId")]
        public SelfReference ParentSelfReference { get; set; }
        public virtual ICollection<SelfReference> References { get; set; }
        public SelfReference()
        {
            References = new HashSet<SelfReference>();
        }
    }
}

