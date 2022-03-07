using Gabo.GraphQL.CoffeShop.Models;
using GraphQL.Types;

namespace Gabo.GraphQL.CoffeShop.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.ImageUrl);
        }
    }
}
