using Concurseiro.Application.DTOs;
using Concurseiro.Application.Services;
using Concurseiro.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Concurseiro.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuestionsController : ControllerBase
{
    private readonly QuestionAppService _service;

    public QuestionsController(QuestionAppService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> Get(
        [FromQuery] Guid? bankId,
        [FromQuery] Guid? subjectId,
        [FromQuery] Guid? topicId,
        [FromQuery] QuestionLevel? level,
        [FromQuery] QuestionType? type,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 20)
    {
        var filter = new QuestionFilterDto(bankId, subjectId, topicId, level, type, page, pageSize);
        var result = await _service.SearchAsync(filter);
        return Ok(result);
    }
}
