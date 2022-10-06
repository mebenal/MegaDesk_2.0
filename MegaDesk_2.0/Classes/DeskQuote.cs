using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Ebenal
{
    enum DeliveryType
    {
        [Description("3 Day Shipping")]
        ThreeDay = 60,
        [Description("5 Day Shipping")]
        FiveDay = 40,
        [Description("7 Day Shipping")]
        SevenDay = 30,
        [Description("Standard Shipping")]
        FourteenDay = 0
    }

    internal class DeskQuote
    {
        public DateTime QuoteDate { get; set; }
        public string CustomerName { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public decimal QuoteAmount { get; set; }
        public Desk Desk { get; set; }

        public DeskQuote(
            string customerName,
            DeliveryType deliveryType,
            Desk desk)
        {
            QuoteDate = DateTime.Now;
            CustomerName = customerName;
            DeliveryType = deliveryType;
            Desk = desk;
            QuoteAmount = GetQuotePrice();
        }

        public decimal GetQuotePrice()
        {
            return 0;
        }
    }
}
