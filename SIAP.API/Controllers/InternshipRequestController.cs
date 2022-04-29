using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIAP.Application.Interfaces;
using SIAP.Infrastructure.Mapping.Dtos.Incomming;

namespace SIAP.API.Controllers
{
    public class InternshipRequestController : BaseController
    {
        public InternshipRequestController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        //POST
        [HttpPost]
        public async Task<IActionResult> Add(InternshipRequestInput internshipRequest)
        {
            //var interrequestout = await _unitOfWork.Hotel.Add(hotel);
            await _unitOfWork.CompleteAsync();
            //var hotelcreated = await _unitOfWork.Hotel.GetByIdHotel(hotelout.Id);
            return Ok();
        }
    }
}