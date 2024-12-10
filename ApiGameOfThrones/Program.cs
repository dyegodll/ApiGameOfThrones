using ApiGameOfThrones.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        for(int i = 1; i < 100; i++)
        {
            string json = await client.GetStringAsync($"https://www.anapioficeandfire.com/api/characters/{i}");
            var obj = JsonSerializer.Deserialize<Character>(json)!;

            if( obj.Name != null && !obj.Name.Equals("") )
            {
                obj.InfoCharacter();
            }
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}