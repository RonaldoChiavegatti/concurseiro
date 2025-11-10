using System;

namespace Concurseiro.Domain.Entities;

public class ExamSchedule
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid? ExamId { get; set; }
    public DateTime ExamDate { get; set; }
    public string? Notes { get; set; }
}
