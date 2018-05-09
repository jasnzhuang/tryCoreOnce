using System.Collections.Generic;
using System.Linq;

namespace tryCoreOnce.Models
{
    public class FakeUserRepository : IUserRespository
    {
        public IQueryable<User> Users => new List<User>
        {
            new User {UserName = "aajz", UserAge = 18},
            new User {UserName = "jyc", UserAge = 19}
        }.AsQueryable<User>();
    }
}