using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using OEM.Application.Contracts.Persistence;
using OEM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Application.Features.OEMCampaigns.Commands.AddOEMCampaign
{
    public class AddOEMCampaignHandler : IRequestHandler<AddOEMCommand, decimal>
    {
        private readonly IOEMRepository _oEMRepository;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        public AddOEMCampaignHandler(IOEMRepository oEMRepository, IMapper mapper, ILogger logger)
        {
            _oEMRepository = oEMRepository ?? throw new ArgumentNullException(nameof(oEMRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<decimal> Handle(AddOEMCommand request, CancellationToken cancellationToken)
        {
            var oemEntity = _mapper.Map<OEMCampaign>(request);
            var newOEMEntity = _oEMRepository.AddAsync(oemEntity);
            return newOEMEntity.Id;


        }
    }
}
