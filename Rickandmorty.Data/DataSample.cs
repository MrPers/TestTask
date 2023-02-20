using Microsoft.Extensions.DependencyInjection;
using Rickandmorty.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rickandmorty.Logic
{
    public class DataSample
    {
        public static async Task InitializeAsync(IServiceScope serviceScope)
        {

            IServiceProvider scopeServiceProvider = serviceScope.ServiceProvider;
            var _rickMortyService = scopeServiceProvider.GetRequiredService<IRickMortyService>();

            await _rickMortyService.SaveEpisodesAsync();

        }
    }
}
