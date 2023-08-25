using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using SecureSafe.Models;
using SecureSafe.Views;

namespace SecureSafe.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        private BeerModel _selectedItem;

        // it exposes the CollectionChanged event that is triggered whenever an item is added to or removed from the list.

        public ObservableCollection<BeerModel> Items { get; }

        // Actions 
        public Command LoadItemsCommand { get; }
        
        public Command<BeerModel> ItemTapped { get; }


        public ItemsViewModel()
        {
            Title = "Beers";
            Items = new ObservableCollection<BeerModel>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<BeerModel>(OnItemSelected);
           
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync();                
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public BeerModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        async void OnItemSelected(BeerModel item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }
}
