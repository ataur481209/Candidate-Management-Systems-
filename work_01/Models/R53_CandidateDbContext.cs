using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace work_01.Models
{
    public partial class R53_CandidateDbContext : DbContext
    {
        public R53_CandidateDbContext()
        {
        }

        public R53_CandidateDbContext(DbContextOptions<R53_CandidateDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidate> Candidates { get; set; } = null!;
        public virtual DbSet<CandidateSkill> CandidateSkills { get; set; } = null!;
        public virtual DbSet<Skill> Skills { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=DESKTOP-FGQ7142;Database=R53_CandidateDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.Property(e => e.CandidateName).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CandidateSkill>(entity =>
            {
                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateSkills)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Candidate__Candi__3B75D760");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.CandidateSkills)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK__Candidate__Skill__3C69FB99");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.SkillName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
