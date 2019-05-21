namespace Sales.ViewModels
{
    using Sales.Common.Models;
    using Sales.Services;
    using System;
    using System.Collections.ObjectModel;

    public class ProductsViewModel : BaseViewModel
    {
        private ApiService apiService;

        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }

        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }

        private async void LoadProducts()
        {
            var response = await this.apiService.GetList<Product>("http://fasencio.somee.com/Sales/API", "/API","/Products"); 
        }
    } 
}
