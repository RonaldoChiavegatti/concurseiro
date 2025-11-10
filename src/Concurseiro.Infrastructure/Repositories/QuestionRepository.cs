using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Concurseiro.Domain.Entities;
using Concurseiro.Domain.Interfaces;
using Concurseiro.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Concurseiro.Infrastructure.Repositories;

public class QuestionRepository : IQuestionRepository
{
    private readonly AppDbContext _dbContext;

    public QuestionRepository(AppDbContext dbContext) => _dbContext = dbContext;

    public async Task<(IReadOnlyList<Question> Items, int Total)> SearchAsync(
        Guid? bankId,
        Guid? subjectId,
        Guid? topicId,
        QuestionLevel? level,
        QuestionType? type,
        int page,
        int pageSize)
    {
        var query = _dbContext.Questions.AsNoTracking().AsQueryable();

        if (bankId.HasValue)
        {
            query = query.Where(q => q.BankId == bankId);
        }

        if (subjectId.HasValue)
        {
            query = query.Where(q => q.SubjectId == subjectId);
        }

        if (topicId.HasValue)
        {
            query = query.Where(q => q.TopicId == topicId);
        }

        if (level.HasValue)
        {
            query = query.Where(q => q.Level == level);
        }

        if (type.HasValue)
        {
            query = query.Where(q => q.Type == type);
        }

        var total = await query.CountAsync();

        var items = await query
            .OrderBy(q => q.SubjectId)
            .ThenBy(q => q.Level)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (items, total);
    }
}
