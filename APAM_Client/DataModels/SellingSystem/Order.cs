using APAM_Client.DataModels.AutoPartSystem;
using APAM_Client.ViewModels.IdentityUsers;
using DevExpress.Mvvm;

namespace APAM_Client.DataModels.SellingSystem
{
    public class Order : BindableBase
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public string SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public string AutoPartId { get; set; }
        public AutoPart AutoPart { get; set; }
    }
}
