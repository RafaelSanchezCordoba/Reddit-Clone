namespace Shared.DTOs;

public class SearchPostParametersDto
{
    public string? Username { get; set; }
    public string? TitleContains { get; set; }
    
    public SearchPostParametersDto(string? username, string? titleContains)
    {
        Username = username;
        TitleContains = titleContains;
    }
}