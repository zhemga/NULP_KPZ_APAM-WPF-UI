using APAM_Client.DataModels.AutoPartSystem;
using System.Collections.Generic;

namespace APAM_Client.DataModels.IdentityUsers
{
    public class AutoPartSupplier : IdentityUser
    {
        private ICollection<AutoPart> AutoParts { get; set; }
    }
}
