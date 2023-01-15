using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTalk.Services
{
    public interface IHttpClientService
    {
        public Task<T> Get<T>(string uri) where T : class;
        public Task<bool> Post<T>(T body, string uri) where T : class;
    }
}
