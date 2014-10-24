using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using LearningGrid.Services.DataObjects;
using LearningGrid.Services.Models;

namespace LearningGrid.Services.Controllers
{
    public class CourseController : TableController<Course>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();


            
            DomainManager = new EntityDomainManager<Course>(context, Request, Services);
        }

        // GET tables/Course
        public IQueryable<Course> GetAllCourse()
        {
            var qry = Query();

           

            return qry;
        }

        // GET tables/Course/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Course> GetCourse(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Course/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Course> PatchCourse(string id, Delta<Course> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Course/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public async Task<IHttpActionResult> PostCourse(Course item)
        {
            Course current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Course/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCourse(string id)
        {
             return DeleteAsync(id);
        }

    }
}