using System.Diagnostics;
using Newtonsoft.Json;
using Youbike.Models;

namespace Youbike.Services;

public class YoubikeService : IYoubikeService
{
    private readonly HttpClient _client;
    public Stages Stages;

    public YoubikeService(IHttpClientFactory factory)
    {
        if (factory == null) throw new ArgumentNullException(nameof(factory));
        _client = factory.CreateClient();
    }

    public async Task<List<YoubikeData>> GetStation()
    {
        var template = $"{nameof(Stages.執行)}";

        
        
        _client.BaseAddress = new Uri("https://data.ntpc.gov.tw");
        var response = await _client.GetAsync("/api/datasets/71cd1490-a2df-4198-bef1-318479775e8a/json?size=2");
        var content = await response.Content.ReadAsStringAsync();
        var stations = JsonConvert.DeserializeObject<List<YoubikeData>>(content);

        return stations ?? throw new InvalidOperationException();
    }
}

