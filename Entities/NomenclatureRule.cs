using ExportConfigurationBALM.Entities.ValueObjects;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace ExportConfigurationBALM.Entities
{
    public class NomenclatureRule
    {
        private int _id;
        private string _nomenclatureName;
        private List<JObject> _nomenclatureFields;
        private string _createDate;
        private string _lmAuthor;
        private int _tenantId;
        private bool _active;
        private string _separator;
        private bool _nullCaseVersion;
        private DocumentType _documentType;
        public int Id { get { return _id; } set { _id = value; } }
        public string NomenclatureName { get { return _nomenclatureName; } set { _nomenclatureName = value; } }
        public List<JObject> NomenclatureFields { get { return _nomenclatureFields; } set { _nomenclatureFields = value; } }
        public string CreateDate { get { return _createDate; } set { _createDate = value; } }
        public string LmAuthor { get { return _lmAuthor; } set { _lmAuthor = value; } }
        public int TenantId { get { return _tenantId; } set { _tenantId = value; } }
        public bool Active { get { return _active; } set { _active = value; } }
        public string Separator { get { return _separator; } set { _separator = value; } }
        public bool NullCaseVersion { get { return _nullCaseVersion; } set { _nullCaseVersion = value; } }
        public DocumentType DocumentType { get { return _documentType; } set { _documentType = value; } }
    }
}
