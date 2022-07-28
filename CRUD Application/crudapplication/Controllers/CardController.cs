using crudapplication.Models;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace crudapplication.Controllers
{
    public class CardController : ApiController
    {
        private ApplicationDbContext _context;
        public CardController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public Debit_Card CreateCard(Debit_Card card)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            _context.Card.Add(card);
            _context.SaveChanges();

            return card;
        }
        [HttpPut]
        public void updatecard(long id, Debit_Card card)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var cardindb = _context.Card.SingleOrDefault(c => c.CardNo == id);

            if (cardindb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            cardindb.CardNo = card.CardNo;
            cardindb.Name = card.Name;
            cardindb.ExpiryDate = card.ExpiryDate;

            _context.SaveChanges();

        }
        [HttpDelete]
        public void DeleteCard(long id)
        {
            var cardindb = _context.Card.SingleOrDefault(c => c.CardNo == id);

            if (cardindb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Card.Remove(cardindb);

            _context.SaveChanges();
        }
    }
}
