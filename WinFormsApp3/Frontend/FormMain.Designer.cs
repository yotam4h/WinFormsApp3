namespace WinFormsApp3
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            Home = new TabPage();
            Food = new TabPage();
            Coffee = new TabPage();
            panel1 = new ReaLTaiizor.Controls.Panel();
            panel2 = new ReaLTaiizor.Controls.Panel();
            switchCoffeeIce = new ReaLTaiizor.Controls.MaterialSwitch();
            switchDecaf = new ReaLTaiizor.Controls.MaterialSwitch();
            comboBoxMilkType = new ReaLTaiizor.Controls.MaterialComboBox();
            comboBoxCoffeeType = new ReaLTaiizor.Controls.MaterialComboBox();
            SoftDrink = new TabPage();
            panel6 = new ReaLTaiizor.Controls.Panel();
            panel8 = new ReaLTaiizor.Controls.Panel();
            switchSoftDrinkIce = new ReaLTaiizor.Controls.MaterialSwitch();
            switchCarbonated = new ReaLTaiizor.Controls.MaterialSwitch();
            comboBoxSoftDrinkSize = new ReaLTaiizor.Controls.MaterialComboBox();
            comboBoxSoftDrink = new ReaLTaiizor.Controls.MaterialComboBox();
            menuIcons = new ImageList(components);
            buttonAdd = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewMain = new DataGridView();
            panel4 = new ReaLTaiizor.Controls.Panel();
            panel5 = new ReaLTaiizor.Controls.Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            maskedTextBoxPrice = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            buttonClear = new ReaLTaiizor.Controls.MaterialButton();
            materialTabControl1.SuspendLayout();
            Coffee.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SoftDrink.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.AccessibleName = "";
            materialTabControl1.Appearance = TabAppearance.FlatButtons;
            materialTabControl1.Controls.Add(Home);
            materialTabControl1.Controls.Add(Food);
            materialTabControl1.Controls.Add(Coffee);
            materialTabControl1.Controls.Add(SoftDrink);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = menuIcons;
            materialTabControl1.ImeMode = ImeMode.NoControl;
            materialTabControl1.ItemSize = new Size(70, 27);
            materialTabControl1.Location = new Point(5, 5);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(502, 453);
            materialTabControl1.SizeMode = TabSizeMode.FillToRight;
            materialTabControl1.TabIndex = 18;
            materialTabControl1.Selected += materialTabControl1_Selected;
            // 
            // Home
            // 
            Home.ImageKey = "home_page_24px.png";
            Home.Location = new Point(4, 31);
            Home.Name = "Home";
            Home.Padding = new Padding(3);
            Home.Size = new Size(494, 418);
            Home.TabIndex = 0;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            // 
            // Food
            // 
            Food.ImageKey = "hamburger_24px.png";
            Food.Location = new Point(4, 31);
            Food.Name = "Food";
            Food.Padding = new Padding(3);
            Food.Size = new Size(494, 418);
            Food.TabIndex = 1;
            Food.Text = "Add Food";
            Food.UseVisualStyleBackColor = true;
            // 
            // Coffee
            // 
            Coffee.Controls.Add(panel1);
            Coffee.ImageKey = "cafe_24px.png";
            Coffee.Location = new Point(4, 31);
            Coffee.Name = "Coffee";
            Coffee.Padding = new Padding(3);
            Coffee.Size = new Size(494, 418);
            Coffee.TabIndex = 2;
            Coffee.Text = "Add Coffee";
            Coffee.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(comboBoxMilkType);
            panel1.Controls.Add(comboBoxCoffeeType);
            panel1.Dock = DockStyle.Fill;
            panel1.EdgeColor = Color.Transparent;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(488, 412);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 1;
            panel1.Text = "panel1";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(switchCoffeeIce);
            panel2.Controls.Add(switchDecaf);
            panel2.Dock = DockStyle.Top;
            panel2.EdgeColor = Color.Transparent;
            panel2.Location = new Point(5, 103);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(478, 83);
            panel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel2.TabIndex = 7;
            panel2.Text = "panel2";
            // 
            // switchCoffeeIce
            // 
            switchCoffeeIce.AutoSize = true;
            switchCoffeeIce.Depth = 0;
            switchCoffeeIce.Location = new Point(140, 5);
            switchCoffeeIce.Margin = new Padding(0);
            switchCoffeeIce.MouseLocation = new Point(-1, -1);
            switchCoffeeIce.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            switchCoffeeIce.Name = "switchCoffeeIce";
            switchCoffeeIce.Ripple = true;
            switchCoffeeIce.Size = new Size(78, 37);
            switchCoffeeIce.TabIndex = 5;
            switchCoffeeIce.Text = "Ice";
            switchCoffeeIce.UseAccentColor = false;
            switchCoffeeIce.UseVisualStyleBackColor = true;
            // 
            // switchDecaf
            // 
            switchDecaf.AutoSize = true;
            switchDecaf.Depth = 0;
            switchDecaf.Location = new Point(5, 5);
            switchDecaf.Margin = new Padding(0);
            switchDecaf.MouseLocation = new Point(-1, -1);
            switchDecaf.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            switchDecaf.Name = "switchDecaf";
            switchDecaf.Ripple = true;
            switchDecaf.Size = new Size(100, 37);
            switchDecaf.TabIndex = 4;
            switchDecaf.Text = "Decaf";
            switchDecaf.UseAccentColor = false;
            switchDecaf.UseVisualStyleBackColor = true;
            // 
            // comboBoxMilkType
            // 
            comboBoxMilkType.AutoResize = false;
            comboBoxMilkType.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxMilkType.Depth = 0;
            comboBoxMilkType.Dock = DockStyle.Top;
            comboBoxMilkType.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxMilkType.DropDownHeight = 174;
            comboBoxMilkType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMilkType.DropDownWidth = 121;
            comboBoxMilkType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMilkType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxMilkType.FormattingEnabled = true;
            comboBoxMilkType.Hint = "Milk";
            comboBoxMilkType.IntegralHeight = false;
            comboBoxMilkType.ItemHeight = 43;
            comboBoxMilkType.Location = new Point(5, 54);
            comboBoxMilkType.MaxDropDownItems = 4;
            comboBoxMilkType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboBoxMilkType.Name = "comboBoxMilkType";
            comboBoxMilkType.Size = new Size(478, 49);
            comboBoxMilkType.StartIndex = 0;
            comboBoxMilkType.TabIndex = 3;
            comboBoxMilkType.UseAccent = false;
            // 
            // comboBoxCoffeeType
            // 
            comboBoxCoffeeType.AutoResize = false;
            comboBoxCoffeeType.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxCoffeeType.Depth = 0;
            comboBoxCoffeeType.Dock = DockStyle.Top;
            comboBoxCoffeeType.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxCoffeeType.DropDownHeight = 174;
            comboBoxCoffeeType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCoffeeType.DropDownWidth = 121;
            comboBoxCoffeeType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCoffeeType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxCoffeeType.FormattingEnabled = true;
            comboBoxCoffeeType.Hint = "Coffee ";
            comboBoxCoffeeType.IntegralHeight = false;
            comboBoxCoffeeType.ItemHeight = 43;
            comboBoxCoffeeType.Location = new Point(5, 5);
            comboBoxCoffeeType.MaxDropDownItems = 4;
            comboBoxCoffeeType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboBoxCoffeeType.Name = "comboBoxCoffeeType";
            comboBoxCoffeeType.Size = new Size(478, 49);
            comboBoxCoffeeType.Sorted = true;
            comboBoxCoffeeType.StartIndex = 0;
            comboBoxCoffeeType.TabIndex = 2;
            comboBoxCoffeeType.UseAccent = false;
            // 
            // SoftDrink
            // 
            SoftDrink.Controls.Add(panel6);
            SoftDrink.ImageKey = "soda_bottle_24px.png";
            SoftDrink.Location = new Point(4, 31);
            SoftDrink.Name = "SoftDrink";
            SoftDrink.Padding = new Padding(3);
            SoftDrink.Size = new Size(494, 418);
            SoftDrink.TabIndex = 3;
            SoftDrink.Text = "Add Soft Drink";
            SoftDrink.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDarkDark;
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(comboBoxSoftDrinkSize);
            panel6.Controls.Add(comboBoxSoftDrink);
            panel6.Dock = DockStyle.Fill;
            panel6.EdgeColor = Color.Transparent;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(488, 412);
            panel6.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel6.TabIndex = 2;
            panel6.Text = "panel6";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveBorder;
            panel8.Controls.Add(switchSoftDrinkIce);
            panel8.Controls.Add(switchCarbonated);
            panel8.Dock = DockStyle.Top;
            panel8.EdgeColor = Color.Transparent;
            panel8.Location = new Point(5, 103);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(5);
            panel8.Size = new Size(478, 83);
            panel8.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel8.TabIndex = 7;
            panel8.Text = "panel8";
            // 
            // switchSoftDrinkIce
            // 
            switchSoftDrinkIce.AutoSize = true;
            switchSoftDrinkIce.Depth = 0;
            switchSoftDrinkIce.Location = new Point(164, 5);
            switchSoftDrinkIce.Margin = new Padding(0);
            switchSoftDrinkIce.MouseLocation = new Point(-1, -1);
            switchSoftDrinkIce.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            switchSoftDrinkIce.Name = "switchSoftDrinkIce";
            switchSoftDrinkIce.Ripple = true;
            switchSoftDrinkIce.Size = new Size(78, 37);
            switchSoftDrinkIce.TabIndex = 5;
            switchSoftDrinkIce.Text = "Ice";
            switchSoftDrinkIce.UseAccentColor = false;
            switchSoftDrinkIce.UseVisualStyleBackColor = true;
            // 
            // switchCarbonated
            // 
            switchCarbonated.AutoSize = true;
            switchCarbonated.Depth = 0;
            switchCarbonated.Location = new Point(5, 5);
            switchCarbonated.Margin = new Padding(0);
            switchCarbonated.MouseLocation = new Point(-1, -1);
            switchCarbonated.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            switchCarbonated.Name = "switchCarbonated";
            switchCarbonated.Ripple = true;
            switchCarbonated.Size = new Size(140, 37);
            switchCarbonated.TabIndex = 4;
            switchCarbonated.Text = "Carbonated";
            switchCarbonated.UseAccentColor = false;
            switchCarbonated.UseVisualStyleBackColor = true;
            // 
            // comboBoxSoftDrinkSize
            // 
            comboBoxSoftDrinkSize.AutoResize = false;
            comboBoxSoftDrinkSize.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxSoftDrinkSize.Depth = 0;
            comboBoxSoftDrinkSize.Dock = DockStyle.Top;
            comboBoxSoftDrinkSize.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxSoftDrinkSize.DropDownHeight = 174;
            comboBoxSoftDrinkSize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSoftDrinkSize.DropDownWidth = 121;
            comboBoxSoftDrinkSize.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSoftDrinkSize.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxSoftDrinkSize.FormattingEnabled = true;
            comboBoxSoftDrinkSize.Hint = "Size";
            comboBoxSoftDrinkSize.IntegralHeight = false;
            comboBoxSoftDrinkSize.ItemHeight = 43;
            comboBoxSoftDrinkSize.Location = new Point(5, 54);
            comboBoxSoftDrinkSize.MaxDropDownItems = 4;
            comboBoxSoftDrinkSize.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboBoxSoftDrinkSize.Name = "comboBoxSoftDrinkSize";
            comboBoxSoftDrinkSize.Size = new Size(478, 49);
            comboBoxSoftDrinkSize.StartIndex = 0;
            comboBoxSoftDrinkSize.TabIndex = 3;
            comboBoxSoftDrinkSize.UseAccent = false;
            // 
            // comboBoxSoftDrink
            // 
            comboBoxSoftDrink.AutoResize = false;
            comboBoxSoftDrink.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxSoftDrink.Depth = 0;
            comboBoxSoftDrink.Dock = DockStyle.Top;
            comboBoxSoftDrink.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxSoftDrink.DropDownHeight = 174;
            comboBoxSoftDrink.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSoftDrink.DropDownWidth = 121;
            comboBoxSoftDrink.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSoftDrink.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxSoftDrink.FormattingEnabled = true;
            comboBoxSoftDrink.Hint = "Soft Drink";
            comboBoxSoftDrink.IntegralHeight = false;
            comboBoxSoftDrink.ItemHeight = 43;
            comboBoxSoftDrink.Location = new Point(5, 5);
            comboBoxSoftDrink.MaxDropDownItems = 4;
            comboBoxSoftDrink.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboBoxSoftDrink.Name = "comboBoxSoftDrink";
            comboBoxSoftDrink.Size = new Size(478, 49);
            comboBoxSoftDrink.StartIndex = 0;
            comboBoxSoftDrink.TabIndex = 2;
            comboBoxSoftDrink.UseAccent = false;
            // 
            // menuIcons
            // 
            menuIcons.ColorDepth = ColorDepth.Depth8Bit;
            menuIcons.ImageStream = (ImageListStreamer)resources.GetObject("menuIcons.ImageStream");
            menuIcons.TransparentColor = Color.Transparent;
            menuIcons.Images.SetKeyName(0, "cafe_24px.png");
            menuIcons.Images.SetKeyName(1, "hamburger_24px.png");
            menuIcons.Images.SetKeyName(2, "home_page_24px.png");
            menuIcons.Images.SetKeyName(3, "soda_bottle_24px.png");
            // 
            // buttonAdd
            // 
            buttonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdd.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonAdd.Depth = 0;
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.HighEmphasis = true;
            buttonAdd.Icon = null;
            buttonAdd.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonAdd.Location = new Point(3, 585);
            buttonAdd.Margin = new Padding(3, 6, 3, 6);
            buttonAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonAdd.Name = "buttonAdd";
            buttonAdd.NoAccentTextColor = Color.Empty;
            buttonAdd.Size = new Size(512, 48);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "ADD";
            buttonAdd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonAdd.UseAccentColor = true;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewMain.AllowUserToOrderColumns = true;
            dataGridViewMain.AllowUserToResizeColumns = false;
            dataGridViewMain.AllowUserToResizeRows = false;
            dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMain.BackgroundColor = SystemColors.ControlLight;
            dataGridViewMain.BorderStyle = BorderStyle.None;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Dock = DockStyle.Fill;
            dataGridViewMain.Location = new Point(5, 5);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.ReadOnly = true;
            dataGridViewMain.RowHeadersVisible = false;
            dataGridViewMain.RowTemplate.Height = 25;
            dataGridViewMain.ShowCellToolTips = false;
            dataGridViewMain.ShowEditingIcon = false;
            dataGridViewMain.Size = new Size(714, 629);
            dataGridViewMain.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(39, 51, 63);
            panel4.Controls.Add(dataGridViewMain);
            panel4.Dock = DockStyle.Fill;
            panel4.EdgeColor = Color.Transparent;
            panel4.Location = new Point(527, 3);
            panel4.MinimumSize = new Size(400, 500);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(724, 639);
            panel4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel4.TabIndex = 19;
            panel4.Text = "panel4";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(39, 51, 63);
            panel5.Controls.Add(materialTabControl1);
            panel5.Dock = DockStyle.Fill;
            panel5.EdgeColor = Color.Transparent;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(512, 463);
            panel5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel5.TabIndex = 20;
            panel5.Text = "panel5";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.860466F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.13954F));
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1254, 645);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(maskedTextBoxPrice, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonAdd, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonClear, 0, 1);
            tableLayoutPanel2.Controls.Add(panel5, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(518, 639);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // maskedTextBoxPrice
            // 
            maskedTextBoxPrice.AllowPromptAsInput = true;
            maskedTextBoxPrice.AnimateReadOnly = false;
            maskedTextBoxPrice.AsciiOnly = false;
            maskedTextBoxPrice.BackgroundImageLayout = ImageLayout.None;
            maskedTextBoxPrice.BeepOnError = false;
            maskedTextBoxPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            maskedTextBoxPrice.Depth = 0;
            maskedTextBoxPrice.Dock = DockStyle.Top;
            maskedTextBoxPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxPrice.HidePromptOnLeave = false;
            maskedTextBoxPrice.HideSelection = true;
            maskedTextBoxPrice.InsertKeyMode = InsertKeyMode.Default;
            maskedTextBoxPrice.LeadingIcon = null;
            maskedTextBoxPrice.Location = new Point(3, 472);
            maskedTextBoxPrice.Mask = "";
            maskedTextBoxPrice.MaxLength = 32767;
            maskedTextBoxPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            maskedTextBoxPrice.PasswordChar = '\0';
            maskedTextBoxPrice.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            maskedTextBoxPrice.PrefixSuffixText = "Price";
            maskedTextBoxPrice.PromptChar = '_';
            maskedTextBoxPrice.ReadOnly = false;
            maskedTextBoxPrice.RejectInputOnFirstFailure = false;
            maskedTextBoxPrice.ResetOnPrompt = true;
            maskedTextBoxPrice.ResetOnSpace = true;
            maskedTextBoxPrice.RightToLeft = RightToLeft.No;
            maskedTextBoxPrice.SelectedText = "";
            maskedTextBoxPrice.SelectionLength = 0;
            maskedTextBoxPrice.SelectionStart = 0;
            maskedTextBoxPrice.ShortcutsEnabled = true;
            maskedTextBoxPrice.Size = new Size(512, 48);
            maskedTextBoxPrice.SkipLiterals = true;
            maskedTextBoxPrice.TabIndex = 22;
            maskedTextBoxPrice.TabStop = false;
            maskedTextBoxPrice.TextAlign = HorizontalAlignment.Left;
            maskedTextBoxPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskedTextBoxPrice.TrailingIcon = null;
            maskedTextBoxPrice.UseSystemPasswordChar = false;
            maskedTextBoxPrice.ValidatingType = null;
            maskedTextBoxPrice.Validating += maskedTextBoxPrice_Validating;
            // 
            // buttonClear
            // 
            buttonClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonClear.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonClear.Depth = 0;
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClear.HighEmphasis = true;
            buttonClear.Icon = null;
            buttonClear.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            buttonClear.Location = new Point(3, 525);
            buttonClear.Margin = new Padding(3, 6, 3, 6);
            buttonClear.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            buttonClear.Name = "buttonClear";
            buttonClear.NoAccentTextColor = Color.Empty;
            buttonClear.Size = new Size(512, 48);
            buttonClear.TabIndex = 21;
            buttonClear.Text = "CLEAR";
            buttonClear.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonClear.UseAccentColor = true;
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1257, 712);
            Controls.Add(tableLayoutPanel1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            MinimumSize = new Size(900, 600);
            Name = "FormMain";
            Padding = new Padding(0, 64, 3, 3);
            Text = "Menu Manager";
            Load += FormMain_Load;
            materialTabControl1.ResumeLayout(false);
            Coffee.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            SoftDrink.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage Home;
        private TabPage Food;
        private ImageList menuIcons;
        private TabPage Coffee;
        private TabPage SoftDrink;
        private DataGridView dataGridViewMain;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.MaterialComboBox comboBoxMilkType;
        private ReaLTaiizor.Controls.MaterialComboBox comboBoxCoffeeType;
        private ReaLTaiizor.Controls.MaterialSwitch switchCoffeeIce;
        private ReaLTaiizor.Controls.MaterialSwitch switchDecaf;
        private ReaLTaiizor.Controls.Panel panel2;
        private ReaLTaiizor.Controls.Panel panel3;
        private ReaLTaiizor.Controls.MaterialButton buttonAdd;
        private ReaLTaiizor.Controls.Panel panel4;
        private ReaLTaiizor.Controls.Panel panel5;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.Panel panel6;
        private ReaLTaiizor.Controls.Panel panel8;
        private ReaLTaiizor.Controls.MaterialSwitch switchSoftDrinkIce;
        private ReaLTaiizor.Controls.MaterialSwitch switchCarbonated;
        private ReaLTaiizor.Controls.MaterialComboBox comboBoxSoftDrinkSize;
        private ReaLTaiizor.Controls.MaterialComboBox comboBoxSoftDrink;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialButton buttonClear;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox maskedTextBoxPrice;
    }
}