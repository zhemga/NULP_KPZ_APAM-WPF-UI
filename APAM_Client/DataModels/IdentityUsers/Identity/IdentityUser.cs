using APAM_Client.ViewModels.IdentityUsers.Identity;
using DevExpress.Mvvm;
using System.Collections.Generic;

namespace APAM_Client.DataModels.IdentityUsers
{
    public class IdentityUser : BindableBase
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ICollection<IdentityRole> Roles { get; set; }
    }
}
