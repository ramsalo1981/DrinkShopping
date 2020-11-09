using DrinkAndGo.Models;
using System.Collections.Generic;

namespace DrinkAndGo.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
