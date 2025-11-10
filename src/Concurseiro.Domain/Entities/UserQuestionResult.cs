using System;

namespace Concurseiro.Domain.Entities;

public class UserQuestionResult
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid QuestionId { get; set; }
    public string? AnswerGiven { get; set; }
    public bool IsCorrect { get; set; }
    public int TimeSpentSeconds { get; set; }
    public DateTime AnsweredAt { get; set; } = DateTime.UtcNow;
}
