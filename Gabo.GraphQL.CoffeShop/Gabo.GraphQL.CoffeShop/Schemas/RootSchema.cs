using Gabo.GraphQL.CoffeShop.Query;
using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace Gabo.GraphQL.CoffeShop.Schemas
{
    public class RootSchema : Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
        }
    }
}
