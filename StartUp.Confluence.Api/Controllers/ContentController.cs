using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StartUp.Confluence.Model.Entities.Spaces;
using StartUp.Confluence.Service.Shared.Spaces;

namespace StartUp.Confluence.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ContentController : ControllerBase
  {

    IContentService _contentService;
    public ContentController(IContentService contentService)
    {
      _contentService = contentService;
    }

    // GET: api/Content
    [HttpGet]
    public async Task<object> Get()
    {
      var contents = await _contentService.GetAllAsync();
      return contents;
    }

    // GET: api/Content/5                 
    [HttpGet("Content/{id}")]
    public Content Get(Guid id)
    {
      var content = _contentService.Get(id);
      return content;
    }

    // POST: api/Content
    [HttpPost]
    public Content Post([FromBody] Content content)
    {
      var c = _contentService.Create(content);
      return c;
    }

    // PUT: api/Content/5
    [HttpPut("{id}")]
    public Content Put(Guid id, [FromBody] Content content)
    {
      content.Id = id;
      var c = _contentService.Update(content);
      return c;
    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public Content Delete(Guid id)
    {
      var c = _contentService.Delete(id);
      return c;
    }
  }
}
