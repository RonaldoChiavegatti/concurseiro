using System;

namespace Concurseiro.Domain.Entities;

public class UserProfile
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string? MainExamArea { get; set; }
    public int StudyHoursPerWeek { get; set; }
    public int TimeUntilMainExamMonths { get; set; }
    public string? PreferredBanks { get; set; }
    public string? SelfAssessmentJson { get; set; }
}
