using System;

namespace DemoLibrary
{
    public interface ITicketModel
    {
        DateTime Date { get; set; }
        string Event { get; set; }
        int Price { get; set; }
        int TicketCode { get; set; }
        void SellTicket();
    }
}