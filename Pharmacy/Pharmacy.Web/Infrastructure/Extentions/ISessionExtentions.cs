namespace Pharmacy.Web.Infrastructure.Extentions
{
    using Microsoft.AspNetCore.Http;
    using Pharmacy.Common;
    using System;

    public static class ISessionExtentions
    {
        public static string GetShoppingCartId(this ISession session)
        {
            var shoppingCartId = session.GetString(GlobalConstants.ShoppingCartSessionId);

            if (shoppingCartId == null)
            {
                shoppingCartId = Guid.NewGuid().ToString();
                session.SetString(GlobalConstants.ShoppingCartSessionId, shoppingCartId);
            }

            return shoppingCartId;
        }
    }
}
