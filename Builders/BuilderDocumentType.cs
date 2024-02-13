using ExportConfigurationBALM.APIs;
using ExportConfigurationBALM.Builders.Interfaces;
using ExportConfigurationBALM.Entities;
using ExportConfigurationBALM.Entities.ValueObjects;
using Newtonsoft.Json.Linq;

namespace ExportConfigurationBALM.Builders
{
    public class BuilderDocumentType: IBuilderdDocumentType
    {
        private JObject _Data;
        private List<JObject> _DataMetaDataField;
        private readonly int _id;
        private readonly string _token;
        private bool _initialized = false;
        private DocumentType document = new DocumentType();
        private List<MetaDataType> fields= new List<MetaDataType>();
        public BuilderDocumentType(int id,string token) 
        {
            _token=token;
            _id = id;
        }
        private async Task GetData()
        {
            APIDocumentType doc = new APIDocumentType();
            APIMetaDataField fields = new APIMetaDataField();
            _Data = await doc.GET(_id,_token);
            _DataMetaDataField = await fields.GET(_id,_token);
            AssignApiResponse(_DataMetaDataField);
        }
        private void AssignApiResponse(List<JObject> DataMetaDataField)
        {
            foreach (JObject obj in DataMetaDataField)
            {
                MetaDataType convertedObject = ConvertJObjectToMetaDataType(obj);
                fields.Add(convertedObject);
            }
        }
        private MetaDataType ConvertJObjectToMetaDataType(JObject obj)
        {
            MetaDataType objectConvert = new MetaDataType()
            {
                id = obj["id"].Value<int>(),
                createDate = obj["createDate"].Value<string>(),
                lastMod = obj["lastMod"].Value<string>(),
                tenantId = obj["tenantId"].Value<int>(),
                ImAuthor = obj["lmAuthor"].Value<int>(),
                name = obj["name"].Value<string>(),
                metaDataType = obj["metaDataType"]?.Value<string>(),
                metaDataTypeId = obj["metaDataTypeId"].Value<int>(),
                type = obj["type"].Value<string>()
            };
            return objectConvert;
        }
        public IBuilderdDocumentType BuilderBase()
        {
            document.id = _Data["id"].Value<int>();
            document.dtType = _Data["dtType"].Value<string>();
            document.active= _Data["active"].Value<bool>();
            document.ImAuthor = _Data["lmAuthor"].Value<string>();
            document.maxSpawn = _Data["maxSpawn"].Value<int>();
            document.maxSpawnType = _Data["maxSpawnType"].Value<string>();
            document.publish = _Data["publish"].Value<bool>();
            document.dtTypeFields = fields;
            return this;
        }
        public IBuilderdDocumentType BuilderWithScript()
        {
            document.scriptId = _Data["scriptId"].Value<int>();
            document.script = _Data["script"].Value<string>();
            return this;
        }
        public DocumentType Build()
        { 
            return document;
        }
        public async Task InitializeAsync()
        {
                await GetData();
        }
    }
}
