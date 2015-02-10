namespace SBWebsite.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SBWebsite.Migrations;

    public partial class Data : DbContext
    {
        public Data()
            : base("name=DataContext")
        {
          
        }

        public virtual DbSet<ACCOUNT> ACCOUNTS { get; set; }
        public virtual DbSet<APPLICANT> APPLICANTS { get; set; }
        public virtual DbSet<EMPLOYER> EMPLOYERs { get; set; }
        public virtual DbSet<JOB_APPLICANTS> JOB_APPLICANTS { get; set; }
        public virtual DbSet<JOB_CATEGORIES> JOB_CATEGORIES { get; set; }
        public virtual DbSet<JOB> JOBS { get; set; }
        public virtual DbSet<ROLE> ROLES { get; set; }
        public virtual DbSet<SKILL> SKILLS { get; set; }
        public virtual DbSet<STAFF> STAFFS { get; set; }
        public virtual DbSet<SUGGESTION> SUGGESTIONS { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TIME> TIMEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .HasOptional(e => e.APPLICANT)
                .WithRequired(e => e.ACCOUNT);

            modelBuilder.Entity<ACCOUNT>()
                .HasOptional(e => e.EMPLOYER)
                .WithRequired(e => e.ACCOUNT);

            modelBuilder.Entity<ACCOUNT>()
                .HasOptional(e => e.STAFF)
                .WithRequired(e => e.ACCOUNT);

            modelBuilder.Entity<APPLICANT>()
                .HasMany(e => e.JOB_APPLICANTS)
                .WithRequired(e => e.APPLICANT)
                .HasForeignKey(e => e.USER_APPLICANT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPLICANT>()
                .HasMany(e => e.SUGGESTIONS)
                .WithRequired(e => e.APPLICANT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPLICANT>()
                .HasMany(e => e.JOB_CATEGORIES)
                .WithMany(e => e.APPLICANTS)
                .Map(m => m.ToTable("APPLICANT_CATEGORIES").MapLeftKey("USER_NAME").MapRightKey("JOB_CATEGORY_SEQ"));

            modelBuilder.Entity<APPLICANT>()
                .HasMany(e => e.TIMEs)
                .WithMany(e => e.APPLICANTS)
                .Map(m => m.ToTable("APPLICANT_FREETIME").MapLeftKey("USER_NAME").MapRightKey("TIME_SEQ"));

            modelBuilder.Entity<APPLICANT>()
                .HasMany(e => e.SKILLS)
                .WithMany(e => e.APPLICANTS)
                .Map(m => m.ToTable("APPLICANTS_SKILLS").MapLeftKey("USER_NAME").MapRightKey("SKILL_SEQ"));

            modelBuilder.Entity<EMPLOYER>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER>()
                .Property(e => e.DESCRIPTIONS)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYER>()
                .HasMany(e => e.JOBS)
                .WithRequired(e => e.EMPLOYER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JOB_CATEGORIES>()
                .HasMany(e => e.JOBS)
                .WithMany(e => e.JOB_CATEGORIES)
                .Map(m => m.ToTable("JOBCATEGORIES_JOBS").MapLeftKey("JOB_CATEGORY_SEQ").MapRightKey("JOB_SEQ"));

            modelBuilder.Entity<JOB>()
                .HasMany(e => e.JOB_APPLICANTS)
                .WithRequired(e => e.JOB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JOB>()
                .HasMany(e => e.SUGGESTIONS)
                .WithRequired(e => e.JOB)
                .HasForeignKey(e => e.JOBS_SEQ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JOB>()
                .HasMany(e => e.TIMEs)
                .WithMany(e => e.JOBS)
                .Map(m => m.ToTable("JOBS_TIME").MapLeftKey("JOB_SEQ").MapRightKey("TIME_SEQ"));

            modelBuilder.Entity<JOB>()
                .HasMany(e => e.SKILLS)
                .WithMany(e => e.JOBS)
                .Map(m => m.ToTable("SKILLS_JOBS").MapLeftKey("JOB_SEQ").MapRightKey("SKILL_SEQ"));

            modelBuilder.Entity<ROLE>()
                .HasMany(e => e.ACCOUNTS)
                .WithRequired(e => e.ROLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STAFF>()
                .HasMany(e => e.EMPLOYERs)
                .WithOptional(e => e.STAFF)
                .HasForeignKey(e => e.STAFF_APPROVE)
                .WillCascadeOnDelete();
        }
    }
}
