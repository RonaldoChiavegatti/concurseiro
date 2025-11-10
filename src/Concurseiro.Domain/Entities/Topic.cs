using System;

namespace Concurseiro.Domain.Entities;

public class Topic
{
    public Guid Id { get; set; }
    public Guid SubjectId { get; set; }
    public string Name { get; set; } = default!;
}
