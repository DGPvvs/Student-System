namespace P01_StudentSystem.Data.Models
{
	using Microsoft.EntityFrameworkCore;
	using P01_StudentSystem.Data.Common;
	using P01_StudentSystem.Data.Models.Enums;
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Homework
	{
		[Key]
		public int HomeworkId { get; set; }

		[Unicode(false)]
		[MaxLength(GlobalConstants.HOMEWORK_CONTENT_MAX_LENGTH)]
		public string Content { get; set; } = null!;

		public ContType ContentType { get; set; }

		public DateTime SubmissionTime { get; set; }

		[ForeignKey(nameof(Student))]
		public int StudentId { get; set; }

		public Student Student { get; set; } = null!;

		[ForeignKey(nameof(Course))]
		public int CourseId { get; set; }
		public Course Course { get; set; } = null!;
	}
}
