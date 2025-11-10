using System;
using Concurseiro.Domain.Entities;

namespace Concurseiro.Application.DTOs;

public record QuestionFilterDto(
    Guid? BankId,
    Guid? SubjectId,
    Guid? TopicId,
    QuestionLevel? Level,
    QuestionType? Type,
    int Page = 1,
    int PageSize = 20);
