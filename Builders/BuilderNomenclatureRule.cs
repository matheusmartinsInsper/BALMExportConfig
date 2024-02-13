using ExportConfigurationBALM.APIs;
using ExportConfigurationBALM.Entities;
using Newtonsoft.Json.Linq;

namespace ExportConfigurationBALM.Builders
{
    public class BuilderNomenclatureRule
    {
        private List<JObject> _Data;
        private JObject _DataNomenclatureRule;
        private int _id;
        private int _idDocumentType;
        private string _token;
        private BuilderDocumentType _builderDocTyp;
        private DocumentType _docType;
        NomenclatureRule nomenclatureRule = new NomenclatureRule();
        public BuilderNomenclatureRule(int id, string token)
        {
            _id = id;
            _token = token;
        }
        private async Task GetData()
        {
            APINomenclatureRule nomenclatureRule = new APINomenclatureRule();
            _Data = await nomenclatureRule.GET(_token);
            FindNomenclatureRule(_Data);
            _idDocumentType = _DataNomenclatureRule["metaTypeId"].Value<int>();
            _builderDocTyp = new BuilderDocumentType(_idDocumentType, _token);
            await _builderDocTyp.InitializeAsync();
            BuilderDocumentType();
        }
        private void FindNomenclatureRule(List<JObject> data)
        {
            foreach(JObject obj in data)
            {
                if (obj["id"].Value<int>() == _id)
                {
                    _DataNomenclatureRule = obj;
                }
            }
        }
        private void BuilderDocumentType()
        {
            _docType = _builderDocTyp.BuilderBase()
                                   .Build();
        }
        public BuilderNomenclatureRule BuilderBase()
        {
            nomenclatureRule.Id = _DataNomenclatureRule["id"].Value<int>();
            nomenclatureRule.NomenclatureName = _DataNomenclatureRule["nomenclatureName"].Value<string>();
            nomenclatureRule.CreateDate = _DataNomenclatureRule["createDate"].Value<string>();
            nomenclatureRule.LmAuthor = _DataNomenclatureRule["lmAuthor"].Value<string>();
            nomenclatureRule.TenantId = _DataNomenclatureRule["tenantId"].Value<int>();
            nomenclatureRule.Active = _DataNomenclatureRule["active"].Value<bool>();
            nomenclatureRule.Separator = _DataNomenclatureRule["separator"].Value<string>();
            nomenclatureRule.NullCaseVersion = _DataNomenclatureRule["nullCaseVersion"].Value<bool>();
            nomenclatureRule.DocumentType = _docType;
            return this;
        }
        public NomenclatureRule Build()
        {
            return nomenclatureRule;
        }
        public async Task InitializeAsync()
        {
            await GetData();
        }
    }
}
