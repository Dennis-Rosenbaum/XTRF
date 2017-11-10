using System;

namespace Xtrf.Api.Services.Params
{
    public class GetParameter : Base.ParameterBase
    {
        /// <summary>
        /// Exact name of the entity
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name) => SetParam("nameEquals", name);
    }
}
