using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatrExampleServices.Models;

namespace MediatrExampleServices.Cars.Commands
{
    public class CreateCarCommand:IRequest<Response<Car>>
    {
    }

    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Response<Car>>
    {
        public Task<Response<Car>> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return Task.FromResult(Response.Fail<Car>("Car Already Exists"));
            }

            return Task.FromResult(Response.Ok(new Car {name = "ford"},"Car Created"));
        }
    }
}
