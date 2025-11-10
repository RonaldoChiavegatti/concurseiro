using System;

namespace Concurseiro.Domain.Entities;

public enum ContentType
{
    Pdf,
    Video,
    Article
}

public class Content
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public ContentType ContentType { get; set; }
    public string UrlOrPath { get; set; } = default!;
    public Guid? SubjectId { get; set; }
    public Guid? TopicId { get; set; }
    public string? Level { get; set; }
}
