using System;
using System.Threading.Tasks;
using Xtrf.Api.Base;
using Xtrf.Core.Data;
using BigDecimal = System.Nullable<long>;

namespace Xtrf.Api.ProjectsSmart
{
    public class ProjectContext : ContextBase
    {
        internal ProjectContext(Interface.IConnection xtrfConnection) : base(xtrfConnection) { }

        #region POST
        public Task<XtrfResult<Data.Project>> CreateNew(Data.ProjectCreate newProject)
            => Post<Data.Project>(new ExecuteParams("/v2/projects", newProject) { ExecuteByProjectManager = true });

        public Task<ProjectsSmart.Data.File> Upload(string projectId, UploadParams uploadParams)//, Data.FormDataMultiPart file)
            => base.Upload<ProjectsSmart.Data.File>(new ExecuteParams($"/v2/projects/{projectId}/files/upload"), uploadParams);

        //public Task<Data.FileArchive> Archive(Data.FileList files)
        //    => Post<Data.FileArchive>(new ExecuteParams($"/v2/projects/files/archive", files));
        #endregion

        #region GET
        public Task<XtrfResult<Data.ProjectFile>> GetFile(string fileId)
            => Get<Data.ProjectFile>(new ExecuteParams($"/v2/projects/files/{fileId}"));
                     
        public async Task<byte[]> DownloadFile(string fileId, string fileName)
            => (await Get(new ExecuteParams($"/v2/projects/files/{fileId}/download/{fileName}") { AsBytes = true })).ByteResponse;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectId">KVVV24S34ZC65LB5MXQ3GSFFUY</param>
        /// <param name="asBytes"></param>
        /// <returns></returns>
        public Task<XtrfResult<Data.Project>> Get(string projectId, bool asBytes = false)
            => Get<Data.Project>(new ExecuteParams($"/v2/projects/{projectId}"));

        public Task<XtrfResult<Data.SmartContacts>> GetClientContacts(string projectId)
            => Get<Data.SmartContacts>(new ExecuteParams($"/v2/projects/{projectId}/clientContacts"));

        public Task<XtrfResult<CustomFields>> GetCustomFields(string projectId)
            => Get<CustomFields>(new ExecuteParams($"/v2/projects/{projectId}/customFields"));

        public Task<XtrfResult<Data.ProjectFiles>> GetFiles(string projectId)
            => Get<Data.ProjectFiles>(new ExecuteParams($"/v2/projects/{projectId}/files"));

        public Task<XtrfResult<Data.ProjectFiles>> GetFileDeliverables(string projectId)
            => Get<Data.ProjectFiles>(new ExecuteParams($"/v2/projects/{projectId}/files/deliverable"));

        public Task<XtrfResult<Data.Finance>> GetFinance(string projectId)
            => Get<Data.Finance>(new ExecuteParams($"/v2/projects/{projectId}/finance"));

        public Task<XtrfResult<JobsSmart.Data.Jobs>> GetJobs(string projectId)
            => Get<JobsSmart.Data.Jobs>(new ExecuteParams($"/v2/projects/{projectId}/jobs"));
        #endregion

        #region PUT
        public Task<XtrfResult<Data.Contacts>> UpdateClientContacts(string projectId, Data.SmartContacts contacts)
            => Put<Data.Contacts>(new ExecuteParams($"/v2/projects/{projectId}/clientContacts", contacts));

        public Task UpdateClientDeadline(string projectId, DateTime date)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/clientDeadline", new Data.Time(date)));

        public Task UpdateClientNotes(string projectId, string note)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/clientNotes", new SingleValue(note)));

        public Task UpdateClientReferenceNumber(string projectId, string referenceNumber)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/clientReferenceNumber", new SingleValue(referenceNumber)));

        public Task UpdateCustomField(string projectId, string key, string value)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/customFields/{key}", new SingleValue(value)));

        /// <summary>
        /// Adds files to the project as added by PM.The files have to be uploaded beforehand(see "POST /v2/projects/{projectId}/files/upload" operation). The following properties can be specified for each file:
        /// 
        /// category(required, 400 Bad Request is returned otherwise)
        /// languageIds – when the file category depends on a list of languages
        /// languageCombinationIds – when the file category depends on a list of language combinations
        /// </summary>
        public Task AddFiles(string projectId, Data.FileCategorizations files)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/files/add", files));

        public Task AddFile(string projectId, Data.FileCategorization file) 
            => AddFiles(projectId, new Data.FileCategorizations(file));

        public Task UpdateClientInternalNotes(string projectId, string note)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/internalNotes", new SingleValue(note)));

        public Task UpdateOrderDate(string projectId, DateTime date)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/orderDate", new Data.Time(date)));

        public Task UpdateSourceLanguage(string projectId, Data.SourceLanguage sourceLanguage)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/sourceLanguage", sourceLanguage));

        public Task UpdateSpecialization(string projectId, Data.Specialization specialization)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/specialization", specialization));

        public Task UpdateStatus(string projectId, Data.ProjectStatus projectStatus)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/status", projectStatus));

        public Task UpdateTargetLanguages(string projectId, Data.TargetLanguages targetLanguages)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/targetLanguages", targetLanguages));

        public Task UpdateVendorInstructions(string projectId, string instruction)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/vendorInstructions", new SingleValue(instruction)));

        public Task UpdateVolume(string projectId, BigDecimal volume)
            => Put(new ExecuteParams($"/v2/projects/{projectId}/volume", new SingleValueLong(volume)));
        #endregion
    }
}
