using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticLachinov.Pages
{
	/// <summary>
	/// Логика взаимодействия для PageProducts.xaml
	/// </summary>
	public partial class PageProducts : Page
	{
		public PageProducts()
		{
			InitializeComponent();

			lbProducts.ItemsSource = DB.db.Product.ToList();

			cbFilter.Items.Add("Фильтрация");

			foreach(var productType in DB.db.ProductType)
			{
				cbFilter.Items.Add(productType.Title);
			}

			cbFilter.SelectedIndex = 0;

			cbSort.Items.Add("Сортировка");
			cbSort.Items.Add("По возрастанию");
			cbSort.Items.Add("По убыванию");
			cbSort.SelectedIndex = 0;
		}

		public void FindProduct()
		{
			var products = DB.db.Product.Where(x => x.Title.StartsWith(tbFind.Text)).ToList();

			switch(cbSort.SelectedIndex)
			{
				case 0:; break;
				case 1: products = products.OrderBy(x => x.Title).ToList(); break;
				case 2: products = products.OrderByDescending(x => x.Title).ToList(); break;
			}

			if(cbFilter.SelectedIndex > 0)
			{
				string prodType = cbFilter.SelectedItem.ToString();
				products = products.Where(x => x.ProductType.Title == prodType).ToList();
			}

			lbProducts.ItemsSource = products;
		}

		private void tbFind_TextChanged(object sender, TextChangedEventArgs e)
		{
			FindProduct();
		}

		private void cbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			FindProduct();
		}

		private void cbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			FindProduct();

		}

		private void btnDel_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				var prodSelect = lbProducts.SelectedItem;
				if(MessageBox.Show("Удалить объект?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
				{
					DB.db.Product.Remove((Product)prodSelect);
					DB.db.SaveChanges();
					lbProducts.ItemsSource = DB.db.Product.ToList();
					MessageBox.Show("Объект удален!");
				}
			}
			catch
			{

			}
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			FrameObj.frameMain.Navigate(new PageAdd(new Product()));
		}

		private void btnEdit_Click(object sender, RoutedEventArgs e)
		{
			var prodSelect = lbProducts.SelectedItem;
			FrameObj.frameMain.Navigate(new PageAdd((Product)prodSelect));
		}
	}
}
