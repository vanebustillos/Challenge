﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class GeneralTicket : ITicketModel, IGeneralTicket
    {
        public int TicketCode { get; set; }
        public string Event { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public string Entrance { get; private set; } = "General";
        public void SellTicket()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine($"You have to pay { Price } Bs.");
            Console.WriteLine($"You have an incoming event: { Event } on { Date }. Your entrance is { Entrance }.");
        }
    }
}
