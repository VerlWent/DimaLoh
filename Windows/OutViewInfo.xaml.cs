using demopract2024_2.Model;
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
using System.Windows.Shapes;

namespace demopract2024_2.Windows
{
    /// <summary>
    /// Логика взаимодействия для OutViewInfo.xaml
    /// </summary>
    public partial class OutViewInfo : Window
    {
        ContextClass _context = new ContextClass();
        public OutViewInfo()
        {
            InitializeComponent();
            PreLoad();
			LoadData();
		}

        public void PreLoad()
        {
            var GetManufacturer = _context.Manufacturers.Select(x => x.Name);

            ComboManufacturer.Items.Add("Все производители");
			foreach ( var manufacturer in GetManufacturer )
            {
                ComboManufacturer.Items.Add( manufacturer );
            }
			ComboManufacturer.SelectedIndex = 0;

            ComboCost.Items.Add("По умолчанию");
			ComboCost.Items.Add("По возрастанию");
			ComboCost.Items.Add("По убыванию");
			ComboCost.SelectedIndex = 0;

		}

        public void LoadData()
        {
            List<Product> GetData = new List<Product>(); 
            GetData = _context.Products.ToList();

            int AllCount = GetData.Count;

            if (ComboManufacturer.SelectedIndex != 0)
            {
				GetData = GetData.Where(x => x.ProductManufacturerNavigation.Name == ComboManufacturer.SelectedItem.ToString()).ToList();   
            }

            if (ComboCost.SelectedIndex != 0)
            {
                if (ComboCost.SelectedIndex == 1)
                {
					GetData = GetData.OrderBy(x => x.ProductCost).ToList();
				}
                else if (ComboCost.SelectedIndex == 2)
                {
					GetData = GetData.OrderByDescending(x => x.ProductCost).ToList();
				}
			}

            if (TBSearth.Text != "")
            {
                GetData = GetData.Where(x => x.ProductName.Contains(TBSearth.Text)).ToList();
            }

			ListViewOut.Items.Clear();

			foreach (var product in GetData)
            {
                ListViewOut.Items.Add(product);
            }

            ListViewOut.Items.Refresh();

            TBCountDataOut.Text = $"Записей: {GetData.Count} из {AllCount}";

		}

		private void ComboManufacturer_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
            LoadData();
		}

		private void ComboCost_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
            LoadData();
		}

		private void TBSearth_TextChanged(object sender, TextChangedEventArgs e)
		{
            LoadData();
		}
	}
}
