﻿using System.Collections.Generic;
using System.Linq;
using $ext_safeprojectname$.Domain;

namespace $safeprojectname$.DTO
{
    public class UserDTO
    {
        public string Name { get; set; }
        public long Id { get; set; }

        public User ToDomain()
        {
            return new User
            {
                Id = this.Id,
                Name = this.Name
            };
        }
    }

    public static class UserDTOExtensions
    {
        public static IEnumerable<User> ToDomain(this IEnumerable<UserDTO> dtos)
        {
            return dtos.Select(d => d.ToDomain());
        }
    }
}
