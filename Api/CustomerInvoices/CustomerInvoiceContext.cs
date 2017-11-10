using System.Collections.Generic;
using System.Threading.Tasks;
using Xtrf.Api.Base;
using Xtrf.Api.CustomerInvoices.Data;
using Xtrf.Api.CustomerInvoices.Params;
using Xtrf.Core.Data;
using Xtrf.Core.Params;

namespace Xtrf.Api.CustomerInvoices
{
    public class CustomerInvoiceContext : ContextBase
    {
        internal CustomerInvoiceContext(Interface.IConnection xtrfConnection) : base(xtrfConnection) { }

        #region POST
        public Task<XtrfResult<CustomerInvoiceCreateResult>> CreateNew(CustomerInvoiceCreate newInvoice)
            => Post<CustomerInvoiceCreateResult>(new ExecuteParams("/accounting/customers/invoices", newInvoice));

        public Task<XtrfResult<SendRemindersResponse>> SendReminders(SendRemindersRequest request)
            => Post<SendRemindersResponse>(new ExecuteParams("/accounting/customers/invoices/sendReminders", request));

        public Task SendReminder(long invoiceId)
            => Post(new ExecuteParams($"/accounting/customers/invoices/{invoiceId}/sendReminder"));

        public Task<XtrfResult<CustomerInvoice>> DuplicateInvoice(long invoiceId)
            => Post<CustomerInvoice>(new ExecuteParams($"/accounting/customers/invoices/{invoiceId}/duplicate"));

        public Task<XtrfResult<CustomerInvoice>> DuplicateInvoiceProForma(long invoiceId)
            => Post<CustomerInvoice>(new ExecuteParams($"/accounting/customers/invoices/{invoiceId}/duplicate/proForma"));
        #endregion

        #region GET
        public Task<XtrfResult<List<long>>> GetAllIds(UpdatedSinceParameter param = null)
             => Get<List<long>> (new ExecuteParams($"/accounting/customers/invoices/ids", param));

        public Task<XtrfResult<CustomerInvoice>> GetSingle(long invoiceId, GetSingleParameter param = null)
             => Get<CustomerInvoice>(new ExecuteParams($"/accounting/customers/invoices/{invoiceId}", param));

        public Task<XtrfResult<CustomerInvoiceDates>> GetDates(long invoiceId)
             => Get<CustomerInvoiceDates>(new ExecuteParams($"/accounting/customers/invoices/{invoiceId}/dates"));

        public Task<XtrfResult<DocumentUrl>> GetDocument(long invoiceId)
             => Get<DocumentUrl>(new ExecuteParams($"/accounting/customers/invoices/{invoiceId}/document"));

        public Task<XtrfResult<PaymentTerms>> GetPaymentTerm(long invoiceId)
             => Get<PaymentTerms>(new ExecuteParams($"/accounting/customers/invoices/{invoiceId}/paymentTerms"));
        #endregion
    }
}
