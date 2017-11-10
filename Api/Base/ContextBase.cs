using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Xtrf.Api.Base
{
    public abstract class ContextBase
    {
        protected Interface.IConnection XtrfConnection { get; set; }

        public ContextBase(Interface.IConnection xtrfConnection)
        {
            XtrfConnection = xtrfConnection;
        }

        internal async Task<XtrfResult<T>> Get<T>(ExecuteParams param) => (await Get(param)).GetResult<T>();
        internal Task<ExecuteResult> Get(ExecuteParams param)
        {
            param.Method = Methods.Get;
            return ExecuteCall(param);
        }

        internal async Task<XtrfResult<T>> Patch<T>(ExecuteParams param) => (await Patch(param)).GetResult<T>();
        internal Task<ExecuteResult> Patch(ExecuteParams param)
        {
            param.Method = Methods.Patch;
            return ExecuteCall(param);
        }
        
        internal async Task<XtrfResult<T>> Put<T>(ExecuteParams param) => (await Put(param)).GetResult<T>();
        internal Task<ExecuteResult> Put(ExecuteParams param)
        {
            param.Method = Methods.Put;
            return ExecuteCall(param);
        }

        internal async Task<XtrfResult<T>> Post<T>(ExecuteParams param) => (await Post(param)).GetResult<T>();
        internal Task<ExecuteResult> Post(ExecuteParams param)
        {
            param.Method = Methods.Post;
            return ExecuteCall(param);
        }

        internal async Task<XtrfResult<T>> Delete<T>(ExecuteParams param) => (await Delete(param)).GetResult<T>();
        internal Task<ExecuteResult> Delete(ExecuteParams param)
        {
            param.Method = Methods.Delete;
            return ExecuteCall(param);
        }

        private async Task<ExecuteResult> ExecuteCall(ExecuteParams param)
        {
            using (var client = new HttpClient())
            {
                var request = ConstructRequest(client, param);

                var httpResponse = client.SendAsync(request).Result;

                bool success = await LogPossibleError(param, httpResponse);

                return await GetResponseResult(param, httpResponse, success);
            }
        }
        
        internal async Task<T> Upload<T>(ExecuteParams param, UploadParams uploadParam) => (await Upload(param, uploadParam)).ConvertToData<T>();
        internal async Task<ExecuteResult> Upload(ExecuteParams param, UploadParams uploadParam)
        {
            param.Method = Methods.Post;

            var byteContent = uploadParam.GetFileBytes();
            HttpContent content = new ByteArrayContent(byteContent);

            //content.Headers.ContentType = new MediaTypeHeaderValue("multipart/form-data");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data") { FileName = $"{uploadParam.FileName}", Name = "file" };

            using (var form = new MultipartFormDataContent())
            {
                form.Add(content);

                using (var client = new HttpClient())
                {
                    SetHeaders(client, param);
                    var response = await client.PostAsync(GetUrl(param), form);

                    bool success = await LogPossibleError(param, response);

                    return await GetResponseResult(param, response, success);
                }
            }
        }

        private async Task<bool> LogPossibleError(ExecuteParams param, HttpResponseMessage httpResponse)
        {
            bool success = httpResponse.IsSuccessStatusCode;
            if (!success)
            {
                var result = await httpResponse.Content.ReadAsStringAsync();
                var errorMessage = GetResponseError(param, result);
                Error.ErrorLogger.ErrorOccurred(errorMessage);
            }

            return success;
        }

        private static async Task<ExecuteResult> GetResponseResult(ExecuteParams param, HttpResponseMessage httpResponse, bool success)
        {
            string errorMessage = "";
            if (!success)
                errorMessage = await httpResponse.Content.ReadAsStringAsync();

            if (param.AsBytes)
            {
                var bytes = await httpResponse.Content.ReadAsByteArrayAsync();
                return new ExecuteResult(success, bytes, errorMessage);
            }
            else
            {
                var response = await httpResponse.Content.ReadAsStringAsync();
                return new ExecuteResult(success, response, errorMessage);
            }
        }

        #region connectionspecific

        private HttpRequestMessage ConstructRequest(HttpClient client, ExecuteParams param)
        {
            var httpMethod = new HttpMethod(param.Method);

            SetHeaders(client, param);
            
            var request = new HttpRequestMessage(httpMethod, GetUrl(param));
            if (param.HasData)
            {
                request.Content = new StringContent(param.DataJson, Encoding.UTF8, "application/json");
            }
            return request;
        }

        private string GetUrl(ExecuteParams param)
        {
            if (param.Uri.StartsWith("http://") || param.Uri.StartsWith("https://"))
                return param.Uri;
            return $"{XtrfConnection.RootUrl}{param.Uri}";
        }

        private void SetHeaders(HttpClient client, ExecuteParams param)
        {
            string secretKey = param.ExecuteByProjectManager ? XtrfConnection.AuthenticationTokenProjectManager : XtrfConnection.AuthenticationToken;

            client.DefaultRequestHeaders.Add("X-AUTH-ACCESS-TOKEN", secretKey);
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=UTF-8");
            //client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/vnd.xtrf-v1+json");
        }

        private string GetResponseError(ExecuteParams param, string responseContent)
        {
            return $@"Sending Xtrf request. This went totaly wrong!
<br />
<br /><b>Request:</b>
<br />Method: {param.Method}
<br />Uri: {param.Uri}
<br />DataJson: {param.DataJson}
<br />
<br /><b>Response:</b>
<br />{responseContent}";
        }
        #endregion
    }
}
