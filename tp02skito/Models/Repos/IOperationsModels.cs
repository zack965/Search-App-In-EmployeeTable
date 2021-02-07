using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp02skito.Models.Repos
{
    public interface IOperationsModels<TEntity>
    {
        IList<TEntity> List();
        //TEntity FindAge(int id);
        IList<TEntity> FindAge(int id);
        IList<TEntity> FindBetween(int idone,int idtwo);
        IList<TEntity> FindByLetter(string letter);
    }
}
