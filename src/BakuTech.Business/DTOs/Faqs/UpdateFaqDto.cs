using System.ComponentModel.DataAnnotations;

namespace BakuTech.Business.DTOs.Faqs;

public class UpdateFaqDto
{
    public int Id { get; set; }

    [Required]
    public string QuestionAz { get; set; } = null!;

    public string QuestionEn { get; set; } = null!;

    public string QuestionRu { get; set; } = null!;

    [Required]
    public string AnswerAz { get; set; } = null!;

    public string AnswerEn { get; set; } = null!;

    public string AnswerRu { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public bool IsActive { get; set; }
}
