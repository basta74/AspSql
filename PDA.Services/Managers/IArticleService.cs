using PDA2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDA2.Services.Managers
{
    public interface IArticleService
    {
        IList<Article> GetAll();
    }
}
