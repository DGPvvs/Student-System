namespace P01_StudentSystem.Data.Models
{
	using Microsoft.EntityFrameworkCore.Metadata.Internal;
	using P01_StudentSystem.Data.Common;
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Course
	{
		public Course()
		{
			this.StudentsCourses = new HashSet<StudentCourse>();
			this.Resources = new HashSet<Resource>();
			this.Homeworks = new HashSet<Homework>();
		}

		[Key]
		public int CourseId { get; set; }

		[Required]
		[MaxLength(GlobalConstants.COURSE_NAME_MAX_LENGTH)]
		public string Name { get; set; } = null!;


		public string Description { get; set; }

		[Required]
		public DateTime StartDate { get; set; }

		[Required]
		public DateTime EndDate { get; set; }

		public decimal Price { get; set; }

		public virtual ICollection<StudentCourse> StudentsCourses { get; set; }

		public virtual ICollection<Resource> Resources { get; set; }

		public virtual ICollection<Homework> Homeworks { get; set; }
	}
}
