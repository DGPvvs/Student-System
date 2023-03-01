namespace P01_StudentSystem.Data
{
	using Microsoft.EntityFrameworkCore;
	using P01_StudentSystem.Data.Models;

	public class StudentSystemContext : DbContext
	{
		public StudentSystemContext()
		{

		}

		public StudentSystemContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Course> Courses { get; set; } = null!;

		public DbSet<Homework> Homeworks { get; set; } = null!;

		public DbSet<Resource> Resources { get; set; } = null!;

		public DbSet<Student> Students { get; set; } = null!;

		public DbSet<StudentCourse> StudentsCourses { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(Config.CONNECTION_STRING);
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<StudentCourse>(sc =>
			{
				sc.HasKey(e => new { e.StudentId, e.CourseId });
			});
		}

	}
}