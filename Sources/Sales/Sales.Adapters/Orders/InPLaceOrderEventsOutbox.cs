using System.Diagnostics.CodeAnalysis;
using MyCompany.Crm.TechnicalStuff.Outbox;
using MyCompany.Crm.TechnicalStuff.Outbox.Postgres;
using MyCompany.Crm.TechnicalStuff.UseCases;

namespace MyCompany.Crm.Sales.Orders
{
    public class InPLaceOrderEventsOutbox : InPlaceTransactionalOutbox<OrderEvent>, OrderEventsOutbox
    {
        [SuppressMessage("ReSharper", "SuggestBaseTypeForParameterInConstructor",
            Justification = "Required by DI container")]
        public InPLaceOrderEventsOutbox(TransactionalOutboxes outboxes, PostgresOutboxRepository<SalesDb> repository,
            MessageTypes messageTypes)
            : base(outboxes, repository, messageTypes) { }

        protected override string GetPartitionKeyFor(OrderEvent message) => message.OrderId.ToString("N");
    }
}