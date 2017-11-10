using Newtonsoft.Json;

namespace Xtrf.Api.Base
{
    public class XtrfError
    {
        public int status { get; set; }
        public string errorMessage { get; set; }
        public string detailedMessage { get; set; }
        
        internal string GetErrorMessage()
        {
            var str = $"Statuscode: {status}, bericht: {errorMessage}";
            if (!string.IsNullOrEmpty(detailedMessage))
                str += $", gedetailleerd bericht: {detailedMessage}";
            return str;
        }        
    }
}
