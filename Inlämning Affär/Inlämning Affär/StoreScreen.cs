using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämning_Affär
{
    public partial class StoreScreen : Form
    {


        List<Groceries> shopList = new List<Groceries>();
        List<Groceries> cartList = new List<Groceries>();
        
        public StoreScreen()
        {
            InitializeComponent();
            shopList.Add(new Groceries("Mjöl", 25));
            shopList.Add(new Groceries("Havegryn", 20));
            shopList.Add(new Groceries("Müsli", 30));
            shopList.Add(new Groceries("Russin", 10));
            shopList.Add(new Groceries("Toalettpapper", 40));
            shopList.Add(new Groceries("Kaffe", 35));
            shopList.Add(new Groceries("Bananer", 5));
            shopList.Add(new Groceries("Pålägg", 25));
            shopList.Add(new Groceries("Kryddor", 10));
            shopList.Add(new Groceries("Mjölk", 12));
            shopList.Add(new Groceries("Fikabröd", 14));
            shopList.Add(new Groceries("Hummer", 55));
            shopList.Add(new Groceries("Öl", 11));
            shopList.Add(new Groceries("En hatt", 47));
            shopList.Add(new Groceries("Roadkill", 52));
            shopList.Add(new Groceries("Kött", 200));
            shopList.Add(new Groceries("Hushållspapper", 28));
            shopList.Add(new Groceries("Pasta", 22));
            shopList.Add(new Groceries("Grävmaskin", 10000));
            shopList.Add(new Groceries("Efterbörd", 44));

            foreach (Groceries groceries in shopList)
            {
                GroceriesTextBox.Items.Add(groceries.Name + " " + groceries.Price + " " + "kr");
            }
        }
        



        private void StoreScreen_Load(object sender, EventArgs e)
        {

        }

       

        private void addToCart_Click(object sender, EventArgs e)
        {
            if (GroceriesTextBox.SelectedItem != null)
            {
                customerCart.Items.Add(GroceriesTextBox.SelectedItem);
                cartList.Add(shopList[GroceriesTextBox.SelectedIndex]);

                int totalCost = 0;
                foreach (Groceries groceries in cartList)
                {
                    totalCost += groceries.Price;
                }
                totalCostLabel.Text = "Total Cost: " + totalCost + "kr";
            }

        }

        private void removeFromCart_Click(object sender, EventArgs e)
        {
            int indexToRemove = customerCart.SelectedIndex;
            if (indexToRemove > -1 && indexToRemove < cartList.Count)
            {
                Groceries removedItem = cartList[indexToRemove];
                customerCart.Items.RemoveAt(indexToRemove);
                cartList.RemoveAt(indexToRemove);

                int totalCost = 0;
                foreach (Groceries groceries in cartList)
                {
                    totalCost += groceries.Price;
                }
                totalCostLabel.Text = "Total Cost: " + totalCost + "kr";
            }

        }

        string folderPath = "csvFolder";
        string path = "csvFolder/Groceries.csv";
        string absolutePath = "C:\\Users\\Joaki\\source\\\repos\\Inlämning Affär\\Inlämning Affär";

        public void StoreAccount()
        {
            Directory.CreateDirectory(folderPath);
            File.Delete(path);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Name, Price");
                foreach (Groceries groceries in shopList)
                {
                    sw.WriteLine(groceries.GetCSV);
                }
            }
        }

    }
}
