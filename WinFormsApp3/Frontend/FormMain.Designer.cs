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
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            Food = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel7 = new ReaLTaiizor.Controls.Panel();
            customTopping3 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            customTopping2 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            customTopping1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel3 = new ReaLTaiizor.Controls.Panel();
            checkBoxPickle = new ReaLTaiizor.Controls.MaterialCheckBox();
            checkBoxOnion = new ReaLTaiizor.Controls.MaterialCheckBox();
            checkBoxLettuce = new ReaLTaiizor.Controls.MaterialCheckBox();
            checkBoxTomato = new ReaLTaiizor.Controls.MaterialCheckBox();
            panel9 = new ReaLTaiizor.Controls.Panel();
            comboBoxMeat = new ReaLTaiizor.Controls.MaterialComboBox();
            panel10 = new ReaLTaiizor.Controls.Panel();
            maskedTextBoxName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            menuManagerBindingSource = new BindingSource(components);
            panel4 = new ReaLTaiizor.Controls.Panel();
            panel5 = new ReaLTaiizor.Controls.Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            maskedTextBoxPrice = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            buttonClear = new ReaLTaiizor.Controls.MaterialButton();
            materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox3 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox4 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialTabControl1.SuspendLayout();
            Home.SuspendLayout();
            Food.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            Coffee.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SoftDrink.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuManagerBindingSource).BeginInit();
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
            Home.Controls.Add(materialButton1);
            Home.ImageKey = "home_page_24px.png";
            Home.Location = new Point(4, 31);
            Home.Name = "Home";
            Home.Padding = new Padding(3);
            Home.Size = new Size(494, 418);
            Home.TabIndex = 0;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(7, 373);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // Food
            // 
            Food.Controls.Add(tableLayoutPanel3);
            Food.ImageKey = "hamburger_24px.png";
            Food.Location = new Point(4, 31);
            Food.Name = "Food";
            Food.Padding = new Padding(3);
            Food.Size = new Size(494, 418);
            Food.TabIndex = 1;
            Food.Text = "Add Burger";
            Food.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel7, 0, 3);
            tableLayoutPanel3.Controls.Add(panel3, 0, 2);
            tableLayoutPanel3.Controls.Add(panel9, 0, 1);
            tableLayoutPanel3.Controls.Add(panel10, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(488, 412);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveBorder;
            panel7.Controls.Add(customTopping3);
            panel7.Controls.Add(customTopping2);
            panel7.Controls.Add(customTopping1);
            panel7.Dock = DockStyle.Fill;
            panel7.EdgeColor = Color.Transparent;
            panel7.Location = new Point(3, 223);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(482, 216);
            panel7.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel7.TabIndex = 2;
            panel7.Text = "panel7";
            // 
            // customTopping3
            // 
            customTopping3.AnimateReadOnly = false;
            customTopping3.AutoCompleteMode = AutoCompleteMode.None;
            customTopping3.AutoCompleteSource = AutoCompleteSource.None;
            customTopping3.BackgroundImageLayout = ImageLayout.None;
            customTopping3.CharacterCasing = CharacterCasing.Normal;
            customTopping3.Depth = 0;
            customTopping3.Dock = DockStyle.Top;
            customTopping3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            customTopping3.HideSelection = true;
            customTopping3.Hint = "Add Custom Topping";
            customTopping3.LeadingIcon = null;
            customTopping3.Location = new Point(5, 101);
            customTopping3.MaxLength = 32767;
            customTopping3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            customTopping3.Name = "customTopping3";
            customTopping3.PasswordChar = '\0';
            customTopping3.PrefixSuffixText = "Add Custom Topping";
            customTopping3.ReadOnly = false;
            customTopping3.RightToLeft = RightToLeft.No;
            customTopping3.SelectedText = "";
            customTopping3.SelectionLength = 0;
            customTopping3.SelectionStart = 0;
            customTopping3.ShortcutsEnabled = true;
            customTopping3.Size = new Size(472, 48);
            customTopping3.TabIndex = 3;
            customTopping3.TabStop = false;
            customTopping3.Text = " ";
            customTopping3.TextAlign = HorizontalAlignment.Left;
            customTopping3.TrailingIcon = null;
            customTopping3.UseSystemPasswordChar = false;
            // 
            // customTopping2
            // 
            customTopping2.AnimateReadOnly = false;
            customTopping2.AutoCompleteMode = AutoCompleteMode.None;
            customTopping2.AutoCompleteSource = AutoCompleteSource.None;
            customTopping2.BackgroundImageLayout = ImageLayout.None;
            customTopping2.CharacterCasing = CharacterCasing.Normal;
            customTopping2.Depth = 0;
            customTopping2.Dock = DockStyle.Top;
            customTopping2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            customTopping2.HideSelection = true;
            customTopping2.Hint = "Add Custom Topping";
            customTopping2.LeadingIcon = null;
            customTopping2.Location = new Point(5, 53);
            customTopping2.MaxLength = 32767;
            customTopping2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            customTopping2.Name = "customTopping2";
            customTopping2.PasswordChar = '\0';
            customTopping2.PrefixSuffixText = "Add Custom Topping";
            customTopping2.ReadOnly = false;
            customTopping2.RightToLeft = RightToLeft.No;
            customTopping2.SelectedText = "";
            customTopping2.SelectionLength = 0;
            customTopping2.SelectionStart = 0;
            customTopping2.ShortcutsEnabled = true;
            customTopping2.Size = new Size(472, 48);
            customTopping2.TabIndex = 2;
            customTopping2.TabStop = false;
            customTopping2.Text = " ";
            customTopping2.TextAlign = HorizontalAlignment.Left;
            customTopping2.TrailingIcon = null;
            customTopping2.UseSystemPasswordChar = false;
            // 
            // customTopping1
            // 
            customTopping1.AnimateReadOnly = false;
            customTopping1.AutoCompleteMode = AutoCompleteMode.None;
            customTopping1.AutoCompleteSource = AutoCompleteSource.None;
            customTopping1.BackgroundImageLayout = ImageLayout.None;
            customTopping1.CharacterCasing = CharacterCasing.Normal;
            customTopping1.Depth = 0;
            customTopping1.Dock = DockStyle.Top;
            customTopping1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            customTopping1.HideSelection = true;
            customTopping1.Hint = "Add Custom Topping";
            customTopping1.LeadingIcon = null;
            customTopping1.Location = new Point(5, 5);
            customTopping1.MaxLength = 32767;
            customTopping1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            customTopping1.Name = "customTopping1";
            customTopping1.PasswordChar = '\0';
            customTopping1.PrefixSuffixText = "Add Custom Topping";
            customTopping1.ReadOnly = false;
            customTopping1.RightToLeft = RightToLeft.No;
            customTopping1.SelectedText = "";
            customTopping1.SelectionLength = 0;
            customTopping1.SelectionStart = 0;
            customTopping1.ShortcutsEnabled = true;
            customTopping1.Size = new Size(472, 48);
            customTopping1.TabIndex = 1;
            customTopping1.TabStop = false;
            customTopping1.Text = " ";
            customTopping1.TextAlign = HorizontalAlignment.Left;
            customTopping1.TrailingIcon = null;
            customTopping1.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(checkBoxPickle);
            panel3.Controls.Add(checkBoxOnion);
            panel3.Controls.Add(checkBoxLettuce);
            panel3.Controls.Add(checkBoxTomato);
            panel3.Dock = DockStyle.Fill;
            panel3.EdgeColor = Color.Transparent;
            panel3.Location = new Point(3, 133);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(482, 84);
            panel3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel3.TabIndex = 1;
            panel3.Text = "panel3";
            // 
            // checkBoxPickle
            // 
            checkBoxPickle.AutoSize = true;
            checkBoxPickle.Depth = 0;
            checkBoxPickle.Location = new Point(193, 42);
            checkBoxPickle.Margin = new Padding(0);
            checkBoxPickle.MouseLocation = new Point(-1, -1);
            checkBoxPickle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            checkBoxPickle.Name = "checkBoxPickle";
            checkBoxPickle.ReadOnly = false;
            checkBoxPickle.Ripple = true;
            checkBoxPickle.Size = new Size(77, 37);
            checkBoxPickle.TabIndex = 4;
            checkBoxPickle.Text = "Pickle";
            checkBoxPickle.UseAccentColor = true;
            checkBoxPickle.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnion
            // 
            checkBoxOnion.AutoSize = true;
            checkBoxOnion.Depth = 0;
            checkBoxOnion.Location = new Point(193, 5);
            checkBoxOnion.Margin = new Padding(0);
            checkBoxOnion.MouseLocation = new Point(-1, -1);
            checkBoxOnion.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            checkBoxOnion.Name = "checkBoxOnion";
            checkBoxOnion.ReadOnly = false;
            checkBoxOnion.Ripple = true;
            checkBoxOnion.Size = new Size(77, 37);
            checkBoxOnion.TabIndex = 3;
            checkBoxOnion.Text = "Onion";
            checkBoxOnion.UseAccentColor = true;
            checkBoxOnion.UseVisualStyleBackColor = true;
            // 
            // checkBoxLettuce
            // 
            checkBoxLettuce.AutoSize = true;
            checkBoxLettuce.Depth = 0;
            checkBoxLettuce.Location = new Point(7, 42);
            checkBoxLettuce.Margin = new Padding(0);
            checkBoxLettuce.MouseLocation = new Point(-1, -1);
            checkBoxLettuce.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            checkBoxLettuce.Name = "checkBoxLettuce";
            checkBoxLettuce.ReadOnly = false;
            checkBoxLettuce.Ripple = true;
            checkBoxLettuce.Size = new Size(87, 37);
            checkBoxLettuce.TabIndex = 2;
            checkBoxLettuce.Text = "Lettuce";
            checkBoxLettuce.UseAccentColor = true;
            checkBoxLettuce.UseVisualStyleBackColor = true;
            // 
            // checkBoxTomato
            // 
            checkBoxTomato.AutoSize = true;
            checkBoxTomato.Depth = 0;
            checkBoxTomato.Location = new Point(7, 5);
            checkBoxTomato.Margin = new Padding(0);
            checkBoxTomato.MouseLocation = new Point(-1, -1);
            checkBoxTomato.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            checkBoxTomato.Name = "checkBoxTomato";
            checkBoxTomato.ReadOnly = false;
            checkBoxTomato.Ripple = true;
            checkBoxTomato.Size = new Size(99, 37);
            checkBoxTomato.TabIndex = 1;
            checkBoxTomato.Text = "Tomatoe";
            checkBoxTomato.UseAccentColor = true;
            checkBoxTomato.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveBorder;
            panel9.Controls.Add(comboBoxMeat);
            panel9.Dock = DockStyle.Fill;
            panel9.EdgeColor = Color.Transparent;
            panel9.Location = new Point(3, 68);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(5);
            panel9.Size = new Size(482, 59);
            panel9.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel9.TabIndex = 3;
            panel9.Text = "panel9";
            // 
            // comboBoxMeat
            // 
            comboBoxMeat.AutoResize = false;
            comboBoxMeat.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxMeat.Depth = 0;
            comboBoxMeat.Dock = DockStyle.Fill;
            comboBoxMeat.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxMeat.DropDownHeight = 174;
            comboBoxMeat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMeat.DropDownWidth = 121;
            comboBoxMeat.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxMeat.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxMeat.FormattingEnabled = true;
            comboBoxMeat.Hint = "Meat Type";
            comboBoxMeat.IntegralHeight = false;
            comboBoxMeat.ItemHeight = 43;
            comboBoxMeat.Location = new Point(5, 5);
            comboBoxMeat.MaxDropDownItems = 4;
            comboBoxMeat.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            comboBoxMeat.Name = "comboBoxMeat";
            comboBoxMeat.Size = new Size(472, 49);
            comboBoxMeat.StartIndex = 0;
            comboBoxMeat.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ActiveBorder;
            panel10.Controls.Add(maskedTextBoxName);
            panel10.Dock = DockStyle.Fill;
            panel10.EdgeColor = Color.Transparent;
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(5);
            panel10.Size = new Size(482, 59);
            panel10.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel10.TabIndex = 4;
            panel10.Text = "panel10";
            // 
            // maskedTextBoxName
            // 
            maskedTextBoxName.AllowPromptAsInput = true;
            maskedTextBoxName.AnimateReadOnly = false;
            maskedTextBoxName.AsciiOnly = false;
            maskedTextBoxName.BackgroundImageLayout = ImageLayout.None;
            maskedTextBoxName.BeepOnError = false;
            maskedTextBoxName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            maskedTextBoxName.Depth = 0;
            maskedTextBoxName.Dock = DockStyle.Fill;
            maskedTextBoxName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            maskedTextBoxName.HidePromptOnLeave = false;
            maskedTextBoxName.HideSelection = true;
            maskedTextBoxName.InsertKeyMode = InsertKeyMode.Default;
            maskedTextBoxName.LeadingIcon = null;
            maskedTextBoxName.Location = new Point(5, 5);
            maskedTextBoxName.Mask = "";
            maskedTextBoxName.MaxLength = 32767;
            maskedTextBoxName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            maskedTextBoxName.Name = "maskedTextBoxName";
            maskedTextBoxName.PasswordChar = '\0';
            maskedTextBoxName.PrefixSuffix = ReaLTaiizor.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            maskedTextBoxName.PrefixSuffixText = "Name";
            maskedTextBoxName.PromptChar = '_';
            maskedTextBoxName.ReadOnly = false;
            maskedTextBoxName.RejectInputOnFirstFailure = false;
            maskedTextBoxName.ResetOnPrompt = true;
            maskedTextBoxName.ResetOnSpace = true;
            maskedTextBoxName.RightToLeft = RightToLeft.No;
            maskedTextBoxName.SelectedText = "";
            maskedTextBoxName.SelectionLength = 0;
            maskedTextBoxName.SelectionStart = 0;
            maskedTextBoxName.ShortcutsEnabled = true;
            maskedTextBoxName.Size = new Size(472, 48);
            maskedTextBoxName.SkipLiterals = true;
            maskedTextBoxName.TabIndex = 5;
            maskedTextBoxName.TabStop = false;
            maskedTextBoxName.Text = "Burger";
            maskedTextBoxName.TextAlign = HorizontalAlignment.Left;
            maskedTextBoxName.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskedTextBoxName.TrailingIcon = null;
            maskedTextBoxName.UseSystemPasswordChar = false;
            maskedTextBoxName.ValidatingType = null;
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
            dataGridViewMain.RowTemplate.Height = 25;
            dataGridViewMain.ShowCellToolTips = false;
            dataGridViewMain.ShowEditingIcon = false;
            dataGridViewMain.Size = new Size(714, 629);
            dataGridViewMain.TabIndex = 0;
            // 
            // menuManagerBindingSource
            // 
            menuManagerBindingSource.DataSource = typeof(Backend.MenuManager);
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
            maskedTextBoxPrice.TextMaskFormat = MaskFormat.IncludePrompt;
            maskedTextBoxPrice.TrailingIcon = null;
            maskedTextBoxPrice.UseSystemPasswordChar = false;
            maskedTextBoxPrice.ValidatingType = null;
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
            // materialCheckBox2
            // 
            materialCheckBox2.AutoSize = true;
            materialCheckBox2.Depth = 0;
            materialCheckBox2.Location = new Point(0, 0);
            materialCheckBox2.Margin = new Padding(0);
            materialCheckBox2.MouseLocation = new Point(-1, -1);
            materialCheckBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox2.Name = "materialCheckBox2";
            materialCheckBox2.ReadOnly = false;
            materialCheckBox2.Ripple = true;
            materialCheckBox2.Size = new Size(10, 10);
            materialCheckBox2.TabIndex = 0;
            materialCheckBox2.Text = "materialCheckBox2";
            materialCheckBox2.UseAccentColor = false;
            materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox3
            // 
            materialCheckBox3.AutoSize = true;
            materialCheckBox3.Depth = 0;
            materialCheckBox3.Location = new Point(0, 0);
            materialCheckBox3.Margin = new Padding(0);
            materialCheckBox3.MouseLocation = new Point(-1, -1);
            materialCheckBox3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox3.Name = "materialCheckBox3";
            materialCheckBox3.ReadOnly = false;
            materialCheckBox3.Ripple = true;
            materialCheckBox3.Size = new Size(10, 10);
            materialCheckBox3.TabIndex = 0;
            materialCheckBox3.Text = "materialCheckBox3";
            materialCheckBox3.UseAccentColor = false;
            materialCheckBox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox4
            // 
            materialCheckBox4.AutoSize = true;
            materialCheckBox4.Depth = 0;
            materialCheckBox4.Location = new Point(0, 0);
            materialCheckBox4.Margin = new Padding(0);
            materialCheckBox4.MouseLocation = new Point(-1, -1);
            materialCheckBox4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox4.Name = "materialCheckBox4";
            materialCheckBox4.ReadOnly = false;
            materialCheckBox4.Ripple = true;
            materialCheckBox4.Size = new Size(10, 10);
            materialCheckBox4.TabIndex = 0;
            materialCheckBox4.Text = "materialCheckBox4";
            materialCheckBox4.UseAccentColor = false;
            materialCheckBox4.UseVisualStyleBackColor = true;
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
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            materialTabControl1.ResumeLayout(false);
            Home.ResumeLayout(false);
            Home.PerformLayout();
            Food.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            Coffee.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            SoftDrink.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuManagerBindingSource).EndInit();
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
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialButton buttonClear;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox maskedTextBoxPrice;
        private TableLayoutPanel tableLayoutPanel3;
        private ReaLTaiizor.Controls.MaterialCheckBox checkBoxTomato;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox2;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox3;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox4;
        private ReaLTaiizor.Controls.MaterialCheckBox checkBoxPickle;
        private ReaLTaiizor.Controls.MaterialCheckBox checkBoxOnion;
        private ReaLTaiizor.Controls.MaterialCheckBox checkBoxLettuce;
        private ReaLTaiizor.Controls.Panel panel7;
        private ReaLTaiizor.Controls.Panel panel9;
        private ReaLTaiizor.Controls.MaterialComboBox comboBoxMeat;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit customTopping3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit customTopping2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit customTopping1;
        private ReaLTaiizor.Controls.Panel panel10;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox maskedTextBoxName;
        private BindingSource menuManagerBindingSource;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
    }
}