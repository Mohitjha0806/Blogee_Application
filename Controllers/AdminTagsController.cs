using Microsoft.AspNetCore.Mvc;
using BlogeeCoreMVC.Models.ViewModels;
using BlogeeCoreMVC.Data;
using BlogeeCoreMVC.Models.Domain;

namespace BlogeeCoreMVC.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BlogeeDbContext blogeeDbContext;

        public AdminTagsController(BlogeeDbContext blogeeDbContext)
        {
            this.blogeeDbContext = blogeeDbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddTagRequest addTagRequest)
        {

            // Mapping AddTagRequest To tag Domain model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };

            blogeeDbContext.Tags.Add(tag);
            blogeeDbContext.SaveChanges();

            return View("Add");
        }
    }
}
