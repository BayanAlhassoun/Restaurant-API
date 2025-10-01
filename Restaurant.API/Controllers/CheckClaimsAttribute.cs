using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Restaurant.API.Controllers
{
    public class CheckClaimsAttribute: Attribute, IAuthorizationFilter
    {
        private readonly string _claimType; // Roleid
        private readonly string _claimValue; // 2

        public CheckClaimsAttribute(string claimType, string claimValue) // Roleid, 2
        {
            _claimType = claimType;
            _claimValue = claimValue;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(!context.HttpContext.User.HasClaim(_claimType, _claimValue)) // Roleid , 2
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
