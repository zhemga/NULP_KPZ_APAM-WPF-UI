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
    public partial class AutoPartCategoryViewModel : ViewModelBase
    {
        public ObservableCollection<AutoPartCategory> ItemsSource { get; set; }

        public AutoPartCategoryViewModel()
        {
            if (!IsInDesignMode)
            {
                this.ItemsSource = new ObservableCollection<AutoPartCategory>();
                LoadData();
            }
        }

        private async void LoadData()
        {
            var items = await ApiService.SendRequest<List<AutoPartCategory>>(ApiRoutes.AutoPartCategories.GetAll(), HttpMethod.Get);
            foreach (var item in items)
            {
                ItemsSource.Add(item);
            }
        }

        [Command]
        public async void ValidateRow(RowValidationArgs args)
        {
            var item = (AutoPartCategory)args.Item;

            if (item.Id == null)
            {
                item.Id = Guid.NewGuid().ToString();
                await ApiService.SendRequest<AutoPartCategory>(ApiRoutes.AutoPartCategories.Create(), HttpMethod.Post, item);
            }
            else
            {
                var foundItem = await ApiService.SendRequest<AutoPartCategory>(ApiRoutes.AutoPartCategories.GetById(item.Id), HttpMethod.Get);

                if (foundItem != default(AutoPartCategory))
                {
                    await ApiService.SendRequest<AutoPartCategory>(ApiRoutes.AutoPartCategories.Update(item.Id), HttpMethod.Put, item);
                }
            }
        }

        [Command]
        public async void ValidateRowDeletion(ValidateRowDeletionArgs args)
        {
            var item = (AutoPartCategory)args.Items.Single();

            var foundItem = await ApiService.SendRequest<AutoPartCategory>(ApiRoutes.AutoPartCategories.GetById(item.Id), HttpMethod.Get);

            if (foundItem != default(AutoPartCategory))
            {
                await ApiService.SendRequest<AutoPartCategory>(ApiRoutes.AutoPartCategories.Delete(item.Id), HttpMethod.Delete, item);
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
