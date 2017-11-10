using System;
using Newtonsoft.Json;

namespace Xtrf.Api.Base
{
    internal class ExecuteResult
    {
        public string ErrorMessage { get; set; }
        public bool Success { get; set; }
        public byte[] ByteResponse { get; set; }
        public string Response { get; set; }

        public T ConvertToData<T>() => Success ? ConvertResult<T>() : default(T);

        private T ConvertResult<T>()
        {
            if (typeof(T) == typeof(string))
                return (T)Convert.ChangeType(Response, typeof(T));
            return JsonConvert.DeserializeObject<T>(Response);
        }

        public ExecuteResult(bool success, string response, string errorMessage)
        {
            Success = success;
            Response = response;
            ErrorMessage = errorMessage;
        }

        internal XtrfResult<T> GetResult<T>() => new XtrfResult<T>(this);

        public ExecuteResult(bool success, byte[] bytes, string errorMessage)
        {
            Success = success;
            ByteResponse = bytes;
            ErrorMessage = errorMessage;
        }
    }
}
