using Xtrf.Common.Attribute;

namespace Xtrf.Core.Dictionary
{
    public static class JobStatusHelper
    {
        public static string GetName(JobStatus status)
        {
            switch (status)
            {
                case JobStatus.Open: return "Opened";
                case JobStatus.Accepted: return "Accepted";
                case JobStatus.Started: return "Started";
                case JobStatus.Ready: return "Ready";
                case JobStatus.Canceled: return "Canceled";
                //case JobStatus.OffersSent: return "Offers_sent";
                default: return string.Empty;
            }
        }

        public static JobStatus GetEnum(string status)
        {
            if (status.Equals("opened", System.StringComparison.InvariantCultureIgnoreCase)) return JobStatus.Open;
            if (status.Equals("accepted", System.StringComparison.InvariantCultureIgnoreCase)) return JobStatus.Accepted;
            if (status.Equals("started", System.StringComparison.InvariantCultureIgnoreCase)) return JobStatus.Started;
            if (status.Equals("ready", System.StringComparison.InvariantCultureIgnoreCase)) return JobStatus.Ready;
            if (status.Equals("canceled", System.StringComparison.InvariantCultureIgnoreCase)) return JobStatus.Canceled;

            return JobStatus.Open;
        }
    }
    public enum JobStatus
    {
        /// <summary>
        /// OPEN – available when the job has one of the following statuses: ACCEPTED, CANCELED
        /// </summary>
        [EnumName("OPEN")]
        Open,
        /// <summary>
        /// ACCEPTED – available when the job has one of the following statuses: OPEN (Vendor and dates have to be set before calling the operation), STARTED
        /// </summary>
        [EnumName("ACCEPTED")]
        Accepted,
        /// <summary>
        /// STARTED – available when the job has one of the following statuses: ACCEPTED, READY
        /// </summary>
        [EnumName("STARTED")]
        Started,
        /// <summary>
        /// READY – available when the job has one of the following statuses: STARTED
        /// </summary>
        [EnumName("READY")]
        Ready,
        /// <summary>
        /// CANCELED – available when the job has one of the following statuses: OPEN, ACCEPTED, STARTED, OFFERS_SENT
        /// </summary>
        [EnumName("CANCELED")]
        Canceled,
        /// <summary>
        /// OFFERS_SENT – not available as a target status for this operation
        /// </summary>
        [EnumName("OFFERS_SENT")]
        OffersSent
    }
}
