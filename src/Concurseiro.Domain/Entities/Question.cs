using System;

namespace Concurseiro.Domain.Entities;

public enum QuestionLevel
{
    Easy = 0,
    Medium = 1,
    Hard = 2
}

public enum QuestionType
{
    Objective = 0,
    TrueFalse = 1,
    Discursive = 2,
    CaseStudy = 3
}

public class Question
{
    public Guid Id { get; set; }
    public Guid? BankId { get; set; }
    public Guid? ExamId { get; set; }
    public Guid SubjectId { get; set; }
    public Guid? TopicId { get; set; }
    public QuestionLevel Level { get; set; }
    public QuestionType Type { get; set; }
    public string Statement { get; set; } = default!;
    public string? AlternativesJson { get; set; }
    public string? CorrectAnswer { get; set; }
    public string? Comment { get; set; }
}
