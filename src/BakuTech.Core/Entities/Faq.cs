namespace BakuTech.Core.Entities;

public class Faq : BaseEntity
{
    public string QuestionAz { get; set; } = null!;
    public string QuestionEn { get; set; } = null!;
    public string QuestionRu { get; set; } = null!;

    public string AnswerAz { get; set; } = null!;
    public string AnswerEn { get; set; } = null!;
    public string AnswerRu { get; set; } = null!;

    public int DisplayOrder { get; set; }
}
