using System;
using System.Collections.Generic;
using System.Data.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp3.DataBase.Model
{
    public class Address
    {
        public int AddressId { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string City { get; set; }
        public int StateProvinceId { get; set; }
        public string PostalCode { get; set; }
        public string SpatialLocation { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public override string ToString()
        {
            return $"AddressId: {AddressId} City: {City} Rowguid: {Rowguid} ModifiedDate: {ModifiedDate}";
        }
    }
}
