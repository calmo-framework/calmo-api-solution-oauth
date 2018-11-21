using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using $ext_safeprojectname$.Domain;
using $ext_safeprojectname$.Repository;
using $safeprojectname$.Models;

namespace $safeprojectname$.Controllers
{
    /// <inheritdoc />
    [Authorize]
    [RoutePrefix("api/users")]
    public class UsersController : BaseController
    {
        /// <summary>Get a list of users.</summary>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, null, typeof(IEnumerable<UserModel>))]
        public IHttpActionResult List()
        {
            var repository = new UserRepository();
            var users = repository.List();
            var models = users.ToModel();

            return Ok(models);
        }

        /// <summary>Get a specific user by id.</summary>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, null, typeof(UserModel))]
        public IHttpActionResult Get(long id)
        {
            var repository = new UserRepository();
            var user = repository.Get(id);

            return Ok(user);
        }

        /// <summary>Insert a new user.</summary>
        /// <param name="user"></param>
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.NoContent, "Success")]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Validation error")]
        public IHttpActionResult Insert([FromBody]UserModel user)
        {
            if (user == null)
                return this.BadRequest();

            return this.NoContent();
        }

        /// <summary> Update an existing user.</summary>
        /// <param name="user"></param>
        [HttpPut]
        [SwaggerResponse(HttpStatusCode.NoContent, "Success")]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Validation error")]
        public IHttpActionResult Update([FromBody]UserModel user)
        {
            if (user == null)
                return this.BadRequest();

            return this.NoContent();
        }

        /// <summary>  Delete an existing user.</summary>
        /// <param name="id"></param>
        [HttpDelete]
        [SwaggerResponse(HttpStatusCode.NoContent, "Success")]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Validation error")]
        public IHttpActionResult Delete(long id)
        {
            if (id <= 0)
                return this.BadRequest();

            return this.NoContent();
        }
    }
}
