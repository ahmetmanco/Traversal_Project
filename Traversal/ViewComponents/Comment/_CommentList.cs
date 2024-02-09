using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EF;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount=context.Commentss.Where(x=>x.DestinationId==id).Count();
            var value = commentManager.TGetListCommentwithDestinationAndUser(id);
            return View(value);
        }
    }
}
