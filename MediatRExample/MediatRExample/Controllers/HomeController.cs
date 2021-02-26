using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatrExampleServices.Cars.Queries;
using MediatrExampleServices.Models;

namespace MediatRExample.Controllers
{
    [ApiController]
    [Route("Cars")]
    public class HomeController : Controller
    {

        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<Car>> Index()
        {
            return _mediator.Send(new GetAllCarsQuery());
        }
    
    }
}
