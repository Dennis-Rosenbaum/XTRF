using System;

namespace Xtrf.Core.Params
{
    public class UpdatedSinceParameter : Api.Base.ParameterBase
    {
        public void SetUpdatedSince(DateTime since) => SetParam("updatedSince", Helper.UnixTimeHelper.UnixTimeLong(since));

    }
}
