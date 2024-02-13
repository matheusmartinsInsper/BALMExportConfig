
using ExportConfigurationBALM.Entities.ValueObjects;

namespace ExportConfigurationBALM.Entities
{
    public class DocumentType
    {
        private int _id;
        private string _dtType;
        private bool _active;
        private int _maxSpawn;
        private string _maxSpawnType;
        private string _ImAuthor;
        private bool _publish;
        private List<MetaDataType> _dtTypeFields;
        private int _scriptId;
        private string? _script;

        public int id { get { return _id; } set { _id = value; } }
        public List<MetaDataType> dtTypeFields { get { return _dtTypeFields; } set { _dtTypeFields = value; } }
        public string dtType { get { return _dtType; } set { _dtType = value; } }
        public bool active { get { return _active; } set { _active = value; } }
        public int maxSpawn { get { return _maxSpawn; } set { _maxSpawn = value; } }
        public string maxSpawnType { get { return _maxSpawnType; } set { _maxSpawnType = value; } }
        public string ImAuthor { get { return _ImAuthor; } set { _ImAuthor = value; } }
        public bool publish { get { return _publish; } set { _publish = value; } }
        public int scriptId { 
            get { if (_scriptId == null) { return 0; } else { return _scriptId; } } 
            set { _scriptId = value; } }
        public string script { get { return _script; } set { _script = value; } }
    }
}
