namespace P01_StudentSystem.Data.Models
{
	using Microsoft.EntityFrameworkCore;
	using P01_StudentSystem.Data.Common;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Resource
	{
		[Key]
		public int ResourceId { get; set; }

		[Required]
		[MaxLength(GlobalConstants.RESOURCE_NAME_MAX_LENGTH)]
		public string Name { get; set; } = null!;

		[Required]
		[Unicode(false)]
		[MaxLength(GlobalConstants.RESOURCE_URL_MAX_LENGTH)]
		public string Url { get; set; } = null!;

		public ResType ResourceType { get; set; }

		[ForeignKey(nameof(Course))]
		public int CourseId { get; set; }
		public Course Course { get; set; } = null!;
	}
}
