using System;

namespace Concurseiro.Domain.Entities;

public enum SessionType
{
    Theory,
    Video,
    Questions,
    Review
}

public class StudySession
{
    public Guid Id { get; set; }
    public Guid StudyPlanId { get; set; }
    public DateTime DatePlanned { get; set; }
    public int DurationMinutes { get; set; } = 60;
    public SessionType SessionType { get; set; }
    public Guid? SubjectId { get; set; }
    public Guid? TopicId { get; set; }
    public Guid? ContentId { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? CompletedAt { get; set; }
}
