namespace general.Feature
{
    public abstract class PatternMatching
    {
        public record Order(string Status, decimal Cost);
        public record Reference(int Id, bool Completed);

        public abstract void UpdatePendingOrder(Order order);
        public abstract void UpdateCancelledOrder(Order order);
        public abstract void UpdateCompletedOrder(Order order);
        public abstract Reference GetPendingOrderRef(Order order);
        public abstract Reference GetCancelledOrderRef(Order order);
        public abstract Reference GetCompletedOrderRef(Order order);
        public abstract void SendEmail(Order order);
        public abstract void SendKpis(Order order);

        #region switch statement

        public void NestedIfElseStatement(Order order)
        {
            // DON'T DO THIS
            if (order.Status == "Pending")
            {
                UpdatePendingOrder(order);
                SendKpis(order);
            }
            else if (order.Status == "Completed")
            {
                UpdateCompletedOrder(order);
                SendKpis(order);
            }
            else if (order.Status == "Cancelled")
            {
                UpdateCancelledOrder(order);
                SendEmail(order);
            }
            else
            {
                throw new InvalidOperationException("Unknown status");
            }
        }

        // switch statement - we have no return value
        public void SwitchStatement(Order order)
        {
            switch (order.Status)
            {
                case "Pending":
                    UpdatePendingOrder(order);
                    SendKpis(order);
                    break;
                case "Completed":
                    UpdateCompletedOrder(order);
                    SendKpis(order);
                    break;
                case "Cancelled":
                    UpdateCancelledOrder(order);
                    SendEmail(order);
                    break;
                default:
                    throw new InvalidOperationException("Unknown status");
            }
        }

        #endregion

        #region switch expression

        public Reference NestedIfElseExpression(Order order)
        {
            // DON'T DO THIS
            if (order.Status == "Pending")
            {
                return GetPendingOrderRef(order);
            }
            else if (order.Status == "Completed")
            {
                return GetCompletedOrderRef(order);
            }
            else if (order.Status == "Cancelled")
            {
                return GetCancelledOrderRef(order);
            }
            else
            {
                throw new InvalidOperationException("Unknown status");
            }
        }

        // switch expression - one value maps to one return value and we have no secondary side effects or tasks that need to be launched
        public Reference SwitchExpression(Order order) =>
            order.Status switch
            {
                "Pending" => GetPendingOrderRef(order),
                "Completed" => GetCompletedOrderRef(order),
                "Cancelled" => GetCancelledOrderRef(order),
                _ => throw new InvalidOperationException("Unknown status"),
            };

        public string CheckReferenceId(Reference reference) =>
            reference.Id switch
            {
                <=100 => "system values",
                >100 and <=1000 => "test references",
                >1000 => "customer order",
            };

        public string CheckMultipleValues(Reference reference) =>
            reference switch
            {
                { Id: <= 100, Completed: false } => "system values - to do",
                { Id: <= 100, Completed: true } => "system values - done",
                { Id: >= 1000, Completed: false } => "customer orders - to ship",
                null => throw new ArgumentNullException(nameof(reference), "can't act on null"),
            };

        #endregion
    }
}
