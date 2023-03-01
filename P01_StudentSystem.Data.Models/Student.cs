namespace P01_StudentSystem.Data.Models
{
	using Microsoft.EntityFrameworkCore;
	using P01_StudentSystem.Data.Common;
	using System.ComponentModel.DataAnnotations;

	public class Student
	{
		public Student()
		{
			this.Homeworks = new HashSet<Homework>();
			this.StudentsCourses = new HashSet<StudentCourse>();
		}

		[Key]
		public int StudentId { get; set; }

		[Required]
		[MaxLength(GlobalConstants.STUDENT_NAME_MAX_LENGTH)]
		public string Name { get; set; } = null!;

		[Unicode(false)]
		[MaxLength(GlobalConstants.STUDENT_PHONE_NUMBER_MAX_LENGTH)]
		public string? PhoneNumber { get; set; }

		public DateTime RegisteredOn { get; set; }

		public DateTime? Birthday { get; set; }

		public virtual ICollection<Homework> Homeworks { get; set; }

		public virtual ICollection<StudentCourse> StudentsCourses { get; set; }
	}
}