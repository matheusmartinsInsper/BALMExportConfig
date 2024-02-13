using ExportConfigurationBALM.Builders;
using ExportConfigurationBALM.Directors.Interfaces;
using ExportConfigurationBALM.Entities;

namespace ExportConfigurationBALM.Directors
{
    public class DirectorDocumentType:IDirectorDocumentType
    {
        private BuilderDocumentType _builder;
        public DirectorDocumentType(BuilderDocumentType builder)
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
