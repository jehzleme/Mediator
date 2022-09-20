using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediatorFromScratch
{
    public interface IMediator
    {
        Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request);
    }
}
