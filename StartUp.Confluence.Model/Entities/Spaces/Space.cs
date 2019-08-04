using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Spaces
{
  public class Space : BaseEntity
  {
    public string Name { get; set; }           //or Title
    public string Description { get; set; }    //or Content
    public string type { get; set; }
    public Guid? ParentId { get; set; }

    public virtual Space Parent { get; set; }
    public virtual ICollection<Space> Childrens { get; set; }
    public virtual ICollection<Content> Contents { get; set; }
  }
}
