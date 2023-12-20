using DevExpress.Mvvm;
using Newtonsoft.Json;

namespace APAM_Client.DataModels.AutoPartSystem
{
    public class AutoPartCategory : BindableBase
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}
