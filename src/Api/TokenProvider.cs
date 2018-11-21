using Microsoft.Owin.Security.OAuth;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    public class TokenProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            //Apply your authentication logic here
            if (true)
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                //var user = repository.Get(context.UserName);
                //var claims = user.Claims.Select(c => new Claim("access", c));
                //identity.AddClaims(claims);                
                context.Validated(identity);
            }
            else
            {
                context.SetError("Acesso Inválido", "Não autorizado.");
                return;
            }
        }
    }
}
