using Contoso.Store.Domain.Contexts.Enums;
using Contoso.Store.Shared.BaseEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Store.Domain.Contexts.Entities
{
    public class Delivery : Entity
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            CreatedDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }

        public DateTime CreatedDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }

        public void Sent()
        {
            Status = EDeliveryStatus.Sent;
        }

        public void Cancel()
        {
            Status = EDeliveryStatus.Canceled;
        }

        public void Send()
        {
            Status = EDeliveryStatus.Sent;
        }
    }
}
