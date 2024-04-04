using Newtonsoft.Json;
namespace Grant_Thornton;

public class Palindrome
{
    public async Task<string> GetPalindrome(string query)
    {
        var result = "";
        // var baseUrl = "https://gt-code-test.azurewebsites.net/api/get/Karl?code=DRuQSdrjDG_syswkTpRhz2l0wt_tDoOmFTGLhCCni_MDAzFuYF6Bkg==";
        // var client = new HttpClient();
        var response = await GetRespond(query);
        if (!response.IsSuccessStatusCode)
        {
            throw new InvalidOperationException($"got response code: {response.StatusCode}");
        }
        // Read the content asynchronously and display it
        var content = await response.Content.ReadAsStringAsync();
        string[] values = JsonConvert.DeserializeObject<string[]>(content);
        
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