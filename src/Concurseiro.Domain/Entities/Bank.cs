using System;

namespace Concurseiro.Domain.Entities;

public class Bank
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
}
