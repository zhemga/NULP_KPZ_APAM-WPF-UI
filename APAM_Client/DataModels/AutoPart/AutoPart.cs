using APAM_Client.ViewModels.IdentityUsers;
using DevExpress.Mvvm;
using Newtonsoft.Json;

namespace APAM_Client.DataModels.AutoPartSystem
{
    public class AutoPart : BindableBase
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("AutoName")]
        public string AutoName { get; set; }
        [JsonProperty("Price")]
        public decimal Price { get; set; }
        [JsonProperty("AutoPartCategoryId")]
        public string AutoPartCategoryId { get; set; }
        [JsonProperty("AutoPartManufacturerId")]
        public string AutoPartManufacturerId { get; set; }
        [JsonProperty("AutoPartSupplierId")]
        public string AutoPartSupplierId { get; set; }
    }
}
