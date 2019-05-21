namespace Sales.ViewModels
{
    using Sales.Common.Models;
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
    } 
}
