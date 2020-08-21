using System;

namespace PaginationRequirements
{
public interface IUriService
{
    Uri GetPageUri(PaginationFilter filter, string route);
}
}