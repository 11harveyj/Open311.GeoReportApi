using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Open311.GeoReportV2.Controllers
{
    [Route("api/v2")]
    [ApiController]
    public class Open311Controller : ControllerBase
    {
        [HttpGet]
        [Route("services.{format}")]
        public ActionResult GetServices(string format)
        {
            Open311.GeoReport.Structures.ServiceRequests serviceRequests = new GeoReport.Structures.ServiceRequests();
            serviceRequests.request = new GeoReport.Structures.ServiceRequest.Root[1];
            serviceRequests.request[1].service_name = "test";
            return Ok(serviceRequests);
        }

        [HttpGet]
        [Route("services/{service_code}.{format}")]
        public ActionResult GetServiceDefinition(string service_code, string format)
        {
            Open311.GeoReport.Structures.Service.ServiceDefinition serviceDefinition = new GeoReport.Structures.Service.ServiceDefinition();
            return Ok(serviceDefinition);
        }

        [HttpPost]
        [Route("requests.{format}")]
        public ActionResult PostServiceRequest([FromQuery] Open311.GeoReport.Structures.ServiceRequest.Root serviceRequest)
        {
            Open311.GeoReport.Structures.NewServiceRequestResponse serviceRequestResponse = new GeoReport.Structures.NewServiceRequestResponse();
            serviceRequestResponse.request = new GeoReport.Structures.ServiceRequest.New[1];
            serviceRequestResponse.request[1].service_request_id = "1234";
            return Ok(serviceRequestResponse);
        }

        [HttpGet]
        [Route("tokens/{token_id}.{format}")]
        public ActionResult GetServiceRequestFromToken(string token_id, string format)
        {
            return NoContent();
        }

        [HttpGet]
        [Route("requests.{format}")]
        public ActionResult GetServiceRequests(string format)
        {
            Open311.GeoReport.Structures.ServiceRequests serviceRequests = new GeoReport.Structures.ServiceRequests();
            return Ok(serviceRequests);
        }

        [HttpGet]
        [Route("requests/{request_id}.{format}")]
        public ActionResult GetServiceRequest(string request_id, string format)
        {
            return Ok();
        }



    }
}
