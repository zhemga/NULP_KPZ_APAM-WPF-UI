using DevExpress.Mvvm;

namespace APAM_Client.DataModels.AutoPartSystem
{
    public class AutoPartManufacturer : BindableBase
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
