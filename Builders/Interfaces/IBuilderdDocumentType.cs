using ExportConfigurationBALM.Entities;

namespace ExportConfigurationBALM.Builders.Interfaces
{
    public interface IBuilderdDocumentType
    {
        IBuilderdDocumentType BuilderBase();
        IBuilderdDocumentType BuilderWithScript();
        DocumentType Build();
        Task InitializeAsync();
    }
}
