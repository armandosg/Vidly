using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        // GET /rentals
        public IHttpActionResult GetRentals()
        {
            return Ok();
        }

        // GET /rentals/1
        public IHttpActionResult GetRental(int id)
        {
            return Ok();
        }

        // POST /rentals
        [HttpPost]
        public IHttpActionResult CreateRental(RentalDto rentalDto)
        {
            return Ok();
        }

        // PUT /rentals/1
        [HttpPut]
        public IHttpActionResult UpdateRental(int id)
        {
            return Ok();
        }

        // DELETE /rentals/1
        [HttpDelete]
        public IHttpActionResult DeleteRental(int id)
        {
            return Ok();
        }
    }
}
