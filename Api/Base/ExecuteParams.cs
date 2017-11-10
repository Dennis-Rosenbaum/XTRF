using Newtonsoft.Json;

namespace Xtrf.Api.Base
{
    internal class ExecuteParams
    {
        public string Uri { get; internal set; }
        public string Method { get; internal set; }
        public bool AsBytes { get; set; } = false;
        public bool ExecuteByProjectManager { get; set; } = false;

        public bool HasData => Data != null;
        private object _data;
        public object Data
        {
            get { return _data; }
            private set
            {
                _data = value;
                if (_data != null)
                    _dataJson = JsonConvert.SerializeObject(Data, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
            }
        }

        private string _dataJson;
        public string DataJson => HasData ? _dataJson : string.Empty;

        internal void SetParameters(ParameterBase parameters) => Uri = $"{Uri}?{parameters.ConstructQueryString()}";
        internal void SetData(object data) => Data = data;

        public ExecuteParams(string uri) : this(uri, null) { }
        public ExecuteParams(string uri, object data)
        {
            Uri = uri;
            if (data == null)
            { }
            else if (data is ParameterBase)
                SetParameters(data as ParameterBase);
            else
                SetData(data); 
        }
    }
}
