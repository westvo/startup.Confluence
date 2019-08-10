using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Spaces
{
  public class Document : BaseEntity
  {    
    public Guid SpaceId { get; set; }
    public int VotesSum { get; set; }
    public int VotesCount { get; set; }
    public int ViewsCount { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int Status { get; set; }
    public string Version { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string type { get; set; }     
    public Guid? ParentId { get; set; }

    public virtual Document Parent { get; set; }
    public virtual ICollection<Document> Childrens { get; set; }
    public virtual Space Space { get; set; }
  }
}
