using D16PCSharp_HotelManagement.Entities;
using DAL.Context;
using Dapper;
using HotelManagment.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DAL
{
    public class ReservationManagment
    {
        HotelContext context = new HotelContext();

        //public List<Reservation> GetAllReservations() =>   context.Reservations.ToList();

        //public List<string> GetCheckInReservations(bool checkIn)
        //    => context.Reservations.Where(R => (bool)R.check_in == checkIn)
        //    .AsEnumerable()
        //    .Select(r =>
        //        $"{(r.room_number?.ToString() ?? "").PadRight(6)} | " +
        //        $"{(r.room_type ?? "").PadRight(8)} | " +
        //        $"{r.Id.ToString().PadRight(5)} | " +
        //        $"{(r.first_name + " " + r.last_name).PadRight(15)} | " +
        //        $"{(r.phone_number ?? "").PadRight(12)} | " +
        //        $"{(r.arrival_time?.ToString("yyyy-MM-dd") ?? "").PadRight(10)} | " +
        //        $"{(r.leaving_time?.ToString("yyyy-MM-dd") ?? "")}"
        //    ).ToList();

        //public List<Reservation> SearchReservations(string term)
        //{
        //    if (string.IsNullOrWhiteSpace(term))
        //        return GetAllReservations();

        //    return context.Reservations
        //        .Where(r => r.first_name.Contains(term) ||
        //                    r.last_name.Contains(term) ||
        //                    r.phone_number.Contains(term) ||
        //                    r.Id.ToString().Contains(term))
        //        .ToList();
        //}

       

        public bool DeleteReservation(int id)
        {
            var reservation = context.Reservations.Find(id);
            if (reservation != null)
            {
                context.Reservations.Remove(reservation);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public int AddReservation(Reservation res)
        {
            context.Reservations.Add(res);
            context.SaveChanges();
            return res.Id;
        }


        public void UpdateReservation(Reservation res)
        {
            var existingRes = context.Reservations.Find(res.Id);
            if (existingRes != null)
            {
                existingRes.first_name = res.first_name;
                existingRes.last_name = res.last_name;
                existingRes.birth_day = res.birth_day;
                existingRes.gender = res.gender;
                existingRes.phone_number = res.phone_number;
                existingRes.email_address = res.email_address;
                existingRes.number_guest = res.number_guest;
                existingRes.street_address = res.street_address;
                existingRes.apt_suite = res.apt_suite;
                existingRes.city = res.city;
                existingRes.state = res.state;
                existingRes.zip_code = res.zip_code;
                existingRes.room_type = res.room_type;
                existingRes.room_floor = res.room_floor;
                existingRes.room_number = res.room_number;
                existingRes.total_bill = res.total_bill;
                existingRes.payment_type = res.payment_type;
                existingRes.card_type = res.card_type;
                existingRes.card_number = res.card_number;
                existingRes.card_exp = res.card_exp;
                existingRes.card_cvc = res.card_cvc;
                existingRes.arrival_time = res.arrival_time;
                existingRes.leaving_time = res.leaving_time;
                existingRes.check_in = res.check_in;
                existingRes.break_fast = res.break_fast;
                existingRes.lunch = res.lunch;
                existingRes.dinner = res.dinner;
                existingRes.cleaning = res.cleaning;
                existingRes.towel = res.towel;
                existingRes.s_surprise = res.s_surprise;
                existingRes.supply_status = res.supply_status;
                existingRes.food_bill = res.food_bill;

                context.SaveChanges();
            }
        }

        //===========================================================================
        // Dapper selection 

        DbConnection CN = new SqlConnection("Data Source=.;Initial Catalog=Hotel_Management;Integrated Security=True;Encrypt=false");

        public List<Reservation> GetAllReservations()
            => CN.Query<Reservation> ("select * from Reservations").AsList();

        public List<Reservation> SearchReservations(string term)
           => CN.Query<Reservation>("""
                select * from Reservations
                where first_name like @term 
                or    last_name like @term 
                or    phone_number like @term 
                or    id like @term
                """, new { term = "%" + term + "%" }).ToList();


        public List<string> GetCheckInReservations(bool checkIn)
        {
            var data = CN.Query<Reservation>(
                "SELECT * FROM Reservations WHERE check_in = @checkIn",
                new { checkIn }
            ).ToList();

           
            int roomNumberWidth = data.Max(r => (r.room_number?.ToString() ?? "").Length);
            int roomTypeWidth = data.Max(r => (r.room_type ?? "").Length);
            int idWidth = data.Max(r => r.Id.ToString().Length);
            int nameWidth = data.Max(r => ((r.first_name + " " + r.last_name)).Length);
            int phoneWidth = data.Max(r => (r.phone_number ?? "").Length);
            int arrivalWidth = data.Max(r => (r.arrival_time?.ToString("yyyy-MM-dd") ?? "").Length);
            int leavingWidth = data.Max(r => (r.leaving_time?.ToString("yyyy-MM-dd") ?? "").Length);

            return data.Select(r =>
                $"{(r.room_number?.ToString() ?? "").PadRight(roomNumberWidth)} | " +
                $"{(r.room_type ?? "").PadRight(roomTypeWidth)} | " +
                $"{r.Id.ToString().PadRight(idWidth)} | " +
                $"{(r.first_name + " " + r.last_name).PadRight(nameWidth)} | " +
                $"{(r.phone_number ?? "").PadRight(phoneWidth)} | " +
                $"{(r.arrival_time?.ToString("yyyy-MM-dd") ?? "").PadRight(arrivalWidth)} | " +
                $"{(r.leaving_time?.ToString("yyyy-MM-dd") ?? "").PadRight(leavingWidth)}"
            ).ToList();
        }

        public FrontendLog Authenticate1(string username, string password)
        {
            return CN.QueryFirstOrDefault<FrontendLog>(
                "SELECT * FROM Frontends WHERE Username = @user AND Password = @pass",
                new { user = username, pass = password }
            );
        }
        public KitchenLog Authenticate2(string username, string password)
        {
            return CN.QueryFirstOrDefault<KitchenLog>(
                "SELECT * FROM Kitchens WHERE Username = @user AND Password = @pass",
                new { user = username, pass = password }
            );
        }
        //Context.Frontends.AsNoTracking().FirstOrDefault(u => u.Username == username && u.Password == password);
    }
}
