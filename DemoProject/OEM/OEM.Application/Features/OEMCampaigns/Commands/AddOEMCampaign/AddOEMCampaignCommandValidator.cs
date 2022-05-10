using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Application.Features.OEMCampaigns.Commands.AddOEMCampaign
{
    public class AddOEMCampaignCommandValidator : AbstractValidator<AddOEMCommand>
    {
        public AddOEMCampaignCommandValidator()
        {
            RuleFor(p=>p.ListTitle).NotEmpty().WithMessage("{ListTitle} is required").NotNull().MaximumLength(50).WithMessage("{Title} must not exceed 50 characters");
        }
    }
}
