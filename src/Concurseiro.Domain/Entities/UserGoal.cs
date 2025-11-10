using System;

namespace Concurseiro.Domain.Entities;

public enum GoalType
{
    Hours,
    Questions
}

public enum GoalPeriod
{
    Weekly,
    Monthly
}

public class UserGoal
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public GoalType GoalType { get; set; }
    public int TargetValue { get; set; }
    public GoalPeriod Period { get; set; } = GoalPeriod.Weekly;
    public int CurrentValue { get; set; }
    public string? Status { get; set; }
}
