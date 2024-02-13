using ExportConfigurationBALM.Builders;
using ExportConfigurationBALM.Builders.Interfaces;
using ExportConfigurationBALM.Entities;

namespace ExportConfigurationBALM.Directors.Interfaces
{
    public interface IDirectorDocumentType
    {
        void AddBuilder(IBuilderdDocumentType builder);
        DocumentType builderBase();
        DocumentType builderWithScript();
    }
}
