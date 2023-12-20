using APAM_Client.ViewModels.SellingSystem;
using System.Collections.Generic;

namespace APAM_Client.DataModels.IdentityUsers
{
    public class Customer : IdentityUser
    {
        private ICollection<Order> Orders { get; set; }
    }
}
