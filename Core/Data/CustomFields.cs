using System.Collections.Generic;

namespace Xtrf.Core.Data
{
    public class CustomFields : List<CustomField>
    {
        public CustomFields() { }

        public CustomFields(string key, string value)
        {
            Add(new CustomField() { Key = key, Value = value });
        }
    }
}
