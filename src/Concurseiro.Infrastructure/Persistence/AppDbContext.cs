using System;
using Concurseiro.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Concurseiro.Infrastructure.Persistence;

public class AppDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
{
    public DbSet<Bank> Banks => Set<Bank>();
    public DbSet<Subject> Subjects => Set<Subject>();
    public DbSet<Topic> Topics => Set<Topic>();
    public DbSet<Question> Questions => Set<Question>();
    public DbSet<UserQuestionResult> UserQuestionResults => Set<UserQuestionResult>();
    public DbSet<StudyPlan> StudyPlans => Set<StudyPlan>();
    public DbSet<StudySession> StudySessions => Set<StudySession>();
    public DbSet<Exam> Exams => Set<Exam>();
    public DbSet<Content> Contents => Set<Content>();
    public DbSet<ExamSchedule> ExamSchedules => Set<ExamSchedule>();
    public DbSet<UserGoal> UserGoals => Set<UserGoal>();
    public DbSet<UserProfile> UserProfiles => Set<UserProfile>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Bank>().Property(x => x.Name).IsRequired().HasMaxLength(120);
        builder.Entity<Subject>().Property(x => x.Name).IsRequired().HasMaxLength(120);
        builder.Entity<Topic>().Property(x => x.Name).IsRequired().HasMaxLength(160);
        builder.Entity<Question>().Property(x => x.Statement).IsRequired();
        builder.Entity<Question>().Property(x => x.CorrectAnswer).HasMaxLength(10);

        builder.Entity<UserProfile>().HasKey(x => x.Id);
    }
}
