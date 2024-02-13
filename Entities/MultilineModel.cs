using Newtonsoft.Json.Linq;

namespace ExportConfigurationBALM.Entities
{
    public class MultilineModel
    {
        private bool _importWithFile;
        private int _id;
        private string _name;
        private DocumentType _documentType;
        private int _extension;
        private int _processingType;
        private int _startRow;
        private int _endRow;
        private bool _captureEveryFile;
        private JObject _file;
        private JObject[] _metadatas;
        public bool ImportWithFile { get => _importWithFile; set => _importWithFile = value; }
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DocumentType DocumentType { get => _documentType; set => _documentType = value; }
        public int Extension { get => _extension; set => _extension = value; }
        public int ProcessingType { get => _processingType; set => _processingType = value; }
        public int StartRow { get => _startRow; set => _startRow = value; }
        public int EndRow { get => _endRow; set => _endRow = value; }
        public bool CaptureEveryFile { get => _captureEveryFile; set => _captureEveryFile = value; }
        public JObject File { get => _file; set => _file = value; }
        public JObject[] Metadatas { get => _metadatas; set => _metadatas = value; }
    }
}
