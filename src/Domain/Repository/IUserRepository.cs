using System.Collections.Generic;

namespace $safeprojectname$.Repository
{
    public interface IUserRepository
    {
        User Get(long id);
        IEnumerable<User> List();
        long Add(User contact);
        void Delete(long id);
        void Update(User contact);
    }
}
