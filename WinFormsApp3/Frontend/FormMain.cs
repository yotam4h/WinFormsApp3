using Org.BouncyCastle.Asn1.X9;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Text;
using System.Windows.Forms;
using WinFormsApp3.Backend;
using WinFormsApp3.Backend.Enums;
using WinFormsApp3.Backend.Models;

namespace WinFormsApp3
{
    public partial class FormMain : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;


        public FormMain()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialColorScheme(primary: Color.FromArgb(115, 171, 133), // main color
                                                                      darkPrimary: Color.FromArgb(85, 139, 110), // BAR
                                                                      lightPrimary: Color.FromArgb(149, 192, 163), // shades
                                                                      accent: Color.FromArgb(38, 84, 124), // accent
                                                                      textShade: MaterialTextShade.WHITE);




            dataGridViewMain.DataSource = MenuManager.GetMenuItems();
            comboBoxCoffeeType.DataSource = Enum.GetValues(typeof(ECoffee));
            comboBoxMilkType.DataSource = Enum.GetValues(typeof(EMilk));
            comboBoxSoftDrink.DataSource = Enum.GetValues(typeof(ESoftDrink));
            comboBoxSoftDrinkSize.DataSource = Enum.GetValues(typeof(ESize));




            //FormClosing += new FormClosingEventHandler(MenuManager.SaveMenuItems);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonClear.Hide();
            buttonAdd.Hide();
            maskedTextBoxPrice.Hide();
        }

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            var curTab = materialTabControl1.SelectedTab;
            if (curTab == Home)
            {
                dataGridViewMain.DataSource = MenuManager.GetMenuItems();
                buttonClear.Hide();
                buttonAdd.Hide();
                maskedTextBoxPrice.Hide();

            }
            else
            {
                buttonClear.Show();
                buttonAdd.Show();
                maskedTextBoxPrice.Show();

                if (curTab == Coffee)
                {
                    dataGridViewMain.DataSource = MenuManager.GetMenuItemsByChild<Coffee>();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal price = decimal.Parse(maskedTextBoxPrice.Text);
                var coffeeType = comboBoxCoffeeType.SelectedItem.ToString();
                var milkType = comboBoxMilkType.SelectedItem.ToString();
                bool decaf = switchDecaf.Checked;

                var item = new Coffee(coffeeType, price, ESize.Large, milkType, decaf); // FIX THISSSSSSSSSSSSSSS size
                MenuManager.AddMenuItem(item);
                dataGridViewMain.DataSource = MenuManager.GetMenuItemsByChild<Coffee>();
                MaterialSnackBar AddedItemMessage = new("Item Added!");
                AddedItemMessage.Show(this);
            }
            catch (Exception ex)
            {
                MaterialSnackBar SnackBarMessage = new(ex.Message);
                SnackBarMessage.Show(this);
            }

        }

        private void maskedTextBoxPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try { decimal.Parse(maskedTextBoxPrice.Text); }
            catch (Exception ex)
            {
                MaterialSnackBar SnackBarMessage = new("Price must be decimal!");
                SnackBarMessage.Show(this);
                e.Cancel = true;
            }
        }
    }
}