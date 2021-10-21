using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using IPLocation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net;
using System.Text;


namespace IPLocation.Controllers
{
    [Route("api/[controller]")]
    public class IPLocation : ControllerBase
    {
        //[HttpGet("{ip}")]
        public ActionResult<GeoLocationIP> GetUserLocationDetailsyByIp(string ip)
        {
            {
                ip = "121.45.86.171";
                GeoLocationIP ipInfo = new GeoLocationIP();
                try
                {                  
                    var info = new WebClient().DownloadString($"https://ipapi.co/121.45.86.171/city/");
                   
                    if (info != null)
                    {
                        ipInfo.City = info;
                                               
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return ipInfo;

                
            }
        }
    }
}
