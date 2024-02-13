using ExportConfigurationBALM.Builders;
using ExportConfigurationBALM.Entities;

namespace ExportConfigurationBALM.Directors
{
    public class DirectorNomenclatureRule
    {
        private BuilderNomenclatureRule _builder;
        public DirectorNomenclatureRule(BuilderNomenclatureRule builder)
        {
            _builder = builder;
        }
        public NomenclatureRule builderBase()
        {
            return _builder.BuilderBase()
                           .Build ();
        }
    }
}
