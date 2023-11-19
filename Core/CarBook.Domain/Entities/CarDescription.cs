using CarBook.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarDescription : BaseEntity
    {
        public string CarID { get; set; }
        public Car Car { get; set; }
        public string Details { get; set; }
    }
}
