using System;
using System.ComponentModel.DataAnnotations;

namespace D16PCSharp_HotelManagement.Entities
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string first_name { get; set; }

        [Required, MaxLength(50)]
        public string last_name { get; set; }

        [MaxLength(50)]
        public string? birth_day { get; set; }

        [MaxLength(10)]
        public string? gender { get; set; }

        [Required, MaxLength(20)]
        public string phone_number { get; set; }

        [MaxLength(100)]
        public string? email_address { get; set; }

        public int? number_guest { get; set; }

        [MaxLength(150)]
        public string? street_address { get; set; }

        [MaxLength(20)]
        public string? apt_suite { get; set; }

        [MaxLength(50)]
        public string? city { get; set; }

        [MaxLength(50)]
        public string? state { get; set; }

        [MaxLength(10)]
        public string? zip_code { get; set; }

        [MaxLength(20)]
        public string? room_type { get; set; }

        public int? room_floor { get; set; }

        public int? room_number { get; set; }

        public double? total_bill { get; set; }

        [MaxLength(20)]
        public string? payment_type { get; set; }

        [MaxLength(20)]
        public string? card_type { get; set; }

        [MaxLength(20)]
        public string? card_number { get; set; }

        [MaxLength(10)]
        public string? card_exp { get; set; }

        [MaxLength(5)]
        public string? card_cvc { get; set; }

        public DateTime? arrival_time { get; set; }

        public DateTime? leaving_time { get; set; }

        public bool? check_in { get; set; }

        public int? break_fast { get; set; }

        public int? lunch { get; set; }

        public int? dinner { get; set; }

        public bool cleaning { get; set; }

        public bool towel { get; set; }

        public bool s_surprise { get; set; }

        public bool supply_status { get; set; }

        public int? food_bill { get; set; }
    }
}