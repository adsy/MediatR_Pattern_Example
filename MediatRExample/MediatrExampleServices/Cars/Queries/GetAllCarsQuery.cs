using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatrExampleServices.Models;

namespace MediatrExampleServices.Cars.Queries
{
    // IRequest<T> -> T is the object type you want to return
    public class GetAllCarsQuery : IRequest<IEnumerable<Car>>
    {

    }

    public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IEnumerable<Car>>
    {
        // do dependency injection here if needed
        public GetAllCarsQueryHandler()
        {
                
        }

        public async Task<IEnumerable<Car>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            return new[]
            {
                new Car{name = "car1"},
                new Car{name = "car2"}
            };
        }
    }
}
