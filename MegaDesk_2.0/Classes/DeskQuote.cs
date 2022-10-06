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

        public string[] Stringify()
        {
            string[] stringQuote =
            {
                QuoteDate.ToString(),
                CustomerName,
                Desk.Width.ToString(),
                Desk.Depth.ToString(),
                Desk.NumberOfDrawers.ToString(),
                Desk.DeskMaterial.ToString(),
                DeliveryString(),
                QuoteAmount.ToString(),
            };
            return stringQuote;
        }

        private string DeliveryString()
        {
            switch (DeliveryType)
            {
                case DeliveryType.FourteenDay:
                    return "14 Days";
                case DeliveryType.SevenDay:
                    return "7 Days";
                case DeliveryType.FiveDay:
                    return "5 days";
                case DeliveryType.ThreeDay:
                    return "3 Days";
            }
            return "Not Specified";
        }
    }
}
