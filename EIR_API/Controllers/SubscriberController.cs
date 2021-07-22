using EIR_BusinessLayer.Interface;
using EIR_BusinessLayer.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EIR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberController : ControllerBase
    {
        private readonly ISubscriberService _subscriberService;

        public SubscriberController(ISubscriberService subscriberService)
        {
            _subscriberService = subscriberService;
        }
        [HttpGet("/CheckMSISDN", Name = "CheckMSISDN")]
        public async Task<IActionResult> CheckMSISDN(string IMEI, string IMSI)
        {
            var isValidated = await _subscriberService.CheckMSISDN(IMEI, IMSI);
            return Ok(isValidated);
        }
        [HttpGet("/CheckMSISDNbyObj", Name = "CheckMSISDNbyObj")]
        public async Task<IActionResult> CheckMSISDNbyObj(EIR_DomainModels.Black_List black)
        {
            var isValidated = await _subscriberService.CheckMSISDN("", "");
            return Ok(isValidated);
        }
    }
}
