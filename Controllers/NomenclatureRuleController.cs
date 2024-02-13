using ExportConfigurationBALM.Builders;
using ExportConfigurationBALM.Directors;
using ExportConfigurationBALM.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExportConfigurationBALM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NomenclatureRuleController : ControllerBase
    {
        [HttpGet("builderBase/{id}")]
        public async Task<ActionResult<NomenclatureRule>> GetBaseRule([FromRoute] int id)
        {
            NomenclatureRule nomenclatureRule;
            string token = Request.Query["token"].ToString();
            BuilderNomenclatureRule builder = new BuilderNomenclatureRule(id, token);

            await builder.InitializeAsync();
            DirectorNomenclatureRule director = new DirectorNomenclatureRule(builder);
            nomenclatureRule = director.builderBase();

            return nomenclatureRule;
        }
    }
}
