using System;
using System.Collections.Generic;
using BowlingAlleyDAL;
using BowlingAlleyDAL.Models;
using System.Linq;

namespace BowlingAlleyApp
{
    class Program
    {
        static BowlingAlleyRepository rep = new BowlingAlleyRepository();
        static void Main(string[] args)
        {
            //GetFreeSlots();
            //ApproveOrReject();
            //GetReservedSlots();
            //GetAllRejectedSlots();
            //BookSlots();
            //GetAdminName();
        }
        static void GetFreeSlots()
        {
            List<BookingSlots> slots = rep.GetFreeSlots();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("{0}\t{1}\t{2}", "SlotId", "SlotStartTime", "SlotEndTime");
            Console.WriteLine("-----------------------------------");
            foreach (var s in slots)
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.SlotId, s.SlotStartTime, s.SlotEndTime);
            }
            Console.WriteLine();
        }
        static void ApproveOrReject()
        {
            int result = rep.ApproveOrReject(2, 0);
            if (result > 0)
            {
                Console.WriteLine("Status updated");
            }
            else
            {
                Console.WriteLine("Some error. Try again!!!");
            }
        }
        static void GetReservedSlots()
        {
            List<Reservations> slots = rep.GetReservedSlots();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("{0}\t{1}\t{2}", "ReservationId", "ReservedBy", "SlotId");
            Console.WriteLine("--------------------------------------");
            foreach (var s in slots)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", s.ReservationId, s.ReservedBy, s.SlotId);
            }
            Console.WriteLine();
        }
        static void GetAllRejectedSlots()
        {
            List<ReservationDetails> slots = rep.GetAllRejectedSlots();
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t{4}\t{5}", "ReservationId", "EmpName", "ReservedOn", "SlotId", "SlotStartTime", "SlotEndTime");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            foreach (var s in slots)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}\t{3}\t{4}\t{5}", s.ReservationId, s.EmpName, s.ReservedOn, s.SlotId, s.SlotStartTime, s.SlotEndTime);
            }
            Console.WriteLine();
        }
        static void BookSlots()
        {
            int result = rep.BookSlots(2, 2);
            if (result > 0)
            {
                Console.WriteLine("Slot booked");
            }
            else
            {
                Console.WriteLine("Some error. Try again!!!");
            }
        }
        static void GetAdminName()
        {
            string result = rep.GetAdminName(1);
            Console.WriteLine(result);
        }
    }
}
