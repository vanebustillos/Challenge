﻿using System;

namespace DemoLibrary
{
    public interface IGeneralTicket
    {
        DateTime Date { get; set; }
        string Entrance { get; }
        string Event { get; set; }
        int Price { get; set; }
        int TicketCode { get; set; }

        void SellTicket();
    }
}