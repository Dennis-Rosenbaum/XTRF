using System.Threading.Tasks;
using Xtrf.Api.Base;
using Xtrf.Core.Data;

namespace Xtrf.Api.QuotesSmart
{
    public class QuoteContext : ContextBase
    {
        internal QuoteContext(Interface.IConnection xtrfConnection) : base(xtrfConnection) { }

        #region POST
        //public Task<Data.Project> CreateNew(Data.ProjectCreate newProject)
        //    => Post<Data.Project>(new ExecuteParams("/v2/quotes", newProject));

        public Task<ProjectsSmart.Data.File> Upload(string quoteId, UploadParams uploadParam)
            => Upload<ProjectsSmart.Data.File>(new ExecuteParams($"/v2/quotes/{quoteId}/files/upload"), uploadParam);

        public Task<XtrfResult<ProjectsSmart.Data.FileArchive>> Archive(ProjectsSmart.Data.FileList files)
            => Post<ProjectsSmart.Data.FileArchive>(new ExecuteParams($"/v2/quotes/files/archive", files));
        #endregion

        #region GET
        //public Task<Data.ProjectFile> GetFile(string fileId)
        //    => Get<Data.ProjectFile>(new ExecuteParams($"/v2/quotes/files/{fileId}"));

        public async Task<byte[]> DownloadFile(string fileId, string fileName)
            => (await Get(new ExecuteParams($"/v2/quotes/files/{fileId}/download/{fileName}") { AsBytes = true })).ByteResponse;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quoteId">KVVV24S34ZC65LB5MXQ3GSFFUY</param>
        /// <param name="asBytes"></param>
        /// <returns></returns>
        public Task<XtrfResult<ProjectsSmart.Data.Project>> Get(string quoteId, bool asBytes = false)
            => Get<ProjectsSmart.Data.Project>(new ExecuteParams($"/v2/quotes/{quoteId}"));

        //public async Task<Data.SmartContacts> GetClientContacts(string quoteId)
        //    => await Get<Data.SmartContacts>(new ExecuteParams($"/v2/quotes/{quoteId}/clientContacts"));

        public Task<XtrfResult<CustomFields>> GetCustomFields(string quoteId)
            => Get<CustomFields>(new ExecuteParams($"/v2/quotes/{quoteId}/customFields"));

        public Task<XtrfResult<ProjectsSmart.Data.ProjectFiles>> GetFiles(string quoteId)
            => Get<ProjectsSmart.Data.ProjectFiles>(new ExecuteParams($"/v2/quotes/{quoteId}/files"));

        //public Task<Data.ProjectFiles> GetFileDeliverables(string quoteId)
        //    => Get<Data.ProjectFiles>(new ExecuteParams($"/v2/quotes/{quoteId}/files/deliverable"));

        //public Task<Data.Finance> GetFinance(string quoteId)
        //    => Get<Data.Finance>(new ExecuteParams($"/v2/quotes/{quoteId}/finance"));

        public Task<XtrfResult<JobsSmart.Data.Jobs>> GetJobs(string quoteId)
            => Get<JobsSmart.Data.Jobs>(new ExecuteParams($"/v2/quotes/{quoteId}/jobs"));
        #endregion

        #region PUT
        //public Task<Data.Contacts> UpdateClientContacts(string quoteId, Data.SmartContacts contacts)
        //    => Put<Data.Contacts>(new ExecuteParams($"/v2/quotes/{quoteId}/clientContacts", contacts));

        //public Task UpdateClientDeadline(string quoteId, DateTime date)
        //    => Put(new ExecuteParams($"/v2/quotes/{quoteId}/clientDeadline", new Data.Time(date)));

        //public Task UpdateClientNotes(string quoteId, string note)
        //    => Put(new ExecuteParams($"/v2/quotes/{quoteId}/clientNotes", new SingleValue(note)));

        //public Task UpdateClientReferenceNumber(string quoteId, string referenceNumber)
        //    => Put(new ExecuteParams($"/v2/quotes/{quoteId}/clientReferenceNumber", new SingleValue(referenceNumber)));

        public Task UpdateCustomField(string quoteId, string key, string value)
            => Put(new ExecuteParams($"/v2/quotes/{quoteId}/customFields/{key}", new SingleValue(value)));

        /// <summary>
        /// Adds files to the project as added by PM.The files have to be uploaded beforehand(see "POST /v2/quotes/{quoteId}/files/upload" operation). The following properties can be specified for each file:
        /// 
        /// category(required, 400 Bad Request is returned otherwise)
        /// languageIds – when the file category depends on a list of languages
        /// languageCombinationIds – when the file category depends on a list of language combinations
        /// </summary>
        public Task AddFiles(string quoteId, ProjectsSmart.Data.FileCategorizations files)
            => Put(new ExecuteParams($"/v2/quotes/{quoteId}/files/add", files));

        public Task AddFile(string quoteId, ProjectsSmart.Data.FileCategorization file) 
            => AddFiles(quoteId, new ProjectsSmart.Data.FileCategorizations(file));

        //public Task UpdateClientInternalNotes(string quoteId, string note)
        //    => Put(new ExecuteParams($"/v2/quotes/{quoteId}/internalNotes", new SingleValue(note)));

        //public Task UpdateOrderDate(string quoteId, DateTime date)
        //    => Put(new ExecuteParams($"/v2/quotes/{quoteId}/orderDate", new Data.Time(date)));

        //public Task UpdateSourceLanguage(string quoteId, Data.SourceLanguage sourceLanguage)
        //    => Put(new ExecuteParams($"/v2/quotes/{quoteId}/sourceLanguage", sourceLanguage));

        public Task UpdateSpecialization(string quoteId, ProjectsSmart.Data.Specialization specialization)
            => Put(new ExecuteParams($"/v2/quotes/{quoteId}/specialization", specialization));

        public Task UpdateStatus(string quoteId, ProjectsSmart.Data.ProjectStatus projectStatus)
            => Put(new ExecuteParams($"/v2/quotes/{quoteId}/status", projectStatus));

        //public Task UpdateTargetLanguages(string quoteId, Data.TargetLanguages targetLanguages)
        //    => Put(new ExecuteParams($"/v2/quotes/{quoteId}/targetLanguages", targetLanguages));

        //public Task UpdateVendorInstructions(string quoteId, string instruction)
        //    => Put(new ExecuteParams($"/v2/quotes/{quoteId}/vendorInstructions", new SingleValue(instruction)));

        //public Task UpdateVolume(string quoteId, BigDecimal volume)
        //    => Put(new ExecuteParams($"/v2/quotes/{quoteId}/volume", new SingleValueLong(volume)));
        #endregion
    }
}
