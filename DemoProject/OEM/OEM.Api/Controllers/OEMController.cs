using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OEM.Application.Features.OEMCampaigns.Queries;
using OEM.Application.Features.OEMCampaigns.Queries.GetOEMCompaign;
using System.Net;

namespace OEM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OEMController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OEMController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{regionId}", Name = "GetOEMCampaignList")]
        [ProducesResponseType(typeof(IEnumerable<OEMCampaignVM>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<OEMCampaignVM>>> GetOEMCampaignAll(string regionId)
        {
            var query = new GetOEMCampaignListQuery(regionId);
            var oemCampaignList = await _mediator.Send(query);
            return Ok(oemCampaignList);
        }
    }
}
