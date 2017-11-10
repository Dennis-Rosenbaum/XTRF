namespace Xtrf.Interface
{
    public interface IConnection
    {
        string AuthenticationToken { get; set; }
        string AuthenticationTokenProjectManager { get; set; }
        string RootUrl { get; set; }
    }
}
