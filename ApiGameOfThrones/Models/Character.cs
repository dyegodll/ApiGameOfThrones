using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApiGameOfThrones.Models;

internal class Character
{
    [JsonPropertyName("url")]
    public string Url { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }
    [JsonPropertyName("born")]
    public string? Born { get; set; }
    [JsonPropertyName("title")]
    public List<string>? Title { get; set; }
    [JsonPropertyName("aliases")]
    public List<string>? Aliases { get; set; }

    public void InfoCharacter()
    {
        Console.WriteLine($"☻ {Name} - {Url} ☻");
        
        if(Born != null && !Born.Equals("")) Console.WriteLine($"\t♦ Born: {Born}");
        
        if(Gender != null) Console.WriteLine($"\t♦ Gender: {Gender}");

        if (Title != null && Title.Count > 0) Console.WriteLine($"\t♦ Titles: {string.Join(", ", Title!)}");

        if (Aliases  != null && Aliases.Count > 0) Console.WriteLine($"\t♦ Aliases: {string.Join(", ", Aliases!)}");

        Console.WriteLine();
    }
}
