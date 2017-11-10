using System.Linq;
using System.Threading.Tasks;
using Xtrf.Api.Base;
using Xtrf.Api.Macro.Data;

namespace Xtrf.Api.Macro
{
    public class ExecuteMacroContext : ContextBase
    {
        internal ExecuteMacroContext(Interface.IConnection xtrfConnection) : base(xtrfConnection) { }
        
        #region GET
        public Task<string> Execute(int macroId, params long[] ids)
            => ExecuteResult(ExecuteRun(macroId, ids));

        private async Task<string> ExecuteResult(Task<XtrfResult<GetActionResult>> macroResult)
        {
            var runMacroResult = await macroResult;
            if (!runMacroResult.Success)
                return runMacroResult.ErrorMessage;
            if (runMacroResult.Result == null)
                return "no result";
            var result = (await ExecuteGetOutput(runMacroResult.Result.Url)).Result;
            if (result.EndsWith("\n")) result = result.Substring(0, result.Length - 1);
            return result;
        }

        private Task<XtrfResult<string>> ExecuteGetOutput(string outputUrl) 
            => Get<string>(new ExecuteParams(outputUrl));
        
        private Task<XtrfResult<GetActionResult>> ExecuteRun(int macroId, long[] ids)
            => RunMacro(macroId, new { ids = ids.Select(i => i.ToString()) });
            
        private Task<XtrfResult<GetActionResult>> RunMacro(int macroId, dynamic d)
            => Post<GetActionResult>(new ExecuteParams($"/macros/{macroId}/run?async=true", d));
        #endregion

    }
}
