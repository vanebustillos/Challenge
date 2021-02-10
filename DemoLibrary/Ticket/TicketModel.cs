using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class TicketModel : ITicketModel
    {
        public int TicketCode { get; set; }
        public string Event { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public void SellTicket()
        {
            Console.WriteLine($"You have an incoming event: { Event } on { Date }.");
        }
    }
}
