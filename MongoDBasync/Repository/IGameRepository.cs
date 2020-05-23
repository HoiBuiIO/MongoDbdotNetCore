using MongoDBasync.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBasync.Repository
{
    public interface IGameRepository
    {
        Task<IEnumerable<Game>> GetAllGames();
        Task<Game> GetGame(string name);
        Task Create(Game game);
        Task<bool> Update(Game game);
        Task<bool> Delete(string name);

    }
}