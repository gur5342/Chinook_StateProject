using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class InvoiceData : EntityData<Invoice>
    {
        public Invoice GetByPK(int invoiceId)           
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Invoices.FirstOrDefault(x => x.InvoiceId == invoiceId);
            }
        }

        public List<Invoice> GetAllOrderByCountry()
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var query = context.Invoices
                    .GroupBy(x => x.BillingCountry)
                    .Select(x => x.FirstOrDefault())
                    .ToList();

                return query.ToList();
            }
        }

        public List<Invoice> GetAllOrderByState()
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var query = context.Invoices
                    .GroupBy(x => x.BillingState)
                    .Select(x => x.FirstOrDefault())
                    .ToList();

                return query.ToList();
            }
        }

        public List<Invoice> GetAllOrderByCity()
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var query = context.Invoices
                    .GroupBy(x => x.BillingCity)
                    .Select(x => x.FirstOrDefault())
                    .ToList();

                return query.ToList();
            }
        }

        public void DeleteByPK(int invoiceId)
        {
            Invoice entity = GetByPK(invoiceId);

            if (entity == null)
                return;

            Delete(entity);
        }

        public List<Invoice> Search(string country, string state, string city)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var customersFirstName = context.Customers.ToDictionary(x => x.CustomerId, x => x.FirstName);
                var customersLastName = context.Customers.ToDictionary(x => x.CustomerId, x => x.LastName);

                var query = from x in context.Invoices
                            select x;

                if (string.IsNullOrEmpty(country) == false)
                    query = query.Where(x => x.BillingCountry.Contains(country));

                if (string.IsNullOrEmpty(state) == false)
                    query = query.Where(x => x.BillingState.Contains(state));

                if (string.IsNullOrEmpty(city) == false)
                    query = query.Where(x => x.BillingCity.Contains(city));

                var invoices = query.ToList();

                foreach (var x in invoices)
                {
                    x.CustomerFirstName= customersFirstName[x.CustomerId];
                    x.CustomerLastName = customersLastName[x.CustomerId];
                }
                return invoices;
            }
        }
    }
}
