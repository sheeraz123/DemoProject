using AutoMapper;
using MediatR;
using OEM.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Application.Features.OEMCampaigns.Queries.GetOEMCompaign
{
    public class GetOEMCampaignListHandler : IRequestHandler<GetOEMCampaignListQuery, List<OEMCampaignVM>>
    {
        private readonly IOEMRepository _oEMRepository;
        private readonly IMapper _mapper;
        public GetOEMCampaignListHandler(IOEMRepository oEMRepository, IMapper mapper)
        {
            this._oEMRepository = oEMRepository ?? throw new ArgumentNullException(nameof(oEMRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
        }

        public async Task<List<OEMCampaignVM>> Handle(GetOEMCampaignListQuery request, CancellationToken cancellationToken)
        {
            var oemCampaignList = await _oEMRepository.GetOEMCampaigns(request.RegionId);
            return _mapper.Map<List<OEMCampaignVM>>(oemCampaignList);
        }
    }
}
