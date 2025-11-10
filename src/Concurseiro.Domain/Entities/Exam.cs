using System;

namespace Concurseiro.Domain.Entities;

public class Exam
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Area { get; set; }
    public Guid? BankId { get; set; }
    public string? Level { get; set; }
    public DateTime? Date { get; set; }
    public bool IsActive { get; set; } = true;
}
