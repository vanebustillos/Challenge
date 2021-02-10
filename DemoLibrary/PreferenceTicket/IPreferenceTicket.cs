using System;

namespace DemoLibrary
{
    public interface IPreferenceTicket
    {
        DateTime Date { get; set; }
        string Event { get; set; }
        int Price { get; set; }
        string Seat { get; set; }
        int TicketCode { get; set; }

        void SellTicket();
    }
}