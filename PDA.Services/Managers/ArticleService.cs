using PDA2.Data;
using PDA2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDA2.Services.Managers
{
    public class ArticleService : IArticleService
    {
        private IRepository<Article> artRep;

        private ApplicationDbContext context;

        public ArticleService(ApplicationDbContext dbContext, IRepository<Article> artRe)
        {
          

            this.context = dbContext;
            this.artRep = artRe;
        

        }

        public IList<Article> GetAll()
        {
            List<Article> list = new List<Article>();

            list.Add(new Article());


            return list;
        }
    }
}
