using System.Threading.Tasks;
using Xtrf.Api.Base;
using Xtrf.Core.Data;
using Xtrf.Core.Dictionary;

namespace Xtrf.Api.JobsSmart
{
    public class JobContext : ContextBase
    {
        internal JobContext(Interface.IConnection xtrfConnection) : base(xtrfConnection) { }

        #region POST
        //public Task<Data.Project> Upload(string jobId, Data.FormDataMultiPart file)
        //    => Post<Data.Project>(new ExecuteParams("/v2/jobs/{jobId}/files/delivered/upload", newProject));

        public Task<ProjectsSmart.Data.File> Upload(string jobId, UploadParams uploadParam)
            => Upload<ProjectsSmart.Data.File>(new ExecuteParams($"/v2/jobs/{jobId}/files/delivered/upload"), uploadParam);
        #endregion

        #region GET
        public Task<XtrfResult<Data.Job>> Get(string jobId)
            => Get<Data.Job> (new ExecuteParams($"/v2/jobs/{jobId}"));

        public Task<XtrfResult<Data.Deliverables>> GetDeliveredFiles(string jobId)
            => Get<Data.Deliverables> (new ExecuteParams($"/v2/jobs/{jobId}/files/delivered"));
        
        public Task<XtrfResult<Data.Deliverables>> GetSharedReferenceFiles(string jobId)
            => Get<Data.Deliverables> (new ExecuteParams($"/v2/jobs/{jobId}/files/sharedReferenceFiles"));

        public Task<XtrfResult<Data.Deliverables>> GetSharedWorkFiles(string jobId)
            => Get<Data.Deliverables> (new ExecuteParams($"/v2/jobs/{jobId}/files/sharedWorkFiles"));
        #endregion

        #region PUT
        /* TODO:
         * /v2/jobs/{jobId}/files/delivered/add 
         * /v2/jobs/{jobId}/files/sharedReferenceFiles/share
         * /v2/jobs/{jobId}/files/sharedWorkFiles/share
         * /v2/jobs/{jobId}/files/stopSharing
         * 
         * 
         */
        public Task AddDeliveredFiles(string jobId, ProjectsSmart.Data.FileCategorizations files)
           => Put(new ExecuteParams($"/v2/jobs/{jobId}/files/delivered/add", files));

        public Task AddDeliveredFile(string jobId, ProjectsSmart.Data.FileCategorization file) 
            => AddDeliveredFiles(jobId, new ProjectsSmart.Data.FileCategorizations(file));


        public Task ShareWorkFiles(string jobId, FilesDto files)
            => Put(new ExecuteParams($"/v2/jobs/{jobId}/files/sharedWorkFiles/share", files));
        public Task ShareWorkFile(string jobId, string fileId) 
            => ShareWorkFiles(jobId, new FilesDto(fileId));

        public Task UpdateInstructions(string jobId, string instructions)
            => Put (new ExecuteParams($"/v2/jobs/{jobId}/instructions", new SingleValue(instructions)));

        public Task AssignVendor(string jobId, int vendorPriceProfileId)
            => Put(new ExecuteParams($"/v2/jobs/{jobId}/vendor", new Data.VendorPriceProfile(vendorPriceProfileId)));

        public Task UpdateStatus(string jobId, JobStatus status)
            => Put(new ExecuteParams($"/v2/jobs/{jobId}/status", new Data.AddJobStatus(status)));
        #endregion
    }
}
