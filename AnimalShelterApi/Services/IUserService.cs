public interface IUriService
{
  public Uri GetPageUri(PaginationFilter filter, string route);
  {
    private readonly string _baseUri;
    public UriService(string baseUri)
    {
      _baseUri = baseUri;
    }
    var _enpointUri = new Uri(string.Concat(_baseUri, route));
    var modifiredUri = QueryHelpers.AddQueryString(_enpointUri.ToString(), "pageNumber", filter.PageSize.ToString());
    return new Uri(modified Uri);
  }
}