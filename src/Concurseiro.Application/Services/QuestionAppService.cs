using System.Linq;
using System.Threading.Tasks;
using Concurseiro.Application.DTOs;
using Concurseiro.Domain.Interfaces;

namespace Concurseiro.Application.Services;

public class QuestionAppService
{
    private readonly IQuestionRepository _repository;

    public QuestionAppService(IQuestionRepository repository) => _repository = repository;

    public async Task<PagedResult<object>> SearchAsync(QuestionFilterDto filter)
    {
        var (items, total) = await _repository.SearchAsync(
            filter.BankId,
            filter.SubjectId,
            filter.TopicId,
            filter.Level,
            filter.Type,
            filter.Page,
            filter.PageSize);

        var mapped = items
            .Select(q => new
            {
                q.Id,
                q.Statement,
                q.Level,
                q.Type,
                q.SubjectId,
                q.TopicId
            })
            .Cast<object>()
            .ToList();

        return new PagedResult<object>(mapped, total, filter.Page, filter.PageSize);
    }
}
