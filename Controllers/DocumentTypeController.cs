using ExportConfigurationBALM.Builders;
using ExportConfigurationBALM.Builders.Interfaces;
using ExportConfigurationBALM.Directors;
using ExportConfigurationBALM.Directors.Interfaces;
using ExportConfigurationBALM.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExportConfigurationBALM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentTypeController : ControllerBase
    {
        private IDirectorDocumentType _director;
        public DocumentTypeController(IDirectorDocumentType director)
        {
            _director = director;
        }
        [HttpGet("builderBase/{id}")]
        public async Task<ActionResult<DocumentType>> GetBaseDt([FromRoute] int id)
        {
            DocumentType documentType;
            string token = Request.Query["token"].ToString();
            IBuilderdDocumentType builder = new BuilderDocumentType(id, token);

            await builder.InitializeAsync();
            _director.AddBuilder(builder);
            documentType = _director.builderBase();
        
            return documentType;
        }
    }
}
