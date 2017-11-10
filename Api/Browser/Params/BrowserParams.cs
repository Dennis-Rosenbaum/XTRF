using System;
using System.Collections.Generic;
using System.Linq;
using Xtrf.Helper;

namespace Xtrf.Api.Browser.Params
{
    public class BrowserParams : Base.ParameterBase
    {
        public BrowserParams(long viewId)
        {
            SetViewId(viewId);
        }

        public void SetViewId(long viewId) => SetParam("viewId", viewId);
        public void SetPage(int pageNumber) => SetParam("page", pageNumber);

        public void AddTextQuery(string name, QueryTextType type, string value)
        {
            string itemFilter;
            switch (type)
            {
                case QueryTextType.Equals: itemFilter = "eq"; break;
                case QueryTextType.StartsWith: itemFilter = "startsWith"; break;
                case QueryTextType.EndsWith: itemFilter = "endsWith"; break;
                case QueryTextType.Contains: itemFilter = "ilike"; break;
                case QueryTextType.WithWildcard: itemFilter = "withWildcards"; break;
                default: throw new NotSupportedException($"The type {type} does not exist within the QueryTextType enum.");
            }

            value = System.Net.WebUtility.UrlEncode(value);
            string item = $"{itemFilter}({value})";
            SetParam(GetParamName(name), item);
        }

        public void AddYesNoQuery(string name, bool value)
        {
            string item = value ? "yes" : "no";
            SetParam(GetParamName(name), item);
        }

        public void AddSelectionQuery(string name, QuerySelectionType type, object selection)
            => AddSelectionQuery(name, type, new List<object> { selection });
        public void AddSelectionQuery(string name, QuerySelectionType type, List<object> selection)
        {
            string itemFilter;
            switch (type)
            {
                case QuerySelectionType.AnyOf: itemFilter = "anyOf"; break;
                case QuerySelectionType.NoneOf: itemFilter = "noneOf"; break;
                case QuerySelectionType.AllOf: itemFilter = "allOf"; break;
                default: throw new NotSupportedException($"The type {type} does not exist within the QuerySelectionType enum.");
            }
            
            var value = string.Join(",", selection?.Select(c => c.ToString()) ?? new List<string>());

            value = System.Net.WebUtility.UrlEncode(value);
            string item = $"{itemFilter}({value})";
            SetParam(GetParamName(name), item);
        }

        public void AddPercentageQuery(string name, QueryPercentageType type, double value)
        {
            string itemFilter;
            switch (type)
            {
                case QueryPercentageType.LowerThan: itemFilter = "lt"; break;
                case QueryPercentageType.LowerOrEqual: itemFilter = "le"; break;
                case QueryPercentageType.GreaterThan: itemFilter = "gt"; break;
                case QueryPercentageType.GreaterOrEqual: itemFilter = "ge"; break;
                default: throw new NotSupportedException($"The type {type} does not exist within the QueryPercentageType enum.");
            }
            
            string item = $"{itemFilter}({value.ToUsNotation()}%)";
            SetParam(GetParamName(name), item);
        }

        public void AddPercentageRangeQuery(string name, double from, double to)
        {
            var item = GetRangeValue(from, to, "%");
            SetParam(GetParamName(name), item);
        }

        public void AddMoneyQuery(string name, QueryMoneyType type, double value)
        {
            string itemFilter;
            switch (type)
            {
                case QueryMoneyType.LowerThan: itemFilter = "lt"; break;
                case QueryMoneyType.GreaterThan: itemFilter = "gt"; break;
                default: throw new NotSupportedException($"The type {type} does not exist within the QueryMoneyType enum.");
            }
            
            var currencySign = "€";
            string valueString = value.ToString().Replace(',', '.');
            string item = $"{itemFilter}({valueString}{currencySign})";
            SetParam(GetParamName(name), item);
        }

        public void AddMoneyRangeQuery(string name, double from, double to)
        {
            var item = GetRangeValue(from, to, "€");
            SetParam(GetParamName(name), item);
        }

        public void AddLanguageCombinationQuery(long? sourceLan = null, long? targetLan = null)
        {
            string paramName = GetParamName("languageCombination");
            string source = sourceLan == null ? "any" : sourceLan.ToString();
            string target = targetLan == null ? "any" : targetLan.ToString();
            string item = $"{source},{target}";
            SetParam(paramName, item);
        }

        public void AddDateQuery(string name, QueryDateType type, DateTime date)
        {
            long dateLong = UnixTimeHelper.UnixTimeLong(date);
            string itemFilter;
            switch (type)
            {
                case QueryDateType.After: itemFilter = "from"; break;
                case QueryDateType.Before: itemFilter = "to"; break;
                default: throw new NotSupportedException($"The type {type} does not exist within the QueryDateType enum.");
            }

            string item = $"{itemFilter}({dateLong})";
            SetParam(GetParamName(name), item);
        }

        public void AddDateRangeQuery(string name, DateTime from, DateTime to)
        {
            long fromLong = UnixTimeHelper.UnixTimeLong(from);
            long toLong = UnixTimeHelper.UnixTimeLong(to);
            string value = $"fromTo({fromLong},{toLong})";

            SetParam(GetParamName(name), value);
        }

        public void AddNumberQuery(string name, QueryNumberType type, double value)
        {
            string itemFilter;
            switch (type)
            {
                case QueryNumberType.LowerThan: itemFilter = "lt"; break;
                case QueryNumberType.LowerOrEqual: itemFilter = "le"; break;
                case QueryNumberType.Equals: itemFilter = "eq"; break;
                case QueryNumberType.GreaterThan: itemFilter = "gt"; break;
                case QueryNumberType.GreaterOrEqual: itemFilter = "ge"; break;
                default: throw new NotSupportedException($"The type {type} does not exist within the QueryNumberType enum.");
            }
            
            string item = $"{itemFilter}({value.ToUsNotation()})";
            SetParam(GetParamName(name), item);
        }

        public void AddNumberRangeQuery(string name, double from, double to)
        {
            var item = GetRangeValue(from, to);
            SetParam(GetParamName(name), item);
        }

        private string GetRangeValue(double from, double to, string sign = "")
        {
            string f = from.ToUsNotation();
            string t = to.ToUsNotation();
            return $"range({f}{sign},{t}{sign})";
        }

        private string GetParamName(string name) => $"q.{name}";
    }
}
