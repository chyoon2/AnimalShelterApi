using System;

namespace PaginationRequirements
{
public interface IUriService
{
    public Uri GetPageUri(PaginationFilter filter, string route);
}
}