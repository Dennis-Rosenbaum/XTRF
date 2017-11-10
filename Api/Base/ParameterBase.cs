using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Xtrf.Api.Base
{
    public abstract class ParameterBase : Dictionary<string, object>
    {
        public string ConstructQueryString() => string.Join("&", Keys.Select(a => a + "=" + this[a].ToString()));

        //public NameValueCollection ConstructQueryString()
        //{
        //    NameValueCollection queryString = new NameValueCollection();

        //    foreach (var p in this)
        //        queryString.Add(p.Key, p.Value.ToString());

        //    return queryString;
        //}

        protected void SetParam(string paramName, object item)
        {
            if (ContainsKey(paramName))
                this[paramName] = item;
            else
                Add(paramName, item);
        }
    }
}
