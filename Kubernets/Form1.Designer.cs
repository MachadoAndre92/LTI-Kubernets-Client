namespace Kubernets
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.btn_login = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabList = new System.Windows.Forms.TabPage();
            this.lbl_ListView = new MaterialSkin.Controls.MaterialLabel();
            this.listView1 = new MaterialSkin.Controls.MaterialListView();
            this.bnt_Nodes = new MaterialSkin.Controls.MaterialButton();
            this.tabEstatisticas = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Namespaces = new MaterialSkin.Controls.MaterialButton();
            this.tabControl.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabList.SuspendLayout();
            this.tabEstatisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDashboard);
            this.tabControl.Controls.Add(this.tabList);
            this.tabControl.Controls.Add(this.tabEstatisticas);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(3, 64);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(882, 518);
            this.tabControl.TabIndex = 3;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.btn_login);
            this.tabDashboard.Controls.Add(this.pictureBox3);
            this.tabDashboard.Controls.Add(this.pictureBox2);
            this.tabDashboard.Controls.Add(this.pictureBox1);
            this.tabDashboard.Controls.Add(this.materialLabel1);
            this.tabDashboard.ImageKey = "icons8-home-32.png";
            this.tabDashboard.Location = new System.Drawing.Point(4, 39);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabDashboard.Size = new System.Drawing.Size(874, 475);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_login.Depth = 0;
            this.btn_login.HighEmphasis = true;
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(229, 237);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_login.Size = new System.Drawing.Size(300, 36);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Importar Ficheiro de Configuração";
            this.btn_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_login.UseAccentColor = false;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(269, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(500, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(347, 186);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Login";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.btn_Namespaces);
            this.tabList.Controls.Add(this.lbl_ListView);
            this.tabList.Controls.Add(this.listView1);
            this.tabList.Controls.Add(this.bnt_Nodes);
            this.tabList.ImageKey = "icons8-docker-50.png";
            this.tabList.Location = new System.Drawing.Point(4, 39);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(874, 475);
            this.tabList.TabIndex = 1;
            this.tabList.Text = "Listar";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // lbl_ListView
            // 
            this.lbl_ListView.AutoSize = true;
            this.lbl_ListView.Depth = 0;
            this.lbl_ListView.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ListView.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbl_ListView.Location = new System.Drawing.Point(17, 19);
            this.lbl_ListView.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ListView.Name = "lbl_ListView";
            this.lbl_ListView.Size = new System.Drawing.Size(160, 29);
            this.lbl_ListView.TabIndex = 2;
            this.lbl_ListView.Text = "materialLabel2";
            // 
            // listView1
            // 
            this.listView1.AutoSizeTable = false;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Depth = 0;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(17, 51);
            this.listView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.listView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listView1.MouseState = MaterialSkin.MouseState.OUT;
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(831, 176);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // bnt_Nodes
            // 
            this.bnt_Nodes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnt_Nodes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnt_Nodes.Depth = 0;
            this.bnt_Nodes.HighEmphasis = true;
            this.bnt_Nodes.Icon = null;
            this.bnt_Nodes.Location = new System.Drawing.Point(17, 236);
            this.bnt_Nodes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bnt_Nodes.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnt_Nodes.Name = "bnt_Nodes";
            this.bnt_Nodes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnt_Nodes.Size = new System.Drawing.Size(73, 36);
            this.bnt_Nodes.TabIndex = 0;
            this.bnt_Nodes.Text = "Nodes";
            this.bnt_Nodes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnt_Nodes.UseAccentColor = false;
            this.bnt_Nodes.UseVisualStyleBackColor = true;
            this.bnt_Nodes.Click += new System.EventHandler(this.bnt_Nodes_Click);
            // 
            // tabEstatisticas
            // 
            this.tabEstatisticas.Controls.Add(this.materialButton2);
            this.tabEstatisticas.ImageKey = "icons8-dashboard-64.png";
            this.tabEstatisticas.Location = new System.Drawing.Point(4, 39);
            this.tabEstatisticas.Name = "tabEstatisticas";
            this.tabEstatisticas.Size = new System.Drawing.Size(874, 475);
            this.tabEstatisticas.TabIndex = 2;
            this.tabEstatisticas.Text = "Estatisticas";
            this.tabEstatisticas.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(340, 134);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(158, 36);
            this.materialButton2.TabIndex = 0;
            this.materialButton2.Text = "materialButton2";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-home.gif");
            this.imageList1.Images.SetKeyName(1, "icons8-home-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-dashboard-64.png");
            this.imageList1.Images.SetKeyName(3, "icons8-docker-50.png");
            // 
            // btn_Namespaces
            // 
            this.btn_Namespaces.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Namespaces.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Namespaces.Depth = 0;
            this.btn_Namespaces.HighEmphasis = true;
            this.btn_Namespaces.Icon = null;
            this.btn_Namespaces.Location = new System.Drawing.Point(108, 236);
            this.btn_Namespaces.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Namespaces.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Namespaces.Name = "btn_Namespaces";
            this.btn_Namespaces.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Namespaces.Size = new System.Drawing.Size(118, 36);
            this.btn_Namespaces.TabIndex = 3;
            this.btn_Namespaces.Text = "Namespaces";
            this.btn_Namespaces.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Namespaces.UseAccentColor = false;
            this.btn_Namespaces.UseVisualStyleBackColor = true;
            this.btn_Namespaces.Click += new System.EventHandler(this.btn_Namespaces_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 585);
            this.Controls.Add(this.tabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kubernets Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabList.ResumeLayout(false);
            this.tabList.PerformLayout();
            this.tabEstatisticas.ResumeLayout(false);
            this.tabEstatisticas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private TabPage tabDashboard;
        private TabPage tabList;
        private ImageList imageList1;
        private TabPage tabEstatisticas;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btn_login;
        private MaterialSkin.Controls.MaterialButton bnt_Nodes;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel lbl_ListView;
        private MaterialSkin.Controls.MaterialListView listView1;
        private MaterialSkin.Controls.MaterialButton btn_Namespaces;
    }
}