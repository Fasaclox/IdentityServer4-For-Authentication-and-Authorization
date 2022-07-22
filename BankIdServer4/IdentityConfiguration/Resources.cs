using IdentityServer4.Models;
using System.Collections.Generic;

namespace BankIdServer4.IdentityConfiguration
{
    public class Resources
    {
        public static IEnumerable<ApiResource> ApiResources => new[]
       {
         new ApiResource("CustomerMicroService")
         {
        Scopes = new List<string> { "CustomerMicroService.read", "CustomerMicroService.write"},
        ApiSecrets = new List<Secret> {new Secret("ScopeSecret".Sha256())},
        UserClaims = new List<string> {"role"}

         }
         };

        public static IEnumerable<IdentityResource> IdentityResources =>
         new[]
         {
        new IdentityResources.OpenId(),
        new IdentityResources.Profile(),
        new IdentityResource
        {
          Name = "role",
          UserClaims = new List<string> {"role"}
        }
         };
    }
}
