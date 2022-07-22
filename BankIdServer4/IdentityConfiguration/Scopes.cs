using IdentityServer4.Models;
using System.Collections.Generic;

namespace BankIdServer4.IdentityConfiguration
{
    public class Scopes
    {
        public static IEnumerable<ApiScope> ApiScopes =>
        new[]
        {
        new ApiScope("CustomerMicroService.read"),
        new ApiScope("CustomerMicroService.write"),
        };
    }
}
