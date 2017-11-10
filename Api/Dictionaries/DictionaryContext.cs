using System.Threading.Tasks;
using Xtrf.Api.Base;
using Xtrf.Api.Dictionaries.Data;

namespace Xtrf.Api.Dictionaries
{
    public class DictionaryContext : ContextBase
    {
        internal DictionaryContext(Interface.IConnection xtrfConnection) : base(xtrfConnection) { }

        #region GET
        public Task<XtrfResult<ManyValuesPerType>> GetAll()
             => Get<ManyValuesPerType>(new ExecuteParams($"/dictionaries/all"));
        public Task<XtrfResult<ManyValuesPerType>> GetActive()
             => Get<ManyValuesPerType>(new ExecuteParams($"/dictionaries/active"));
        #endregion

    }
}
