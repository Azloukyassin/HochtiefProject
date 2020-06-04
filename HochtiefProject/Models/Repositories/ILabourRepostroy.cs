using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HochtiefProject.Models.Repositories
{
   public interface ILabourRepostroy<Labour_Test>
    {
        IList<Labour_Test> List();
        Labour_Test Find(int id);
        void Add(Labour_Test labour);
        void Update(int id ,Labour_Test labour);
        void Delete(int id); 
    }
}
