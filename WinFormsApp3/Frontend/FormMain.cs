using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using Org.BouncyCastle.Asn1.Cms;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Material;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System;
using System.ComponentModel;
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
            //materialSkinManager.ColorScheme = new MaterialColorScheme(primary: Color.FromArgb(115, 171, 133), // main color
            //                                                          darkPrimary: Color.FromArgb(85, 139, 110), // BAR
            //                                                          lightPrimary: Color.FromArgb(149, 192, 163), // shades
            //                                                          accent: Color.FromArgb(38, 84, 124), // accent
            //                                                          textShade: MaterialTextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialColorScheme(primary: Color.FromArgb(73, 106, 129), // main color
                                                                      darkPrimary: Color.FromArgb(59, 85, 104), // BAR
                                                                      lightPrimary: Color.FromArgb(149, 192, 163), // shades
                                                                      accent: Color.FromArgb(73, 106, 129), // accent
                                                                      textShade: MaterialTextShade.WHITE);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonClear.Hide();
            buttonAdd.Hide();
            maskedTextBoxPrice.Hide();
            dataGridViewMain.Hide();

            // if file exists, load it
            if (MenuManager.FileExists())
                MenuManager.LoadMenuItems();

            dataGridViewMain.DataSource = MenuManager.GetMenuItems();
            comboBoxMilk.DataSource = Enum.GetValues(typeof(EMilk));
            comboBoxBeans.DataSource = Enum.GetValues(typeof(EBeans));
            comboBoxCoffeeSize.DataSource = Enum.GetValues(typeof(ESize));
            comboBoxMeat.DataSource = Enum.GetValues(typeof(EMeatType));
            comboBoxAlcohol.DataSource = Enum.GetValues(typeof(EAlcohol));
            comboBoxCocktailSize.DataSource = Enum.GetValues(typeof(ESize));
            dataGridViewMain.RowHeadersVisible = true;
            panel18.BringToFront();


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
                panel18.Show();

            }
            else
            {
                buttonClear.Show();
                buttonAdd.Show();
                maskedTextBoxPrice.Show();
                dataGridViewMain.Show();
                panel18.Hide();
                if (curTab == Food)
                {
                    dataGridViewMain.DataSource = MenuManager.GetMenuItemsBy<Burger>();
                }
                else if (curTab == Coffee)
                {
                    dataGridViewMain.DataSource = MenuManager.GetMenuItemsBy<Coffee>();
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
            else if (curTab == Cocktail)
            {
                AddCocktail();
            }
        }

        private void AddBurger()
        {
            if (!ValidatePrice())
            {
                maskedTextBoxPrice.Text = string.Empty;
                return;
            }

            try
            {
                var item = new Burger(maskedTextBoxBurgerName.Text, decimal.Parse(maskedTextBoxPrice.Text));
                if (comboBoxMeat.SelectedItem != null) { item.MeatType = comboBoxMeat.SelectedItem.ToString(); }
                if (checkBoxLettuce.Checked) { item.Lettuce = true; }
                if (checkBoxTomato.Checked) { item.Tomato = true; }
                if (checkBoxOnion.Checked) { item.Onion = true; }
                if (checkBoxPickle.Checked) { item.Pickle = true; }
                if (!customTopping1.Text.Equals(string.Empty)) { item.CustomToppings.Add(customTopping1.Text); }
                if (!customTopping2.Text.Equals(string.Empty)) { item.CustomToppings.Add(customTopping2.Text); }
                if (!customTopping3.Text.Equals(string.Empty)) { item.CustomToppings.Add(customTopping3.Text); }

                MenuManager.AddMenuItem(item);
                dataGridViewMain.DataSource = MenuManager.GetMenuItemsBy<Burger>();
                MaterialSnackBar AddedItemMessage = new("Item Added!");
                AddedItemMessage.Show(this);
                ClearBurgerTab();
            }
            catch (Exception ex)
            {
                MaterialSnackBar SnackBarMessage = new(ex.Message);
                SnackBarMessage.Show(this);
            }
        }

        private void AddCoffee()
        {

            if (!ValidatePrice())
            {
                maskedTextBoxPrice.Text = string.Empty;
                return;
            }

            try
            {
                var strong = checkBoxStrong.Checked;
                var size = comboBoxCoffeeSize.SelectedItem.ToString();
                var milk = comboBoxMilk.SelectedItem.ToString();
                var bean = comboBoxBeans.SelectedItem.ToString();
                string temp;
                if (checkBoxCold.Checked)
                {
                    temp = "Cold";
                }
                else
                {
                    temp = "Hot";
                }
                var item = new Coffee(maskedTextBoxCoffeName.Text, decimal.Parse(maskedTextBoxPrice.Text), size, milk, bean, temp, strong);
                MenuManager.AddMenuItem(item);
                dataGridViewMain.DataSource = MenuManager.GetMenuItemsBy<Coffee>();
                MaterialSnackBar AddedItemMessage = new("Item Added!");
                AddedItemMessage.Show(this);
                ClearCoffeeTab();
            }
            catch (Exception ex)
            {
                MaterialSnackBar SnackBarMessage = new(ex.Message);
                SnackBarMessage.Show(this);
            }
        }

        private void AddCocktail()
        {
            if (!ValidatePrice())
            {
                maskedTextBoxPrice.Text = string.Empty;
                return;
            }

            try
            {
                var alcohol = comboBoxAlcohol.SelectedItem.ToString();
                var size = comboBoxCocktailSize.SelectedItem.ToString();
                var name = maskedTextBoxCocktailName.Text;
                Cocktail item = new(name, decimal.Parse(maskedTextBoxPrice.Text), size, alcohol);
                if (checkBoxLimejuice.Checked) { item.Lime_juice = true; }
                if (checkBoxIce.Checked) { item.Ice = true; }
                if (checkBoxMint.Checked) { item.Mint = true; }
                if (checkBoxSoda.Checked) { item.Soda = true; }
                if (checkBoxSyrup.Checked) { item.Syrup = true; }
                if (checkBoxSugarWater.Checked) { item.Sugar_water = true; }
                if (!customIngredient1.Text.Equals(string.Empty)) { item.AddIngredient(customIngredient1.Text); }
                if (!customIngredient2.Text.Equals(string.Empty)) { item.AddIngredient(customIngredient2.Text); }
                if (!customIngredient3.Text.Equals(string.Empty)) { item.AddIngredient(customIngredient3.Text); }

                MenuManager.AddMenuItem(item);
                dataGridViewMain.DataSource = MenuManager.GetMenuItemsBy<Cocktail>();
                MaterialSnackBar AddedItemMessage = new("Item Added!");
                AddedItemMessage.Show(this);
                ClearCocktailTab();
            }
            catch (Exception ex)
            {
                MaterialSnackBar SnackBarMessage = new(ex.Message);
                SnackBarMessage.Show(this);
            }
        }

        private void maskedTextBoxPrice_Leave(object sender, EventArgs e)
        {
            ValidatePrice();
        }

        private void materialButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "binary (*.bin)|*.bin|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MenuManager.SaveMenuItems(saveFileDialog1.FileName);
            }
        }

        private void materialButtonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "binary (*.bin)|*.bin|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MenuManager.LoadMenuItems(openFileDialog1.FileName);
            }
        }

        private void dataGridViewMain_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            MenuManager.RemoveMenuItem((MenuItem)e.Row.DataBoundItem);
        }

        private void materialButtonExport_Click(object sender, EventArgs e)
        {
            if (MenuManager.GetMenuItems().Count < 1)
            {
                MaterialSnackBar SnackBarMessage = new("No items to export!");
                SnackBarMessage.Show(this);
                return;
            }
            if (MenuManager.GetMenuItemsBy<Burger>().Count > 2 && MenuManager.GetMenuItemsBy<Coffee>().Count > 2 && MenuManager.GetMenuItemsBy<Cocktail>().Count > 2)
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

                                Div page = new Div();
                                page.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                                page.SetBorder(new SolidBorder(iText.Kernel.Colors.ColorConstants.BLACK, 2, 0.5F));
                                page.SetBorderRadius(new BorderRadius(5));
                                page.SetMargin(10);
                                page.SetPadding(10);
                                page.SetTextAlignment(TextAlignment.CENTER);
                                page.SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA));

                                Style items = new Style();
                                items.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE);
                                items.SetBorderRadius(new BorderRadius(5));
                                items.SetBorder(new SolidBorder(iText.Kernel.Colors.ColorConstants.BLACK, 2, 0.5F));
                                items.SetMargin(10);
                                items.SetPadding(10);
                                items.SetTextAlignment(TextAlignment.LEFT);
                                items.SetFontSize(10);

                                Style header1 = new Style();
                                header1.SetBold();
                                header1.SetFontSize(12);
                                header1.SetTextAlignment(TextAlignment.CENTER);

                                Style header2 = new Style();
                                header2.SetBold();
                                header2.SetTextAlignment(TextAlignment.CENTER);


                                Paragraph header = new Paragraph("Menu");
                                header.AddStyle(header1);


                                Div burgerdiv = new Div();
                                burgerdiv.AddStyle(items);


                                Paragraph burgerhead = new Paragraph("Burgers");
                                burgerhead.AddStyle(header2);
                                burgerdiv.Add(burgerhead);

                                foreach (var item in MenuManager.GetMenuItemsBy<Burger>())
                                {
                                    Paragraph burger = new Paragraph(item.ToString());
                                    burgerdiv.Add(burger);
                                }

                                Div cocktaildiv = new Div();
                                cocktaildiv.AddStyle(items);

                                Paragraph cocktailhead = new Paragraph("Cocktails");
                                cocktailhead.SetBold();
                                cocktailhead.SetTextAlignment(TextAlignment.CENTER);
                                cocktaildiv.Add(cocktailhead);

                                foreach (var item in MenuManager.GetMenuItemsBy<Cocktail>())
                                {
                                    Paragraph cocktail = new Paragraph(item.ToString());
                                    cocktaildiv.Add(cocktail);
                                }

                                Div coffeediv = new Div();
                                coffeediv.AddStyle(items);

                                Paragraph coffeehead = new Paragraph("Coffee");
                                coffeehead.AddStyle(header2);
                                coffeediv.Add(coffeehead);

                                foreach (var item in MenuManager.GetMenuItemsBy<Coffee>())
                                {
                                    Paragraph coffee = new Paragraph(item.ToString());
                                    coffeediv.Add(coffee);
                                }

                                page.Add(header);
                                page.Add(burgerdiv);
                                page.Add(cocktaildiv);
                                page.Add(coffeediv);

                                doc.Add(page);
                            }
                        }
                    }


                    MaterialSnackBar SnackBarMessage = new("PDF Created!");
                    SnackBarMessage.Show(this);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            var curTab = materialTabControl1.SelectedTab;
            if (curTab == Food)
            {
                ClearBurgerTab();
            }
            else if (curTab == Coffee)
            {
                ClearCoffeeTab();
            }
            else if (curTab == Cocktail)
            {
                ClearCocktailTab();
            }
        }

        private void ClearBurgerTab()
        {
            customTopping1.Text = string.Empty;
            customTopping2.Text = string.Empty;
            customTopping3.Text = string.Empty;
            checkBoxPickle.Checked = false;
            checkBoxTomato.Checked = false;
            checkBoxLettuce.Checked = false;
            checkBoxOnion.Checked = false;
            comboBoxMeat.SelectedIndex = 0;
            maskedTextBoxBurgerName.Text = "Burger";
            maskedTextBoxPrice.Text = string.Empty;

        }

        private void ClearCoffeeTab()
        {
            checkBoxStrong.Checked = false;
            checkBoxCold.Checked = false;
            comboBoxBeans.SelectedIndex = 0;
            comboBoxMilk.SelectedIndex = 0;
            maskedTextBoxCoffeName.Text = "Coffee";
            maskedTextBoxPrice.Text = string.Empty;
            comboBoxCoffeeSize.SelectedIndex = 0;
        }

        private void ClearCocktailTab()
        {
            customIngredient1.Text = string.Empty;
            customIngredient2.Text = string.Empty;
            customIngredient3.Text = string.Empty;
            maskedTextBoxCocktailName.Text = "Cocktail";
            maskedTextBoxPrice.Text = string.Empty;
            comboBoxCocktailSize.SelectedIndex = 0;
            checkBoxIce.Checked = false;
            checkBoxSugarWater.Checked = false;
            checkBoxSyrup.Checked = false;
            checkBoxMint.Checked = false;
            checkBoxSoda.Checked = false;
            checkBoxLimejuice.Checked = false;
            comboBoxAlcohol.SelectedIndex = 0;
        }

        private bool ValidatePrice()
        {
            try
            {
                decimal.Parse(maskedTextBoxPrice.Text);
                return true;
            }
            catch (Exception ex)
            {
                MaterialSnackBar SnackBarMessage = new("Price must be decimal!");
                SnackBarMessage.Show(this);
                return false;
            }
        }
    }
}