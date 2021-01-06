﻿using Planner.Shared.Enums;
using Planner.Shared.Models;
using Planner.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Planner.UI.RestServices
{
    public class RegionService : IRestService<RegionDTO>
    {
        private readonly HttpClient _client;

        public RegionService(HttpClient client)
        {
            _client = client;
        }

        public Task<IEnumerable<RegionDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<RegionDTO> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RegionDTO> PostAsync(RegionDTO region)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseResultEnum> PutAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseResultEnum> DeleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
