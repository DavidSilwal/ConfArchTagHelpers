using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AspNetSecurity_NoSecurity.Models;

namespace AspNetSecurity_NoSecurity.Repositories
{
    public class ConferenceRepo
    {
        private readonly List<ConferenceModel> conferences = new List<ConferenceModel>();

        public ConferenceRepo()
        {
            conferences.Add(new ConferenceModel { Id = 1, Name = "DevSum", Location = "StockHolm", Start = DateTime.Now, TotalTickets = 400, TicketsSold = 350});
            conferences.Add(new ConferenceModel { Id = 2, Name = "Techorama NL", Location = "Ede, NL", Start = new DateTime(2018, 10, 1), TotalTickets = 500, TicketsSold = 140});
            conferences.Add(new ConferenceModel { Id = 2, Name = "Confoo", Location = "Vancouver", Start = new DateTime(2018, 11, 18), TotalTickets = 300, TicketsSold = 110 });
        }
        public IEnumerable<ConferenceModel> GetAll()
        {
            return conferences;
        }

        public ConferenceModel GetById(int id)
        {
            return conferences.First(c => c.Id == id);
        }

        public void Add(ConferenceModel model)
        {
            model.Id = conferences.Max(c => c.Id) + 1;
            conferences.Add(model);
        }
    }
}
