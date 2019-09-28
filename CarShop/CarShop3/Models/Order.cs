namespace CarShop3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public int? Carld { get; set; }

        [StringLength(50)]
        public string UserTel { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
