namespace Xtrf.Api.CustomerInvoices.Params
{
    public class GetSingleParameter : Base.ParameterBase
    {
        public void SetEmbed(string embed) => SetParam("embed", embed);
    }
}
