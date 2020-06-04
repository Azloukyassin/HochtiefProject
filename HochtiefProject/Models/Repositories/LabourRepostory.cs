using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HochtiefProject.Models.Repositories
{
    public class LabourRepostory : ILabourRepostroy<Labour_Test>
    {
        List<Labour_Test> labours;
        public LabourRepostory()
        {
            labours = new List<Labour_Test>
            {
                new Labour_Test
                {
                    Id = 1 , FullName = "Azlouk Mohamed" , FirstName ="Azlouk" , LastName ="Mohamed" , Comapany ="Hochtief" ,Area ="text" , Position="test"
                }
            };
                
        }
        public void Add(Labour_Test labour)
        {
            labours.Add(labour); 
        }

        public void Delete(int id)
        {
            var labour = labours.SingleOrDefault(x => x.Id == id);
            labours.Remove(labour); 
        }

        public Labour_Test Find(int id)
        {
            var labour = labours.SingleOrDefault(x => x.Id == id);
            return labour; 
        }

        public IList<Labour_Test> List()
        {
            return labours;
        }

        public void Update(int id , Labour_Test Newlabour)
        {
            var labour = Find(id); 
            labour.FullName = Newlabour.FullName;
            labour.FirstName = Newlabour.FirstName;
            labour.LastName = Newlabour.LastName;
            labour.Comapany = Newlabour.Comapany;
            labour.Area = Newlabour.Area;
            labour.Position = Newlabour.Position; 
        }
    }
}
