using Rickandmorty.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rickandmorty.Contracts.Services
{
    public interface IRickMortyService
    {
        Task<List<PersonFullInformationDto>> GetPersonsFullInformationAsync(string name);
        Task<bool> GetCheckPersonAsync(CheckPersonDto letter);
        Task<bool> SaveEpisodesAsync();
        int GetEpisodes(string episodeName);
    }
}
