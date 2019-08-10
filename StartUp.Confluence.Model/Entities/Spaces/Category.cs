using StartUp.Confluence.Model.Entities.Spaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Confluence
{
  public class Category : BaseEntity
  {
    public string Name { get; set; }           //or Title
    public string Description { get; set; }    //or Document
    public string type { get; set; }
    public Guid? ParentId { get; set; }

    public virtual Category Parent { get; set; }
    public virtual ICollection<Category> Children { get; set; }
    public virtual ICollection<Space> Spaces { get; set; }
  }
}
