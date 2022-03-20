using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer
{
    public class Drug
    {
        public string DrugId { get; set; }
        public string DrugName { get; set; }
        public string BrandName { get; set; }
        public float MRP { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Indications { get; set; }
        public string Composition { get; set; }
        public long BatchNo { get; set; }
        public string DrugDosageInvolvedId { get; set; }
        public string DrugDose { get; set; }
    }
}
