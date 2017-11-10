namespace Xtrf
{
    public class ApiContext
    {
        public Api.Browser.BrowserContext Browser => new Api.Browser.BrowserContext(XtrfConnection);
        public Api.CustomerInvoices.CustomerInvoiceContext CustomerInvoice => new Api.CustomerInvoices.CustomerInvoiceContext(XtrfConnection);
        public Api.Customers.CustomerContext Customer => new Api.Customers.CustomerContext(XtrfConnection);
        public Api.Dictionaries.DictionaryContext Dictionary => new Api.Dictionaries.DictionaryContext(XtrfConnection);
        public Api.ProjectsSmart.ProjectContext Project => new Api.ProjectsSmart.ProjectContext(XtrfConnection);
        public Api.QuotesSmart.QuoteContext Quote => new Api.QuotesSmart.QuoteContext(XtrfConnection);
        public Api.Services.ServicesContext Service => new Api.Services.ServicesContext(XtrfConnection);
        public Api.Users.UserContext Users => new Api.Users.UserContext(XtrfConnection);
        public Api.Vendors.VendorContext Vendors => new Api.Vendors.VendorContext(XtrfConnection);
        public Api.Subscription.SubscriptionContext Subscriptions => new Api.Subscription.SubscriptionContext(XtrfConnection);
        public Api.JobsSmart.JobContext Jobs => new Api.JobsSmart.JobContext(XtrfConnection);
        public Api.Macro.ExecuteMacroContext Macro => new Api.Macro.ExecuteMacroContext(XtrfConnection);

        private static volatile ApiContext instance;
        private static object syncRoot = new object();

        public Interface.IConnection XtrfConnection { get; set; }

        private ApiContext() { }

        public static ApiContext Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ApiContext();
                    }
                }

                return instance;
            }
        }
    }
}
