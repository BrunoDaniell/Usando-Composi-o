using System;
using FixacaoComp.Entities.Enums;
using FixacaoComp.Entities;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using System.Globalization;

namespace FixacaoComp.Entities
{
    internal class Order
    {

        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }

        public ClientBase Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(DateTime momment, OrderStatus status, ClientBase client)
        {
            Momment = momment;
            Status = status;
            Client = client;
        }

        public void AddItems(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItems(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Items)
            {
                sum += item.Subtotal();
            }
            
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order momment: " + Momment.ToString("dd / MM / yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items:");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture ));

            return sb.ToString();
        }
    }
}
