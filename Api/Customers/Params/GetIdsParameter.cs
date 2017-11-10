using System;

namespace Xtrf.Api.Customers.Params
{
    public class GetIdsParameter : Base.ParameterBase
    {
        public void SetUpdatedSince(DateTime since) => SetParam("updatedSince", Helper.UnixTimeHelper.UnixTimeLong(since));
        public void SetName(string name) => SetParam("nameEquals", name);

    }
}
