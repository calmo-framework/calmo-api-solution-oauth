using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using $ext_safeprojectname$.Domain;

namespace $safeprojectname$.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public long Id { get; set; }
    }

    public static class UserModelExtensions
    {
        public static UserModel ToModel(this User domain)
        {
            return new UserModel
            {
                Name = domain.Name,
                Id = domain.Id
            };
        }

        public static IEnumerable<UserModel> ToModel(this IEnumerable<User> users)
        {
            var models = new List<UserModel>();

            foreach (var user in users)
            {
                models.Add(user.ToModel());
            }

            return models;
        }
    }
}