using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetSecurity_NoSecurity.Models
{
    public class ConferenceModel
    {
        public ConferenceModel()
        {
            Start = DateTime.Now;
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public string Location { get; set; }

        [DisplayName("Attendees")]
        public int TicketsSold { get; set; }
        public int TotalTickets { get; set; }
    }
}
