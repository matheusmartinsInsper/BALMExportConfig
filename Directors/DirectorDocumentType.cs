using ExportConfigurationBALM.Builders;
using ExportConfigurationBALM.Builders.Interfaces;
using ExportConfigurationBALM.Directors.Interfaces;
using ExportConfigurationBALM.Entities;

namespace ExportConfigurationBALM.Directors
{
    public class DirectorDocumentType:IDirectorDocumentType
    {
        private IBuilderdDocumentType _builder;
        public void AddBuilder(IBuilderdDocumentType builder)
        {
            _builder = builder;
        }

        public DocumentType builderBase()
        {
            return _builder.BuilderBase()
                           .Build();
        }

        public DocumentType builderWithScript()
        {
            return _builder.BuilderBase()
                           .BuilderWithScript()
                           .Build();
        }
    }
}
