namespace PAD.Identity.Services;

public interface IScopeService
{
    Task<List<string>> ListResourcesAsync(ImmutableArray<string> scopes);
}