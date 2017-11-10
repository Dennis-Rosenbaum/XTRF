using Newtonsoft.Json;
using System.Linq;
using System.Text;

namespace Xtrf.Api.Base
{
    public class UploadParams
    {
        private byte[] FileBytes { get; set; }
        //private string FileName { get; set; }
        private string FileContent { get; set; }
        //private string FileExtension { get; set; }

        public string FileName { get; set; }

        public UploadParams(byte[] content, string name)
        {
            FileBytes = content;
            FileName = $"{name}";
        }

        public UploadParams(string content, string name, string extension)
        {
            FileName = $"{name}.{extension}";
            FileContent = content;
        }

        public byte[] GetFileBytes()
        {
            if (FileBytes != null && FileBytes.Any())
                return FileBytes;

            return Encoding.UTF8.GetBytes(FileContent);
        }
    }
}
