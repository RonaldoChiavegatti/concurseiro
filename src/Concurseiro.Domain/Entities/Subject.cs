using System;

namespace Concurseiro.Domain.Entities;

public class Subject
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
}
