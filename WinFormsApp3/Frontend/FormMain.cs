using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Org.BouncyCastle.Asn1.X9;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

            //FormClosing += new FormClosingEventHandler(MenuManager.SaveMenuItems);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonClear.Hide();
            buttonAdd.Hide();
            maskedTextBoxPrice.Hide();
            dataGridViewMain.Hide();
            MenuManager.LoadMenuItems();

            dataGridViewMain.DataSource = MenuManager.GetMenuItems();
            comboBoxCoffeeType.DataSource = Enum.GetValues(typeof(ECoffee));
            comboBoxMilkType.DataSource = Enum.GetValues(typeof(EMilk));
            comboBoxSoftDrink.DataSource = Enum.GetValues(typeof(ESoftDrink));
            comboBoxSoftDrinkSize.DataSource = Enum.GetValues(typeof(ESize));
            comboBoxMeat.DataSource = Enum.GetValues(typeof(EMeatType));
            comboBoxAlcohol.DataSource = Enum.GetValues(typeof(EAlcohol));
            comboBoxCocktailSize.DataSource = Enum.GetValues(typeof(ESize));
            dataGridViewMain.RowHeadersVisible = true;


        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuManager.SaveMenuItems();
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
                dataGridViewMain.Hide();

            }
            else
            {
                buttonClear.Show();
                buttonAdd.Show();
                maskedTextBoxPrice.Show();
                dataGridViewMain.Show();

                if (curTab == Food)
                {
                    dataGridViewMain.DataSource = MenuManager.GetMenuItemsBy<Burger>();
                }
                else if (curTab == Coffee)
                {
                    dataGridViewMain.DataSource = MenuManager.GetMenuItemsBy<Coffee>();
                }
                else if (curTab == SoftDrink)
                {
                    dataGridViewMain.DataSource = MenuManager.GetMenuItemsBy<SoftDrink>();
                }
                else if (curTab == Cocktail)
                {
                    dataGridViewMain.DataSource = MenuManager.GetMenuItemsBy<Cocktail>();
                }

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var curTab = materialTabControl1.SelectedTab;
            if (curTab == Food)
            {
                AddBurger();
            }
            else if (curTab == Coffee)
            {
                AddCoffee();
            }
            else if (curTab == SoftDrink)
            {
                AddSoftDrink();
            }
            else if (curTab == Cocktail)
            {
                AddCocktail();
            }
        }

        private void AddBurger()
        {
            try
            {
                decimal price = decimal.Parse(maskedTextBoxPrice.Text);
                var item = new Burger(maskedTextBoxBurgerName.Text, price);
                if (comboBoxMeat.SelectedItem != null) { item.MeatType = comboBoxMeat.SelectedItem.ToString(); }
                if (checkBoxLettuce.Checked) { item.Lettuce = true; }
                if (checkBoxTomato.Checked) { item.Tomato = true; }
                if (checkBoxOnion.Checked) { item.Onion = true; }
                if (checkBoxPickle.Checked) { item.Pickle = true; }
                if (customTopping1.Text.Length > 1) { item.CustomToppings.Add(customTopping1.Text); }
                if (customTopping2.Text.Length > 1) { item.CustomToppings.Add(customTopping2.Text); }
                if (customTopping3.Text.Length > 1) { item.CustomToppings.Add(customTopping3.Text); }

                MenuManager.AddMenuItem(item);
                dataGridViewMain.DataSource = MenuManager.GetMenuItemsBy<Burger>();
                MaterialSnackBar AddedItemMessage = new("Item Added!");
                AddedItemMessage.Show(this);
            }
            catch (Exception ex)
            {
                MaterialSnackBar SnackBarMessage = new(ex.Message);
                SnackBarMessage.Show(this);
            }
        }

        private void AddCoffee()
        {
            try
            {
                decimal price = decimal.Parse(maskedTextBoxPrice.Text);
                var coffeeType = comboBoxCoffeeType.SelectedItem.ToString();
                var milkType = comboBoxMilkType.SelectedItem.ToString();
                bool decaf = switchDecaf.Checked;

                var item = new Coffee(coffeeType, price, "Large", milkType, decaf); // FIX THISSSSSSSSSSSSSSS size
                MenuManager.AddMenuItem(item);
                dataGridViewMain.DataSource = MenuManager.GetMenuItemsBy<Coffee>();
                MaterialSnackBar AddedItemMessage = new("Item Added!");
                AddedItemMessage.Show(this);
            }
            catch (Exception ex)
            {
                MaterialSnackBar SnackBarMessage = new(ex.Message);
                SnackBarMessage.Show(this);
            }
        }

        private void AddSoftDrink()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MaterialSnackBar SnackBarMessage = new(ex.Message);
                SnackBarMessage.Show(this);
            }
        }

        private void AddCocktail()
        {
            try
            {
                decimal price = decimal.Parse(maskedTextBoxPrice.Text);
                var alcohol = comboBoxAlcohol.SelectedItem.ToString();
                var size = comboBoxCocktailSize.SelectedItem.ToString();
                var name = maskedTextBoxCocktailName.Text;
                Cocktail item = new(name, price, size, alcohol);
                if (checkBoxLimejuice.Checked) { item.Lime_juice = true; }
                if (checkBoxIce.Checked) { item.Ice = true; }
                if (checkBoxMint.Checked) { item.Mint = true; }
                if (checkBoxSoda.Checked) { item.Soda = true; }
                if (checkBoxSyrup.Checked) { item.Syrup = true; }
                if (checkBoxSugarWater.Checked) { item.Sugar_water = true; }
                if (customIngredient1.Text.Length > 2) { item.AddIngredient(customIngredient1.Text); }
                if (customIngredient2.Text.Length > 2) { item.AddIngredient(customIngredient2.Text); }
                if (customIngredient3.Text.Length > 2) { item.AddIngredient(customIngredient3.Text); }

                MenuManager.AddMenuItem(item);
                dataGridViewMain.DataSource = MenuManager.GetMenuItemsBy<Cocktail>();
                MaterialSnackBar AddedItemMessage = new("Item Added!");
                AddedItemMessage.Show(this);
            }
            catch (Exception ex)
            {
                MaterialSnackBar SnackBarMessage = new(ex.Message);
                SnackBarMessage.Show(this);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "PDF files (*.pdf) |*.pdf";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (PdfWriter writer = new PdfWriter(saveFileDialog1.FileName))
                {
                    using (PdfDocument PdfDoc = new PdfDocument(writer))
                    {
                        using (Document doc = new Document(PdfDoc))
                        {
                            Paragraph header = new Paragraph("Menu");
                            header.SetBold();
                            header.SetUnderline();
                            header.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                            doc.Add(header);

                            Paragraph burgerhead = new Paragraph("Burgers");
                            burgerhead.SetBold();
                            burgerhead.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                            doc.Add(burgerhead);

                            foreach (var item in MenuManager.GetMenuItemsBy<Burger>())
                            {
                                Paragraph burger = new Paragraph(item.ToString());
                                burger.SetFontSize(10);
                                doc.Add(burger);
                            }

                            Paragraph cocktailhead = new Paragraph("Cocktails");
                            cocktailhead.SetBold();
                            cocktailhead.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                            doc.Add(cocktailhead);

                            foreach (var item in MenuManager.GetMenuItemsBy<Cocktail>())
                            {
                                Paragraph cocktail = new Paragraph(item.ToString());
                                cocktail.SetFontSize(10);
                                doc.Add(cocktail);
                            }
                        }
                    }
                }


                MaterialSnackBar SnackBarMessage = new("PDF Created!");
                SnackBarMessage.Show(this);
            }
        }

        private void maskedTextBoxPrice_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(maskedTextBoxPrice.Text);
            }
            catch (Exception ex)
            {
                MaterialSnackBar SnackBarMessage = new("Price must be decimal!");
                SnackBarMessage.Show(this);
            }
        }
    }
}