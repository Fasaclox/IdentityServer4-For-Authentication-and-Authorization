using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace BankIdServer4.IdentityConfiguration
{
    public class Clients
    {
        public static IEnumerable<Client> Get() =>
        new[]
        {
        // m2m client credentials flow client
        new Client
        {
          ClientId = "m2m.client",
          ClientName = "Client Credentials Client",
          AllowedGrantTypes = GrantTypes.ClientCredentials,
          ClientSecrets = {new Secret("SuperSecretPassword".Sha256())},
          AllowedScopes = {"CustomerMicroService.read", "CustomerMicroService.write" }
        },
        
        // interactive client using code flow + pkce
        new Client
        {
          ClientId = "interactive",
          ClientSecrets = {new Secret("SuperSecretPassword".Sha256())},
          AllowedGrantTypes = GrantTypes.Code,

          RedirectUris = {"https://localhost:5444/signin-oidc"},
          FrontChannelLogoutUri = "https://localhost:5444/signout-oidc",
          PostLogoutRedirectUris = {"https://localhost:5444/signout-callback-oidc"},

          AllowOfflineAccess = true,
          AllowedScopes = new List<string>
        {
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile
        },


          RequirePkce = true,
          RequireConsent = true,
          AllowPlainTextPkce = false
        },
        };
    }
}

