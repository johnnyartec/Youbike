using Youbike.Models;

namespace Youbike.Services;

public interface IYoubikeService
{
    Task<List<YoubikeData>> GetStation();
}