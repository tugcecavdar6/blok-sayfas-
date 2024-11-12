using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentServices
    {
        IYorumDal _commentdal;

        public CommentManager(IYorumDal commentdal)
        {
            _commentdal = commentdal;
        }

        public List<yorumlar> GetList(int id)
        {
           return _commentdal.GetListAll(x => x.BlogID == id);
        }

        public void YorumAdd(yorumlar yorumlar)
        {
            _commentdal.Insert(yorumlar);
        }
    }
}
