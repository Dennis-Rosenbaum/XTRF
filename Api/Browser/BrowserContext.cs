using Xtrf.Api.Base;
using Xtrf.Api.Browser.Params;
using Xtrf.Core.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xtrf.Interface;

namespace Xtrf.Api.Browser
{
    public class BrowserContext : ContextBase
    {
        internal BrowserContext(IConnection xtrfConnection) : base(xtrfConnection) { }

        #region GET
        public Task<XtrfResult<Data.BrowserView>> Get(BrowserParams param) 
            => Get<Data.BrowserView>(new ExecuteParams($"/browser/", param));

        public async Task<List<Data.BrowserView>> GetAll(BrowserParams param)
        {
            var result = new List<Data.BrowserView>();

            var firstView = await Get(param);
            if (!firstView.Success)
                return result;

            var tasks = new List<Task<XtrfResult<Data.BrowserView>>>();
            for (int i = 2; i <= firstView.Result.header.pagination.pagesCount; i++)
            {
                
                param.SetPage(i);
                var task = Get(param);
                tasks.Add(Task.Run(async () => await task));
            }

            await Task.WhenAll(tasks);

            result.Add(firstView.Result);
            foreach (var task in tasks)
                result.Add(task.Result.Result);

            return result;
        }

        public async Task<List<T>> GetAll<T>(BrowserParams param) where T : IBrowserView, new()
        {
            var results = await GetAll(param);

            var tList = new List<T>();

            foreach (var result in results)
            {
                foreach (var row in result.rows)
                {
                    var t = new T();
                    t.SetResult(row.Value.columns);
                    tList.Add(t);
                }
            }

            return tList;
        }
        #endregion

    }
}
