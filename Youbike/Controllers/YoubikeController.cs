using Microsoft.AspNetCore.Mvc;
using Youbike.Models;
using Youbike.Services;

namespace Youbike.Controllers;

[ApiController]
[Route("controller")]
public class YoubikeController : ControllerBase
{
    private readonly IYoubikeService _youbikeService;

    public YoubikeController(IYoubikeService youbikeService)
    {
        _youbikeService = youbikeService;
    }

    [HttpGet]
    [Route("List")]
    public async Task<List<YoubikeData>> GetStation()
    {
        List<YoubikeData> youbikeDatas = await _youbikeService.GetStation();

        return youbikeDatas;
    }

}