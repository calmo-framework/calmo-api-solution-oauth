using System.Collections.Generic;
using $ext_safeprojectname$.Domain;
using $ext_safeprojectname$.Domain.Repository;
using $safeprojectname$.DTO;

namespace $safeprojectname$
{
    public class UserRepository : Calmo.Data.Repository, IUserRepository
    {
        public User Get(long id)
        {
            //Sample usage of listing objects from SQL Server
            //var result = this.Data.Db().AsStatement().Get<UserDTO>("SELECT * FROM user");
            var result = new UserDTO {Id = id, Name = "John Doe"};

            return result.ToDomain();
        }

        public IEnumerable<User> List()
        {
            //Sample usage of listing objects from SQL Server
            //var result = this.Data.Db().AsStatement().List<UserDTO>("SELECT * FROM user");
            var result = new List<UserDTO>
            {
                new UserDTO{Id = 1, Name = "John Doe"}
            };

            return result.ToDomain();
        }

        public long Add(User contact)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(User contact)
        {
            throw new System.NotImplementedException();
        }
    }
}
