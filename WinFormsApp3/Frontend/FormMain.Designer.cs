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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            Food = new TabPage();
            Coffee = new TabPage();
            SoftDrink = new TabPage();
            menuIcons = new ImageList(components);
            materialTabControl1.SuspendLayout();
            Home.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.AccessibleName = "";
            materialTabControl1.Controls.Add(Home);
            materialTabControl1.Controls.Add(Food);
            materialTabControl1.Controls.Add(Coffee);
            materialTabControl1.Controls.Add(SoftDrink);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = menuIcons;
            materialTabControl1.ImeMode = ImeMode.NoControl;
            materialTabControl1.ItemSize = new Size(70, 27);
            materialTabControl1.Location = new Point(0, 64);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(878, 440);
            materialTabControl1.TabIndex = 18;
            // 
            // Home
            // 
            Home.Controls.Add(tableLayoutPanel1);
            Home.ImageKey = "home_page_24px.png";
            Home.Location = new Point(4, 31);
            Home.Name = "Home";
            Home.Padding = new Padding(3);
            Home.Size = new Size(870, 405);
            Home.TabIndex = 0;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(864, 399);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(435, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(426, 393);
            dataGridView1.TabIndex = 0;
            // 
            // Food
            // 
            Food.ImageKey = "hamburger_24px.png";
            Food.Location = new Point(4, 31);
            Food.Name = "Food";
            Food.Padding = new Padding(3);
            Food.Size = new Size(870, 405);
            Food.TabIndex = 1;
            Food.Text = "Add Food";
            Food.UseVisualStyleBackColor = true;
            // 
            // Coffee
            // 
            Coffee.ImageKey = "cafe_24px.png";
            Coffee.Location = new Point(4, 31);
            Coffee.Name = "Coffee";
            Coffee.Padding = new Padding(3);
            Coffee.Size = new Size(870, 405);
            Coffee.TabIndex = 2;
            Coffee.Text = "Add Coffee";
            Coffee.UseVisualStyleBackColor = true;
            // 
            // SoftDrink
            // 
            SoftDrink.ImageKey = "soda_bottle_24px.png";
            SoftDrink.Location = new Point(4, 31);
            SoftDrink.Name = "SoftDrink";
            SoftDrink.Padding = new Padding(3);
            SoftDrink.Size = new Size(870, 405);
            SoftDrink.TabIndex = 3;
            SoftDrink.Text = "Add Soft Drink";
            SoftDrink.UseVisualStyleBackColor = true;
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(881, 507);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "FormMain";
            Padding = new Padding(0, 64, 3, 3);
            Text = "Menu Manager";
            Load += FormMain_Load;
            materialTabControl1.ResumeLayout(false);
            Home.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage Home;
        private TabPage Food;
        private ImageList menuIcons;
        private TabPage Coffee;
        private TabPage SoftDrink;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}