using Newtonsoft.Json;

namespace Xtrf.Api.Base
{
    public class XtrfResult<T>
    {
        public T Result { get; set; }

        public bool Success { get; set; }

        public string ErrorMessage { get; set; }

        internal XtrfResult(ExecuteResult res)
        {
            if (res.Success)
                ErrorMessage = res.ErrorMessage;
            else
                ErrorMessage = JsonConvert.DeserializeObject<XtrfError>(res.ErrorMessage).GetErrorMessage();

            Success = res.Success;
            Result = res.ConvertToData<T>();
        }
        
    }
}
