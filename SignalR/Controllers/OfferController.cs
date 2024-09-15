using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Helpers;

namespace SignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        [HttpGet]
        public double Get()
        {
            return FileHelper.Read();
        }

        [HttpGet("Increase")]
        public void Increase(double data)
        {
            var result = FileHelper.Read() + data;
            FileHelper.Write(result);
        }
    }
}
