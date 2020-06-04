using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HochtiefProject.Models
{
    public class Labour_Test
    {
        public int Id { get; set;  }
     
        public string FullName { get; set;}
      
        public string FirstName { get; set;}
        
        public string LastName { get; set;}
        
        public string Comapany { get; set;}
        
        public string Area { get; set;}
        
        public string Position { get; set;}
       
    }
}
