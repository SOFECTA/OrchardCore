using System;
using OrchardCore.OpenId.YesSql.Models;
using YesSql.Indexes;

namespace OrchardCore.OpenId.YesSql.Indexes
{
    public class OpenIdTokenIndex : MapIndex
    {
        public string TokenId { get; set; }
        public string ApplicationId { get; set; }
        public string AuthorizationId { get; set; }
        public DateTimeOffset? ExpirationDate { get; set; }
        public string ReferenceId { get; set; }
        public string Status { get; set; }
        public string Subject { get; set; }
    }

    public class OpenIdTokenIndexProvider : IndexProvider<OpenIdToken>
    {
        public override void Describe(DescribeContext<OpenIdToken> context)
        {
            context.For<OpenIdTokenIndex>()
                .Map(token => new OpenIdTokenIndex
                {
                    TokenId = token.TokenId,
                    ApplicationId = token.ApplicationId,
                    AuthorizationId = token.AuthorizationId,
                    ExpirationDate = token.ExpirationDate,
                    ReferenceId = token.ReferenceId,
                    Status = token.Status,
                    Subject = token.Subject
                });
        }
    }
}