using FluentValidation;
using OEYBS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEYBS.Business.ValidationRules.FluentValidation
{
    public class AppRoleValidatior : AbstractValidator<AppRole>
    {
        public AppRoleValidatior()
        {
            RuleFor(r => r.Name).NotEmpty();

        }
    }
}
