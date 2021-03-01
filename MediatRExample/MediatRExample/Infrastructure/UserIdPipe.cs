using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatrExampleServices;
using Microsoft.AspNetCore.Http;

namespace MediatRExample.Infrastructure
{
    public class UserIdPipe<TIn,TOut>:IPipelineBehavior<TIn,TOut>
    {
        private HttpContext httpContext;

        public UserIdPipe(IHttpContextAccessor accessor)
        {
            httpContext = accessor.HttpContext;
        }

        public Task<TOut> Handle(TIn request, CancellationToken cancellationToken, RequestHandlerDelegate<TOut> next)
        {
            //var claim = httpContext.User.Claims.FirstOrDefault(x => x.Type.Equals(ClaimTypes.NameIdentifier))
            //    .Value;

            if (request is BaseRequest br)
            {
                br.UserId = "1234";
            }

            return next();
        }
    }
}
