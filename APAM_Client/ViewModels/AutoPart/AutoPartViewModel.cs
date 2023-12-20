using APAM_Client.DataModels.AutoPartSystem;
using APAM_Client.Service;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;


namespace APAM_Client.ViewModels.AutoPartSystem
{
    public partial class AutoPartViewModel : ViewModelBase
    {
        public ObservableCollection<AutoPart> ItemsSource { get; set; }

        public AutoPartViewModel()
        {
            if (!IsInDesignMode)
            {
                this.ItemsSource = new ObservableCollection<AutoPart>();
                LoadData();
            }
        }

        private async void LoadData()
        {
            var items = await ApiService.SendRequest<List<AutoPart>>(ApiRoutes.AutoParts.GetAll(), HttpMethod.Get);
            foreach (var item in items)
            {
                ItemsSource.Add(item);
            }
        }

        [Command]
        public async void ValidateRow(RowValidationArgs args)
        {
            var item = (AutoPart)args.Item;

            if (item.Id == null)
            {
                item.Id = Guid.NewGuid().ToString();
                await ApiService.SendRequest<AutoPart>(ApiRoutes.AutoParts.Create(), HttpMethod.Post, item);
            }
            else
            {
                var foundItem = await ApiService.SendRequest<AutoPart>(ApiRoutes.AutoParts.GetById(item.Id), HttpMethod.Get);

                if (foundItem != default(AutoPart))
                {
                    await ApiService.SendRequest<AutoPart>(ApiRoutes.AutoParts.Update(item.Id), HttpMethod.Put, item);
                }
            }
        }

        [Command]
        public async void ValidateRowDeletion(ValidateRowDeletionArgs args)
        {
            var item = (AutoPart)args.Items.Single();

            var foundItem = await ApiService.SendRequest<AutoPart>(ApiRoutes.AutoParts.GetById(item.Id), HttpMethod.Get);

            if (foundItem != default(AutoPart))
            {
                await ApiService.SendRequest<AutoPart>(ApiRoutes.AutoParts.Delete(item.Id), HttpMethod.Delete, item);
            }
        }

        [Command]
        public void DataSourceRefresh(DataSourceRefreshArgs args)
        {
            if (!IsInDesignMode)
            {
                ItemsSource.Clear();
                LoadData();
            }
        }
    }
}
