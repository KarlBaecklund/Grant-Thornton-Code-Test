using Newtonsoft.Json;
namespace Grant_Thornton;

public class Palindrome
{
    public async Task<string> GetPalindrome(string query)
    {
        var result = "";
        
        var response = await GetRespond(query);
        if (!response.IsSuccessStatusCode)
        {
            throw new InvalidOperationException($"got response code: {response.StatusCode}");
        }
        
        var content = await response.Content.ReadAsStringAsync();
        string[] values = JsonConvert.DeserializeObject<string[]>(content) ?? [];

        if (values == null)
        {
            throw new InvalidOperationException($"got null values");
        }
        
        foreach (var word in values)
        {
            result += word + " " + GetStatus(word) + "\n";
        }
        return result;
    }

    public async Task<HttpResponseMessage> GetRespond(string query)
    {
        var baseUrl =   $"https://gt-code-test.azurewebsites.net/api/get/Karl?code={query}";
        var client = new HttpClient();
        var response = await client.GetAsync(baseUrl);

        return response;
    }
    public bool GetStatus(string myString)
    {
        myString = myString.ToLower();
        var first = myString.Substring(0, myString.Length / 2);
        var arr   = myString.ToCharArray();

        Array.Reverse(arr);

        var temp   = new string(arr);
        var second = temp.Substring(0, temp.Length / 2);

        return first.Equals(second);
    }
}