using StartUp.Confluence.Model.Entities.Confluence;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Spaces
{
  public class Space : BaseEntity
  {
    public string Name { get; set; }           //or Title
    public string Description { get; set; }    //or Document
    public string type { get; set; }      
    public Guid? CategoryId { get; set; }

    public virtual Category Category { get; set; }                  
    public virtual ICollection<Document> Documents { get; set; }
  }
}
