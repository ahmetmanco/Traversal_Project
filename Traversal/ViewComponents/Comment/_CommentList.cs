using BussinessLayer.Concrete;
using DataAccessLayer.EF;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var value = commentManager.TGetdestinationById(id);
            return View(value);
        }
    }
}
