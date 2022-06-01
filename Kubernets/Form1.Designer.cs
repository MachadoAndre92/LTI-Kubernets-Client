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
            this.btn_services = new MaterialSkin.Controls.MaterialButton();
            this.btnDeployments = new MaterialSkin.Controls.MaterialButton();
            this.cb_namespaces = new MaterialSkin.Controls.MaterialComboBox();
            this.radioBtn_PodsNamespace = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioBtn_AllPods = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_pods = new MaterialSkin.Controls.MaterialButton();
            this.btn_Namespaces = new MaterialSkin.Controls.MaterialButton();
            this.lbl_ListView = new MaterialSkin.Controls.MaterialLabel();
            this.listView1 = new MaterialSkin.Controls.MaterialListView();
            this.bnt_Nodes = new MaterialSkin.Controls.MaterialButton();
            this.TabCreate = new System.Windows.Forms.TabPage();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.cbDeployments = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNumeroReplicas = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cbOptionPod = new MaterialSkin.Controls.MaterialComboBox();
            this.cbNodesOption = new MaterialSkin.Controls.MaterialComboBox();
            this.cbServices = new MaterialSkin.Controls.MaterialComboBox();
            this.cbProtocolo = new MaterialSkin.Controls.MaterialComboBox();
            this.txtPorto = new MaterialSkin.Controls.MaterialTextBox();
            this.cbOptionNamespace = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNome = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnCriar = new MaterialSkin.Controls.MaterialButton();
            this.radioCriar = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioEliminar = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbOption = new MaterialSkin.Controls.MaterialComboBox();
            this.tabEstatisticas = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabList.SuspendLayout();
            this.TabCreate.SuspendLayout();
            this.tabEstatisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDashboard);
            this.tabControl.Controls.Add(this.tabList);
            this.tabControl.Controls.Add(this.TabCreate);
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
            this.pictureBox3.Location = new System.Drawing.Point(276, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(488, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 90);
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
            this.tabList.Controls.Add(this.btn_services);
            this.tabList.Controls.Add(this.btnDeployments);
            this.tabList.Controls.Add(this.cb_namespaces);
            this.tabList.Controls.Add(this.radioBtn_PodsNamespace);
            this.tabList.Controls.Add(this.radioBtn_AllPods);
            this.tabList.Controls.Add(this.btn_pods);
            this.tabList.Controls.Add(this.btn_Namespaces);
            this.tabList.Controls.Add(this.lbl_ListView);
            this.tabList.Controls.Add(this.listView1);
            this.tabList.Controls.Add(this.bnt_Nodes);
            this.tabList.ImageKey = "icons8-list-50.png";
            this.tabList.Location = new System.Drawing.Point(4, 39);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(874, 475);
            this.tabList.TabIndex = 1;
            this.tabList.Text = "Listar";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // btn_services
            // 
            this.btn_services.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_services.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_services.Depth = 0;
            this.btn_services.HighEmphasis = true;
            this.btn_services.Icon = null;
            this.btn_services.Location = new System.Drawing.Point(426, 236);
            this.btn_services.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_services.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_services.Name = "btn_services";
            this.btn_services.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_services.Size = new System.Drawing.Size(88, 36);
            this.btn_services.TabIndex = 9;
            this.btn_services.Text = "Services";
            this.btn_services.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_services.UseAccentColor = false;
            this.btn_services.UseVisualStyleBackColor = true;
            this.btn_services.Click += new System.EventHandler(this.btn_services_Click);
            // 
            // btnDeployments
            // 
            this.btnDeployments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeployments.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeployments.Depth = 0;
            this.btnDeployments.HighEmphasis = true;
            this.btnDeployments.Icon = null;
            this.btnDeployments.Location = new System.Drawing.Point(292, 236);
            this.btnDeployments.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeployments.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeployments.Name = "btnDeployments";
            this.btnDeployments.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeployments.Size = new System.Drawing.Size(126, 36);
            this.btnDeployments.TabIndex = 8;
            this.btnDeployments.Text = "Deployments";
            this.btnDeployments.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeployments.UseAccentColor = false;
            this.btnDeployments.UseVisualStyleBackColor = true;
            this.btnDeployments.Click += new System.EventHandler(this.btnDeployments_Click);
            // 
            // cb_namespaces
            // 
            this.cb_namespaces.AutoResize = false;
            this.cb_namespaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_namespaces.Depth = 0;
            this.cb_namespaces.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_namespaces.DropDownHeight = 174;
            this.cb_namespaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_namespaces.DropDownWidth = 121;
            this.cb_namespaces.Enabled = false;
            this.cb_namespaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_namespaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_namespaces.FormattingEnabled = true;
            this.cb_namespaces.IntegralHeight = false;
            this.cb_namespaces.ItemHeight = 43;
            this.cb_namespaces.Location = new System.Drawing.Point(17, 396);
            this.cb_namespaces.MaxDropDownItems = 4;
            this.cb_namespaces.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_namespaces.Name = "cb_namespaces";
            this.cb_namespaces.Size = new System.Drawing.Size(204, 49);
            this.cb_namespaces.StartIndex = 0;
            this.cb_namespaces.TabIndex = 7;
            this.cb_namespaces.SelectedIndexChanged += new System.EventHandler(this.cb_namespaces_SelectedIndexChanged);
            // 
            // radioBtn_PodsNamespace
            // 
            this.radioBtn_PodsNamespace.AutoSize = true;
            this.radioBtn_PodsNamespace.Depth = 0;
            this.radioBtn_PodsNamespace.Location = new System.Drawing.Point(17, 340);
            this.radioBtn_PodsNamespace.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtn_PodsNamespace.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioBtn_PodsNamespace.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioBtn_PodsNamespace.Name = "radioBtn_PodsNamespace";
            this.radioBtn_PodsNamespace.Ripple = true;
            this.radioBtn_PodsNamespace.Size = new System.Drawing.Size(190, 37);
            this.radioBtn_PodsNamespace.TabIndex = 6;
            this.radioBtn_PodsNamespace.TabStop = true;
            this.radioBtn_PodsNamespace.Text = "Listar por Namespace";
            this.radioBtn_PodsNamespace.UseVisualStyleBackColor = true;
            this.radioBtn_PodsNamespace.CheckedChanged += new System.EventHandler(this.radioBtn_PodsNamespace_CheckedChanged);
            // 
            // radioBtn_AllPods
            // 
            this.radioBtn_AllPods.AutoSize = true;
            this.radioBtn_AllPods.Checked = true;
            this.radioBtn_AllPods.Depth = 0;
            this.radioBtn_AllPods.Location = new System.Drawing.Point(17, 303);
            this.radioBtn_AllPods.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtn_AllPods.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioBtn_AllPods.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioBtn_AllPods.Name = "radioBtn_AllPods";
            this.radioBtn_AllPods.Ripple = true;
            this.radioBtn_AllPods.Size = new System.Drawing.Size(111, 37);
            this.radioBtn_AllPods.TabIndex = 5;
            this.radioBtn_AllPods.TabStop = true;
            this.radioBtn_AllPods.Text = "Listar tudo";
            this.radioBtn_AllPods.UseVisualStyleBackColor = true;
            this.radioBtn_AllPods.CheckedChanged += new System.EventHandler(this.radioBtn_AllPods_CheckedChanged);
            // 
            // btn_pods
            // 
            this.btn_pods.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_pods.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_pods.Depth = 0;
            this.btn_pods.HighEmphasis = true;
            this.btn_pods.Icon = null;
            this.btn_pods.Location = new System.Drawing.Point(220, 236);
            this.btn_pods.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_pods.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_pods.Name = "btn_pods";
            this.btn_pods.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_pods.Size = new System.Drawing.Size(64, 36);
            this.btn_pods.TabIndex = 4;
            this.btn_pods.Text = "Pods";
            this.btn_pods.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_pods.UseAccentColor = false;
            this.btn_pods.UseVisualStyleBackColor = true;
            this.btn_pods.Click += new System.EventHandler(this.btn_pods_Click);
            // 
            // btn_Namespaces
            // 
            this.btn_Namespaces.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Namespaces.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Namespaces.Depth = 0;
            this.btn_Namespaces.HighEmphasis = true;
            this.btn_Namespaces.Icon = null;
            this.btn_Namespaces.Location = new System.Drawing.Point(94, 236);
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
            this.bnt_Nodes.Size = new System.Drawing.Size(69, 36);
            this.bnt_Nodes.TabIndex = 0;
            this.bnt_Nodes.Text = "Nodes";
            this.bnt_Nodes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnt_Nodes.UseAccentColor = false;
            this.bnt_Nodes.UseVisualStyleBackColor = true;
            this.bnt_Nodes.Click += new System.EventHandler(this.bnt_Nodes_Click);
            // 
            // TabCreate
            // 
            this.TabCreate.Controls.Add(this.materialLabel9);
            this.TabCreate.Controls.Add(this.cbDeployments);
            this.TabCreate.Controls.Add(this.txtNumeroReplicas);
            this.TabCreate.Controls.Add(this.materialLabel8);
            this.TabCreate.Controls.Add(this.materialLabel7);
            this.TabCreate.Controls.Add(this.materialLabel6);
            this.TabCreate.Controls.Add(this.materialLabel5);
            this.TabCreate.Controls.Add(this.materialLabel4);
            this.TabCreate.Controls.Add(this.cbOptionPod);
            this.TabCreate.Controls.Add(this.cbNodesOption);
            this.TabCreate.Controls.Add(this.cbServices);
            this.TabCreate.Controls.Add(this.cbProtocolo);
            this.TabCreate.Controls.Add(this.txtPorto);
            this.TabCreate.Controls.Add(this.cbOptionNamespace);
            this.TabCreate.Controls.Add(this.txtNome);
            this.TabCreate.Controls.Add(this.btnEliminar);
            this.TabCreate.Controls.Add(this.btnCriar);
            this.TabCreate.Controls.Add(this.radioCriar);
            this.TabCreate.Controls.Add(this.radioEliminar);
            this.TabCreate.Controls.Add(this.materialLabel3);
            this.TabCreate.Controls.Add(this.materialLabel2);
            this.TabCreate.Controls.Add(this.cbOption);
            this.TabCreate.ImageKey = "icons8-docker-50.png";
            this.TabCreate.Location = new System.Drawing.Point(4, 39);
            this.TabCreate.Name = "TabCreate";
            this.TabCreate.Size = new System.Drawing.Size(874, 475);
            this.TabCreate.TabIndex = 3;
            this.TabCreate.Text = "Criar";
            this.TabCreate.UseVisualStyleBackColor = true;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(512, 251);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(94, 19);
            this.materialLabel9.TabIndex = 23;
            this.materialLabel9.Text = "Deployments";
            // 
            // cbDeployments
            // 
            this.cbDeployments.AutoResize = false;
            this.cbDeployments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDeployments.Depth = 0;
            this.cbDeployments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDeployments.DropDownHeight = 174;
            this.cbDeployments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeployments.DropDownWidth = 121;
            this.cbDeployments.Enabled = false;
            this.cbDeployments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbDeployments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDeployments.FormattingEnabled = true;
            this.cbDeployments.IntegralHeight = false;
            this.cbDeployments.ItemHeight = 43;
            this.cbDeployments.Location = new System.Drawing.Point(512, 273);
            this.cbDeployments.MaxDropDownItems = 4;
            this.cbDeployments.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDeployments.Name = "cbDeployments";
            this.cbDeployments.Size = new System.Drawing.Size(196, 49);
            this.cbDeployments.StartIndex = 0;
            this.cbDeployments.TabIndex = 22;
            // 
            // txtNumeroReplicas
            // 
            this.txtNumeroReplicas.AnimateReadOnly = false;
            this.txtNumeroReplicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroReplicas.Depth = 0;
            this.txtNumeroReplicas.Enabled = false;
            this.txtNumeroReplicas.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeroReplicas.Hint = "Nº de Replicas";
            this.txtNumeroReplicas.LeadingIcon = null;
            this.txtNumeroReplicas.Location = new System.Drawing.Point(664, 14);
            this.txtNumeroReplicas.MaxLength = 50;
            this.txtNumeroReplicas.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroReplicas.Multiline = false;
            this.txtNumeroReplicas.Name = "txtNumeroReplicas";
            this.txtNumeroReplicas.Size = new System.Drawing.Size(133, 50);
            this.txtNumeroReplicas.TabIndex = 21;
            this.txtNumeroReplicas.Text = "";
            this.txtNumeroReplicas.TrailingIcon = null;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(512, 166);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(46, 19);
            this.materialLabel8.TabIndex = 20;
            this.materialLabel8.Text = "Nodes";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(512, 85);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(69, 19);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "Protocolo";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(256, 251);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(37, 19);
            this.materialLabel6.TabIndex = 18;
            this.materialLabel6.Text = "Pods";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(256, 166);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(60, 19);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "Services";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(256, 85);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(93, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Namespaces";
            // 
            // cbOptionPod
            // 
            this.cbOptionPod.AutoResize = false;
            this.cbOptionPod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbOptionPod.Depth = 0;
            this.cbOptionPod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbOptionPod.DropDownHeight = 174;
            this.cbOptionPod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOptionPod.DropDownWidth = 121;
            this.cbOptionPod.Enabled = false;
            this.cbOptionPod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbOptionPod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbOptionPod.FormattingEnabled = true;
            this.cbOptionPod.IntegralHeight = false;
            this.cbOptionPod.ItemHeight = 43;
            this.cbOptionPod.Location = new System.Drawing.Point(256, 273);
            this.cbOptionPod.MaxDropDownItems = 4;
            this.cbOptionPod.MouseState = MaterialSkin.MouseState.OUT;
            this.cbOptionPod.Name = "cbOptionPod";
            this.cbOptionPod.Size = new System.Drawing.Size(198, 49);
            this.cbOptionPod.StartIndex = 0;
            this.cbOptionPod.TabIndex = 15;
            // 
            // cbNodesOption
            // 
            this.cbNodesOption.AutoResize = false;
            this.cbNodesOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbNodesOption.Depth = 0;
            this.cbNodesOption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbNodesOption.DropDownHeight = 174;
            this.cbNodesOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNodesOption.DropDownWidth = 121;
            this.cbNodesOption.Enabled = false;
            this.cbNodesOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbNodesOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNodesOption.FormattingEnabled = true;
            this.cbNodesOption.IntegralHeight = false;
            this.cbNodesOption.ItemHeight = 43;
            this.cbNodesOption.Location = new System.Drawing.Point(512, 188);
            this.cbNodesOption.MaxDropDownItems = 4;
            this.cbNodesOption.MouseState = MaterialSkin.MouseState.OUT;
            this.cbNodesOption.Name = "cbNodesOption";
            this.cbNodesOption.Size = new System.Drawing.Size(196, 49);
            this.cbNodesOption.StartIndex = 0;
            this.cbNodesOption.TabIndex = 14;
            // 
            // cbServices
            // 
            this.cbServices.AutoResize = false;
            this.cbServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbServices.Depth = 0;
            this.cbServices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbServices.DropDownHeight = 174;
            this.cbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServices.DropDownWidth = 121;
            this.cbServices.Enabled = false;
            this.cbServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbServices.FormattingEnabled = true;
            this.cbServices.IntegralHeight = false;
            this.cbServices.ItemHeight = 43;
            this.cbServices.Location = new System.Drawing.Point(256, 188);
            this.cbServices.MaxDropDownItems = 4;
            this.cbServices.MouseState = MaterialSkin.MouseState.OUT;
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(198, 49);
            this.cbServices.StartIndex = 0;
            this.cbServices.TabIndex = 13;
            // 
            // cbProtocolo
            // 
            this.cbProtocolo.AutoResize = false;
            this.cbProtocolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbProtocolo.Depth = 0;
            this.cbProtocolo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbProtocolo.DropDownHeight = 174;
            this.cbProtocolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProtocolo.DropDownWidth = 121;
            this.cbProtocolo.Enabled = false;
            this.cbProtocolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbProtocolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbProtocolo.FormattingEnabled = true;
            this.cbProtocolo.IntegralHeight = false;
            this.cbProtocolo.ItemHeight = 43;
            this.cbProtocolo.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.cbProtocolo.Location = new System.Drawing.Point(512, 107);
            this.cbProtocolo.MaxDropDownItems = 4;
            this.cbProtocolo.MouseState = MaterialSkin.MouseState.OUT;
            this.cbProtocolo.Name = "cbProtocolo";
            this.cbProtocolo.Size = new System.Drawing.Size(121, 49);
            this.cbProtocolo.StartIndex = 0;
            this.cbProtocolo.TabIndex = 12;
            // 
            // txtPorto
            // 
            this.txtPorto.AnimateReadOnly = false;
            this.txtPorto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPorto.Depth = 0;
            this.txtPorto.Enabled = false;
            this.txtPorto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPorto.Hint = "Porto";
            this.txtPorto.LeadingIcon = null;
            this.txtPorto.Location = new System.Drawing.Point(512, 14);
            this.txtPorto.MaxLength = 50;
            this.txtPorto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPorto.Multiline = false;
            this.txtPorto.Name = "txtPorto";
            this.txtPorto.Size = new System.Drawing.Size(146, 50);
            this.txtPorto.TabIndex = 11;
            this.txtPorto.Text = "";
            this.txtPorto.TrailingIcon = null;
            // 
            // cbOptionNamespace
            // 
            this.cbOptionNamespace.AutoResize = false;
            this.cbOptionNamespace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbOptionNamespace.Depth = 0;
            this.cbOptionNamespace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbOptionNamespace.DropDownHeight = 174;
            this.cbOptionNamespace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOptionNamespace.DropDownWidth = 121;
            this.cbOptionNamespace.Enabled = false;
            this.cbOptionNamespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbOptionNamespace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbOptionNamespace.FormattingEnabled = true;
            this.cbOptionNamespace.IntegralHeight = false;
            this.cbOptionNamespace.ItemHeight = 43;
            this.cbOptionNamespace.Location = new System.Drawing.Point(256, 107);
            this.cbOptionNamespace.MaxDropDownItems = 4;
            this.cbOptionNamespace.MouseState = MaterialSkin.MouseState.OUT;
            this.cbOptionNamespace.Name = "cbOptionNamespace";
            this.cbOptionNamespace.Size = new System.Drawing.Size(239, 49);
            this.cbOptionNamespace.StartIndex = 0;
            this.cbOptionNamespace.TabIndex = 10;
            this.cbOptionNamespace.SelectedIndexChanged += new System.EventHandler(this.cbOptionNamespace_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Depth = 0;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(256, 14);
            this.txtNome.MaxLength = 50;
            this.txtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(239, 50);
            this.txtNome.TabIndex = 9;
            this.txtNome.Text = "";
            this.txtNome.TrailingIcon = null;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(355, 381);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(88, 36);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCriar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCriar.Depth = 0;
            this.btnCriar.Enabled = false;
            this.btnCriar.HighEmphasis = true;
            this.btnCriar.Icon = null;
            this.btnCriar.Location = new System.Drawing.Point(283, 381);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCriar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCriar.Size = new System.Drawing.Size(64, 36);
            this.btnCriar.TabIndex = 7;
            this.btnCriar.Text = "Criar";
            this.btnCriar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCriar.UseAccentColor = false;
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // radioCriar
            // 
            this.radioCriar.AutoSize = true;
            this.radioCriar.Depth = 0;
            this.radioCriar.Location = new System.Drawing.Point(14, 64);
            this.radioCriar.Margin = new System.Windows.Forms.Padding(0);
            this.radioCriar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioCriar.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioCriar.Name = "radioCriar";
            this.radioCriar.Ripple = true;
            this.radioCriar.Size = new System.Drawing.Size(68, 37);
            this.radioCriar.TabIndex = 6;
            this.radioCriar.TabStop = true;
            this.radioCriar.Text = "Criar";
            this.radioCriar.UseVisualStyleBackColor = true;
            this.radioCriar.CheckedChanged += new System.EventHandler(this.radioCriar_CheckedChanged);
            // 
            // radioEliminar
            // 
            this.radioEliminar.AutoSize = true;
            this.radioEliminar.Depth = 0;
            this.radioEliminar.Location = new System.Drawing.Point(14, 101);
            this.radioEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.radioEliminar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioEliminar.Name = "radioEliminar";
            this.radioEliminar.Ripple = true;
            this.radioEliminar.Size = new System.Drawing.Size(93, 37);
            this.radioEliminar.TabIndex = 5;
            this.radioEliminar.TabStop = true;
            this.radioEliminar.Text = "Eliminar";
            this.radioEliminar.UseVisualStyleBackColor = true;
            this.radioEliminar.CheckedChanged += new System.EventHandler(this.radioEliminar_CheckedChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(12, 24);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(217, 29);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Escolha uma acção:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(12, 152);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(218, 29);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Escolha uma opção:";
            // 
            // cbOption
            // 
            this.cbOption.AutoResize = false;
            this.cbOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbOption.Depth = 0;
            this.cbOption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbOption.DropDownHeight = 174;
            this.cbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption.DropDownWidth = 121;
            this.cbOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbOption.FormattingEnabled = true;
            this.cbOption.IntegralHeight = false;
            this.cbOption.ItemHeight = 43;
            this.cbOption.Items.AddRange(new object[] {
            "Pod",
            "Namespace",
            "Deployment",
            "Service"});
            this.cbOption.Location = new System.Drawing.Point(12, 188);
            this.cbOption.MaxDropDownItems = 4;
            this.cbOption.MouseState = MaterialSkin.MouseState.OUT;
            this.cbOption.Name = "cbOption";
            this.cbOption.Size = new System.Drawing.Size(192, 49);
            this.cbOption.StartIndex = 0;
            this.cbOption.TabIndex = 0;
            this.cbOption.SelectedIndexChanged += new System.EventHandler(this.cbOption_SelectedIndexChanged);
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
            this.imageList1.Images.SetKeyName(0, "icons8-home-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-dashboard-64.png");
            this.imageList1.Images.SetKeyName(2, "icons8-docker-50.png");
            this.imageList1.Images.SetKeyName(3, "icons8-list-50.png");
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
            this.TabCreate.ResumeLayout(false);
            this.TabCreate.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton btn_pods;
        private MaterialSkin.Controls.MaterialComboBox cb_namespaces;
        private MaterialSkin.Controls.MaterialRadioButton radioBtn_PodsNamespace;
        private MaterialSkin.Controls.MaterialRadioButton radioBtn_AllPods;
        private MaterialSkin.Controls.MaterialButton btnDeployments;
        private MaterialSkin.Controls.MaterialButton btn_services;
        private TabPage TabCreate;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cbOption;
        private MaterialSkin.Controls.MaterialRadioButton radioCriar;
        private MaterialSkin.Controls.MaterialRadioButton radioEliminar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnCriar;
        private MaterialSkin.Controls.MaterialTextBox txtNome;
        private MaterialSkin.Controls.MaterialComboBox cbOptionNamespace;
        private MaterialSkin.Controls.MaterialTextBox txtPorto;
        private MaterialSkin.Controls.MaterialComboBox cbProtocolo;
        private MaterialSkin.Controls.MaterialComboBox cbServices;
        private MaterialSkin.Controls.MaterialComboBox cbNodesOption;
        private MaterialSkin.Controls.MaterialComboBox cbOptionPod;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtNumeroReplicas;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialComboBox cbDeployments;
    }
}