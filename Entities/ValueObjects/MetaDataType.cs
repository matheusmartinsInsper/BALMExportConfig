namespace ExportConfigurationBALM.Entities.ValueObjects
{
    public class MetaDataType
    {
        private int _id;
        private string _createDate;
        private string _lastMod;
        private int _tenantId;
        private int _ImAuthor;
        private string _name;
        private string? _metaDataType;
        private int _metaDataTypeId;
        private string _type;
        public int id { get { return _id; } set { _id = value; } }
        public string createDate { get { return _createDate; } set { _createDate = value; } }
        public string lastMod { get { return _lastMod; } set { _lastMod = value; } }
        public int tenantId { get { return _tenantId; } set { _tenantId = value; } }
        public int ImAuthor { get { return _ImAuthor; } set { _ImAuthor = value; } }
        public string name { get { return _name; } set { _name = value; } }
        public string metaDataType { get { return _metaDataType; } set { _metaDataType = value; } }
        public int metaDataTypeId { get { return _metaDataTypeId; } set { _metaDataTypeId = value; } }
        public string type { get { return _type; } set { _type = value; } }
    }
}
