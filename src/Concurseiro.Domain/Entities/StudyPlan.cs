using System;

namespace Concurseiro.Domain.Entities;

public class StudyPlan
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Name { get; set; } = "Plano Principal";
    public Guid? TargetExamId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
