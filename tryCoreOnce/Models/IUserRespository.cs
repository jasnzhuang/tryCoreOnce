using System.Linq;

namespace tryCoreOnce.Models
{
    public interface IUserRespository
    {
        IQueryable<User> Users { get; }
    }
}