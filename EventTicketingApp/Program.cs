using DemoLibrary;
using System;

namespace EventTicketingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the section of the ticket: ");
            string ticketType = Console.ReadLine().ToLower();
            
            switch (ticketType)
            {
                case "preference":
                    IPreferenceTicket preferenceTicket = new PreferenceTicket();
                    preferenceTicket.TicketCode = 121;
                    preferenceTicket.Event = "Local game";
                    preferenceTicket.Seat = "12B";
                    preferenceTicket.Price = 70;
                    preferenceTicket.SellTicket();
                    break;
                case "general":
                    IGeneralTicket generalTicket = new GeneralTicket();
                    generalTicket.TicketCode = 122;
                    generalTicket.Event = "Local game";
                    generalTicket.Price = 50;
                    generalTicket.SellTicket();
                    break;
                case "south curve":
                    ISouthCurveTicket southCurveTicket = new SouthCurveTicket();
                    southCurveTicket.TicketCode = 123;
                    southCurveTicket.Event = "Local game";
                    southCurveTicket.Price = 30;
                    southCurveTicket.SellTicket();
                    break;
                case "north curve":
                    INorthCurveTicket northCurveTicket = new NorthCurveTicket();
                    northCurveTicket.TicketCode = 124;
                    northCurveTicket.Event = "Local game";
                    northCurveTicket.Price = 40;
                    northCurveTicket.SellTicket();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
