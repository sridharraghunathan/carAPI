using System;
using System.Collections.Generic;

namespace Infrastructure.CarModels
{
    public partial class CarPhoto
    {
        public int? CarId { get; set; }
        public string pictureUrl { get; set; }
        public int PhotoId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
