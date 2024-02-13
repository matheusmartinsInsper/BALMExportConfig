using ExportConfigurationBALM.Builders;
using ExportConfigurationBALM.Entities;

namespace ExportConfigurationBALM.Directors.Interfaces
{
    public interface IDirectorDocumentType
    {
        DocumentType builderBase();
        DocumentType builderWithScript();
    }
}
