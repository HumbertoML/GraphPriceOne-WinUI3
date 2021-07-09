using System;

namespace GraphPriceOne.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);
    }
}
