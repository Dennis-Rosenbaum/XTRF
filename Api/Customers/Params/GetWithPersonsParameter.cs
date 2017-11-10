namespace Xtrf.Api.Customers.Params
{
    public class GetWithPersonsParameter : Base.ParameterBase
    {
        public GetWithPersonsParameter() { }
        public GetWithPersonsParameter(string embed)
        {
            SetEmbed(embed);
        }

        public void SetEmbed(string embed) => SetParam("embed", embed);

    }
}
