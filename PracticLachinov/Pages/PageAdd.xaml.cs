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
	/// Логика взаимодействия для PageAdd.xaml
	/// </summary>
	public partial class PageAdd : Page
	{
		Product prod;
		public PageAdd(Product prod)
		{
			InitializeComponent();

			

			this.prod = prod;

			cbType.ItemsSource = DB.db.ProductType.ToList();

			if (prod != null)
			{
				//Checkprod();
			}
			else
			{
				MessageBox.Show("Выберите Данные");
			}


			
		}

		public void CheckProd()
		{
			tbArticle.Text = prod.ArticleNumber;
			tbTitle.Text = prod.Title;
			tbMinCost.Text = prod.MinCostForAgent.ToString();
			tbPersonCount.Text = prod.ProductionPersonCount.ToString();
			tbWorkNumber.Text = prod.ProductionWorkshopNumber.ToString();
			tbDescription.Text = prod.Description;

			if(prod.ProductType == null)
			{
				cbType.SelectedIndex = 0;
			}

			else
			{
				cbType.SelectedItem = prod.ProductType;
			}


		}

		private void btnBackAdd_Click(object sender, RoutedEventArgs e)
		{
			FrameObj.frameMain.Navigate(new PageProducts());
		}

		private void btnBackSave_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbTitle.Text) || string.IsNullOrWhiteSpace(tbArticle.Text) ||
				string.IsNullOrWhiteSpace(tbMinCost.Text) || cbType.SelectedItem == null)
			{
				MessageBox.Show("Не все поля заполнены");
			}
			else
			{
				prod.Title = tbTitle.Text;
				prod.ArticleNumber = tbArticle.Text;
				prod.MinCostForAgent = int.Parse(tbMinCost.Text);
				prod.ProductType = (ProductType)cbType.SelectedItem;

				if(prod.ID == 0)
				{
					DB.db.Product.Add(prod);
				}
				DB.db.SaveChanges();

				FrameObj.frameMain.Navigate(new PageProducts());
			}
		}
	}
}
