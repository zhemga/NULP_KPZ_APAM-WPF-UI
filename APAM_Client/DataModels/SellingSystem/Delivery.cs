using DevExpress.Mvvm;
using System;
using System.Collections.Generic;

namespace APAM_Client.ViewModels.SellingSystem
{
    public class Delivery : BindableBase
    {
        public string Id { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
        public decimal Price { get; set; }
        public string Status_Id { get; set; }
        public DeliveryStatus Status { get; set; }
        public DateTime EstimatedDeliveryTime { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
