using System.Collections.Generic;
using MVC_FirstApp.Domain.Entities;

namespace MVC_FirstApp.Domain.Abstract
{
    public interface iProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}