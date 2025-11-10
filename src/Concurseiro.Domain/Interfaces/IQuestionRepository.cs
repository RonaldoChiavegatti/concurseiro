using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Concurseiro.Domain.Entities;

namespace Concurseiro.Domain.Interfaces;

public interface IQuestionRepository
{
    Task<(IReadOnlyList<Question> Items, int Total)> SearchAsync(
        Guid? bankId,
        Guid? subjectId,
        Guid? topicId,
        QuestionLevel? level,
        QuestionType? type,
        int page,
        int pageSize);
}
