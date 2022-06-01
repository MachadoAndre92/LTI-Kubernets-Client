using k8s;
using k8s.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace Kubernets
{
    public partial class Form1 : MaterialForm
    {

        public Kubernetes cliente;



        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        public Kubernetes login()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                try
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                        //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);


                        var config = KubernetesClientConfiguration.BuildConfigFromConfigFile(filePath);
                        cliente = new Kubernetes(config);

                        MessageBox.Show("Ficheiro lido com sucesso!");

                        getNodes();
                        


                        return cliente;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return cliente;
                }

            }
            return cliente;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void bnt_Nodes_Click(object sender, EventArgs e)
        {
            lbl_ListView.Text = "Nodes";
            getNodes();
        }

        private void getNodes()
        {
            lbl_ListView.Text = "Nodes";

            V1NodeList nodes = new V1NodeList();
            try
            {
                nodes = cliente.ListNode();
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", e.Message.ToString());
                return;
            }


            listView1.Clear();

            //listView1.View = View.Details;
            listView1.Columns.Add("Nome:", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Data Criaçao:", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Arquitectura", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("OS:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Versao:", -2, HorizontalAlignment.Left);


            foreach (var node in nodes.Items)
            {

                ListViewItem item2Add = new ListViewItem(node.Metadata.Name);
                item2Add.SubItems.Add(node.Metadata.CreationTimestamp.ToString());
                //item2Add.SubItems.Add(node.Spec.PodCIDR.ToString());
                item2Add.SubItems.Add(node.Status.NodeInfo.Architecture);
                //item2Add.SubItems.Add(node.Metadata.Uid.ToString());
                item2Add.SubItems.Add(node.Status.NodeInfo.OsImage);
                item2Add.SubItems.Add(node.Status.NodeInfo.KubeletVersion);

                listView1.Items.Add(item2Add);

            }

            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);  // autosize colunas
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_Namespaces_Click(object sender, EventArgs e)
        {
            lbl_ListView.Text = "Namespaces";
            getNamespaces();
        }

        private void getNamespaces()
        {

            V1NamespaceList namespaces = new V1NamespaceList();
            try
            {
                namespaces = cliente.ListNamespace();
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", e.Message.ToString());
                return;
            }
            

            listView1.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("Nome:", 20, HorizontalAlignment.Left);
            listView1.Columns.Add("Data Criaçao:", 50, HorizontalAlignment.Left);
            //listView1.Columns.Add("Uid:", -2, HorizontalAlignment.Left);

            listView1.Columns.Add("Estado:", 20, HorizontalAlignment.Left);

            foreach (var namespace1 in namespaces.Items)
            {

                ListViewItem item2Add = new ListViewItem(namespace1.Metadata.Name);
                item2Add.SubItems.Add(namespace1.Metadata.CreationTimestamp.ToString());
                item2Add.SubItems.Add(namespace1.Status.Phase);

                listView1.Items.Add(item2Add);

            }

            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);  // autosize colunas
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_pods_Click(object sender, EventArgs e)
        {
            if (radioBtn_AllPods.Checked)
            {
                get_pods();
            }
            else
            {
                getPodsNamespace(cb_namespaces.Text);
            }
            
        }

        private void get_pods()
        {

            V1PodList pods = new V1PodList();
            try
            {
                pods = cliente.ListPodForAllNamespaces();    //todos os namespaces;
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", e.Message.ToString());
                return;
            }


            lbl_ListView.Text = "Pods";

            listView1.Clear();

            listView1.Columns.Add("Nome:", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Namespace:", -2, HorizontalAlignment.Left);
            //listView1.Columns.Add("Data Criaçao:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Estado:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Containers:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Pod IP:", -2, HorizontalAlignment.Left);


            
            foreach (var pod in pods.Items)
            {

                ListViewItem item2Add = new ListViewItem(pod.Metadata.Name);
                item2Add.SubItems.Add(pod.Metadata.Namespace().ToString());
                item2Add.SubItems.Add(pod.Status.Phase);
                item2Add.SubItems.Add(pod.Spec.Containers.Count.ToString());
                //item2Add.SubItems.Add(pod.Metadata.CreationTimestamp.ToString());
                item2Add.SubItems.Add(pod.Status.PodIP);
                //item2Add.SubItems.Add(pod.Metadata.Uid.ToString());

                listView1.Items.Add(item2Add);

            }

            listView1.Show();

            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);  // autosize colunas
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void fillCbNamespaces()
        {

            cb_namespaces.Items.Clear();

            V1NamespaceList namespaces = new V1NamespaceList();
            try
            {
                namespaces = cliente.ListNamespace();
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", e.Message.ToString());
                return;
            }

            

            foreach (var namespace1 in namespaces.Items)
            {

                cb_namespaces.Items.Add(namespace1.Metadata.Name);

            }
            cb_namespaces.SelectedIndex=0;
        }

        private void radioBtn_PodsNamespace_CheckedChanged(object sender, EventArgs e)
        {
            //btn_pods.Enabled = false;
            cb_namespaces.Enabled = true;
            fillCbNamespaces();


        }

        private void getPodsNamespace(string namespaceName)
        {
            V1PodList pods = new V1PodList();  
            try
            {
                pods = cliente.ListNamespacedPod(namespaceName);  //filtrar por namespace
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", e.Message.ToString());
                return;
            }

            lbl_ListView.Text = "Pods by Namespace";

            listView1.Clear();
       
            listView1.Columns.Add("Nome:", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Namespace:", -2, HorizontalAlignment.Left);
            //listView1.Columns.Add("Data Criaçao:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Estado:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Nº de Containers:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Pod IP:", -2, HorizontalAlignment.Left);

            foreach (var pod in pods.Items)
            {

                ListViewItem item2Add = new ListViewItem(pod.Metadata.Name);
                item2Add.SubItems.Add(pod.Metadata.Namespace().ToString());
                item2Add.SubItems.Add(pod.Status.Phase);
                item2Add.SubItems.Add(pod.Spec.Containers.Count.ToString());
                //item2Add.SubItems.Add(pod.Spec.Containers);
                item2Add.SubItems.Add(pod.Status.PodIP);
                //item2Add.SubItems.Add(pod.Metadata.Uid.ToString());

                listView1.Items.Add(item2Add);

            }
        
                       
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);  // autosize colunas
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void radioBtn_AllPods_CheckedChanged(object sender, EventArgs e)
        {
            //btn_pods.Enabled = true;
            cb_namespaces.Enabled = false;

        }

        private void cb_namespaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getPodsNamespace(cb_namespaces.Text);
        }

        private void btnDeployments_Click(object sender, EventArgs e)
        {
            if (radioBtn_AllPods.Checked)
            {
                getDeployments();
            }
            else
            {
                getDeploymentsNamespace(cb_namespaces.Text);
            }
            
           
        }

        private void getDeploymentsNamespace(string nameSpace)
        {
            V1DeploymentList deployments = new V1DeploymentList();

            try
            {
                deployments = cliente.ListNamespacedDeployment(nameSpace);
                
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", ex.Message.ToString());
                return;
            }

            lbl_ListView.Text = "Deployments";

            listView1.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("Nome:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Namespace:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Nº replicas:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Actualizado:", -2, HorizontalAlignment.Left);


            foreach (var deploy in deployments.Items)
            {

                ListViewItem item2Add = new ListViewItem(deploy.Metadata.Name);
                item2Add.SubItems.Add(deploy.Metadata.Namespace().ToString());
                item2Add.SubItems.Add(deploy.Status.Replicas.ToString());
                item2Add.SubItems.Add(deploy.Status.UpdatedReplicas.ToString());

                listView1.Items.Add(item2Add);

            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);  // autosize colunas
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void getDeployments()
        {
            V1DeploymentList deployments = new V1DeploymentList();

            try
            {
                deployments = cliente.ListDeploymentForAllNamespaces();   //deployments de todos os namespaces
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", ex.Message.ToString());
                return;
            }

            lbl_ListView.Text = "Deployments";

            listView1.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("Nome:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Namespace:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Nº replicas:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Actualizado:", -2, HorizontalAlignment.Left);


            foreach (var deploy in deployments.Items)
            {

                ListViewItem item2Add = new ListViewItem(deploy.Metadata.Name);
                item2Add.SubItems.Add(deploy.Metadata.Namespace().ToString());
                item2Add.SubItems.Add(deploy.Status.Replicas.ToString());
                item2Add.SubItems.Add(deploy.Status.UpdatedReplicas.ToString());

                listView1.Items.Add(item2Add);

            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);  // autosize colunas
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public string converterdeploy(string v1, string v2)
        {

            string deploy = v1 + "/" + v2;
            return deploy;
        }

        private void btn_services_Click(object sender, EventArgs e)
        {

            if (radioBtn_AllPods.Checked)
            {
                getAllServices();
            }
            else
            {
                getServicesNamespace(cb_namespaces.Text);
            }

            
        }

        private void getServicesNamespace(string nameSpaces)
        {
            V1ServiceList services = new V1ServiceList();
            try
            {
                services = cliente.ListNamespacedService(nameSpaces);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", ex.Message.ToString());
                return;
            }

            lbl_ListView.Text = "Services";

            listView1.Clear();

            listView1.Columns.Add("Nome:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Namespace:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Tipo:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Cluster-IP:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Portos/Protocolos:", -2, HorizontalAlignment.Left);

            foreach (var service in services.Items)
            {

                ListViewItem item2Add = new ListViewItem(service.Metadata.Name.ToString());
                item2Add.SubItems.Add(service.Metadata.Namespace().ToString());
                item2Add.SubItems.Add(service.Spec.Type.ToString());
                item2Add.SubItems.Add(service.Spec.ClusterIP.ToString());
                item2Add.SubItems.Add(converterdeploy(service.Spec.Ports[0].Port.ToString(), service.Spec.Ports[0].Protocol));

                listView1.Items.Add(item2Add);

            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);  // autosize colunas
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void getAllServices()
        {
            V1ServiceList services = new V1ServiceList();
            try
            {
                services = cliente.ListServiceForAllNamespaces();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", ex.Message.ToString());
                return;
            }

            lbl_ListView.Text = "Services";

            listView1.Clear();

            listView1.Columns.Add("Nome:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Namespace:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Tipo:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Cluster-IP:", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Portos/Protocolos:", -2, HorizontalAlignment.Left);

            foreach (var service in services.Items)
            {

                ListViewItem item2Add = new ListViewItem(service.Metadata.Name.ToString());
                item2Add.SubItems.Add(service.Metadata.Namespace().ToString());
                item2Add.SubItems.Add(service.Spec.Type.ToString());
                item2Add.SubItems.Add(service.Spec.ClusterIP.ToString());
                item2Add.SubItems.Add(converterdeploy(service.Spec.Ports[0].Port.ToString(), service.Spec.Ports[0].Protocol));

                listView1.Items.Add(item2Add);

            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);  // autosize colunas
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void radioCriar_CheckedChanged(object sender, EventArgs e)
        {

            btnCriar.Enabled = radioCriar.Checked;
            btnEliminar.Enabled = radioEliminar.Checked;

            

           
        }

        private void radioEliminar_CheckedChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = radioEliminar.Checked;
            btnCriar.Enabled=radioCriar.Checked;
            
        }

        private void cbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            txtPorto.Enabled=false;

            switch (cbOption.SelectedIndex)
            {
                //Opção de PODS
                case 0:
                    if (radioEliminar.Checked)
                    {
                        txtNome.Enabled = false;
                        cbOptionNamespace.Enabled = true;
                        cbNodesOption.Enabled = false;
                        txtPorto.Enabled = false;
                        cbServices.Enabled = false;
                        cbProtocolo.Enabled = false;
                        cbOptionPod.Enabled = true;
                        getCbOptionNamespace();
                        getCbOtionPod();
                        txtNumeroReplicas.Enabled = false;
                    }
                    else
                    {
                        txtNome.Enabled = true;
                        cbOptionNamespace.Enabled = true;
                        cbNodesOption.Enabled = true;
                        txtPorto.Enabled = false;
                        cbServices.Enabled = false;
                        cbProtocolo.Enabled = false;
                        cbOptionPod.Enabled = false;
                        getCbOptionNamespace();
                        getCbNodeOption();
                        txtNumeroReplicas.Enabled = false;
                    }
                    break;

                //Opção NAMESPACE
                case 1:
                    if (radioEliminar.Checked)
                    {
                        cbOptionNamespace.Enabled = true;
                        getCbOptionNamespace();

                        txtNome.Enabled = false;
                        cbNodesOption.Enabled = false;
                        txtPorto.Enabled = false;
                        cbServices.Enabled = false;
                        cbProtocolo.Enabled = false;
                        cbOptionPod.Enabled = false;
                        txtNumeroReplicas.Enabled = false;
                    }
                    else
                    {
                        txtNome.Enabled = true;
                    
                        cbOptionNamespace.Enabled = false;
                        cbNodesOption.Enabled = false;
                        txtPorto.Enabled = false;
                        cbServices.Enabled = false;
                        cbProtocolo.Enabled = false;
                        cbOptionPod.Enabled = false;
                        txtNumeroReplicas.Enabled = false;
                    }
                    break;
                //Deployments
                case 2:
                    if (radioEliminar.Checked)
                    {
                        cbDeployments.Enabled = true;
                        cbOptionNamespace.Enabled = true;
                        cbOptionPod.Enabled = false;
                        getCbOptionNamespace();
                        getCbDeployments();

                        txtNumeroReplicas.Enabled = false;
                    }
                    else
                    {
                        txtNome.Enabled = true;
                        txtPorto.Enabled = true;
                        txtNumeroReplicas.Enabled = true;
                        cbOptionNamespace.Enabled = true;
                        cbOptionPod.Enabled = false;
                        getCbOptionNamespace();
                        
                    }
                    break;
                //Opção SERVICES
                case 3:
                    if (radioEliminar.Checked)
                    {
                        cbServices.Enabled = true;
                        cbOptionNamespace.Enabled = true;
                        getCbOptionNamespace();

                        txtNome.Enabled = false;                        
                        cbNodesOption.Enabled = false;
                        txtPorto.Enabled = false;                        
                        cbProtocolo.Enabled = false;
                        cbOptionPod.Enabled = false;

                        txtNumeroReplicas.Enabled = false;
                        getServices();

                    }
                    else
                    {
                        txtNome.Enabled = true;
                        txtPorto.Enabled = true;
                        cbProtocolo.Enabled = true;
                        cbOptionNamespace.Enabled = true;
                        cbOptionPod.Enabled = false;
                        getCbOptionNamespace();

                                             
                        cbNodesOption.Enabled = false;                        
                        cbServices.Enabled = false;
                        txtNumeroReplicas.Enabled = false;


                    }
                    break;
            }



        }

        private void getCbDeployments()
        {
            cbDeployments.Items.Clear();

            V1DeploymentList deployments = new V1DeploymentList();

            try
            {
                deployments = cliente.ListNamespacedDeployment(cbOptionNamespace.Text);
                
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", ex.Message.ToString());
                return;
            }

            foreach(var deployment in deployments.Items)
            {
                cbDeployments.Items.Add(deployment.Metadata.Name);
            }
        }

        private void createDeployment()
        {
            string nome = txtNome.Text;
            int porto = Convert.ToInt32(txtPorto.Text);
            int replicas = Convert.ToInt32(txtNumeroReplicas.Text);
            string img = "nginx";

            V1Deployment deployment = new V1Deployment()
            {
                ApiVersion = "apps/v1",
                Kind = "Deployment",
                Metadata = new V1ObjectMeta()
                {
                    Name = nome,
                    NamespaceProperty = null,
                    Labels = new Dictionary<string, string>()
                    {
                        { "app", nome }
                    }
                },
                Spec = new V1DeploymentSpec
                {
                    Replicas = replicas,
                    Selector = new V1LabelSelector()
                    {
                        MatchLabels = new Dictionary<string, string>
                        {
                            { "app", nome }
                        }
                    },
                    Template = new V1PodTemplateSpec()
                    {
                        Metadata = new V1ObjectMeta()
                        {
                            CreationTimestamp = null,
                            Labels = new Dictionary<string, string>
                            {
                                { "app", nome }
                            }
                        },
                        Spec = new V1PodSpec
                        {
                            Containers = new List<V1Container>()
                            {
                                new V1Container()
                                {
                                    Name = nome ,
                                    Image = img,
                                    ImagePullPolicy = "Always",
                                    Ports = new List<V1ContainerPort> { new V1ContainerPort(porto) }
                                }
                            }
                        }
                    }
                },
                Status = new V1DeploymentStatus()
                {
                    Replicas = replicas
                }
            };
            try
            {
                cliente.CreateNamespacedDeployment(deployment, cbOptionNamespace.Text);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return;
            }
            
        }

        private void getCbOtionPod()
        {
            cbOptionPod.Items.Clear();

            V1PodList pods = new V1PodList();
            try
            {
                pods = cliente.ListNamespacedPod(cbOptionNamespace.Text);    //todos os namespaces;
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", e.Message.ToString());
                return;
            }

            foreach (V1Pod pod in pods.Items)
            {
                cbOptionPod.Items.Add(pod.Metadata.Name);
            }
            if (cbOptionPod.Items.Count != 0)
            {
                cbOptionPod.SelectedIndex = 0;
            }
            


        }

        private void getCbNodeOption()
        {
            cbNodesOption.Items.Clear();
            
            V1NodeList nodes = new V1NodeList();
            try
            {
                nodes = cliente.ListNode();
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", e.Message.ToString());
                return;
            }

            foreach(var node in nodes.Items)
            {
                cbNodesOption.Items.Add(node.Metadata.Name);
            }

            if (cbNodesOption.Items.Count != 0)
            {
                cbNodesOption.SelectedIndex = 0;
            }
            
        }

        private void getServices()
        {
            cbServices.Items.Clear();

            V1ServiceList services = new V1ServiceList();
            try
            {
                
                services = cliente.ListNamespacedService(cbOptionNamespace.Text);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", ex.Message.ToString());
                return;
            }

            foreach (var service in services.Items)
            {

                cbServices.Items.Add(service.Metadata.Name);

            }
            if (cbServices.Items.Count != 0)
            {
                cbServices.SelectedIndex = 0;
            }
            


        }

        private void getCbOptionNamespace()
        {

            cbOptionNamespace.Items.Clear();

            V1NamespaceList namespaces = new V1NamespaceList();
            try
            {
                namespaces = cliente.ListNamespace();
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Ficheiro de configuração errado ou em falta", e.Message.ToString());
                return;
            }

            foreach (var namespace1 in namespaces.Items)
            {

                cbOptionNamespace.Items.Add(namespace1.Metadata.Name);

            }
            if(cbOptionNamespace.Items.Count != 0)
            {
                cbOptionNamespace.SelectedIndex = 0;
                getServices();
                getCbDeployments();
                getCbOtionPod();
            }
            
        }

        private void createNamespace()
        {
            /*
            var myWebClient = new WebClient();
            string url = "http://" + textBoxIP.Text + "/api/v1/namespaces";
            var body = "{\"apiVersion\": \"v1\",\"kind\": \"Namespace\",\"metadata\": {\"name\": \"" + nspace + "\"}}";
            myWebClient.UploadString("http://" + textBoxIP.Text + "/compute/v2.1/servers", body);

            */
            string nome = txtNome.Text;

            var ns = new V1Namespace { Metadata = new V1ObjectMeta { Labels = new Dictionary<string, string>() { { "app", nome } }, Name = nome } };

            try
            {
                cliente.CreateNamespace(ns);
            }catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            
            

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            switch (cbOption.SelectedIndex)
            {
                case 0:
                    createPod();
                    break;
                case 1:
                    createNamespace();
                    break;
                case 2:
                    createDeployment();
                    break;
                case 3:
                    createService();
                    
                    break;
            }
            
        }

        private void createPod()
        {
            string nome = txtNome.Text;
            string imagemse = "nginx";
            string node = cbNodesOption.Text;

            var pod = new V1Pod { Metadata = new V1ObjectMeta { Labels = new Dictionary<string, string>() { { "app", nome } }, Name = nome }, Spec = new V1PodSpec { Containers = new List<V1Container>() { new V1Container { Name = nome, Image = imagemse } }, NodeName = node, HostNetwork = true } };

            try
            {
                cliente.CreateNamespacedPod(pod, cbOptionNamespace.Text);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            MessageBox.Show("Pod " + nome + " criado com sucesso no node:" + node);
        }

        private void createService()
        {
            

            string nome = txtNome.Text;
            string protocol = cbProtocolo.Text; 
            int porto = Convert.ToInt32(txtPorto.Text);

            var createService = new V1Service
            {
                Metadata = new V1ObjectMeta { Name = nome },
                Spec = new V1ServiceSpec
                {
                    Type = "NodePort",
                    Selector = new Dictionary<string, string>() { { "app", nome } },
                    Ports = new List<V1ServicePort>() { new V1ServicePort { Protocol = protocol, Port = porto } }
                }

            };

            try
            {
                cliente.CreateNamespacedService(createService, cbOptionNamespace.Text);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }

            MessageBox.Show("Serviço "+ nome +" no porto "+porto+" com o protocolo "+protocol+" criado com sucesso.");

        }

        private void delete_namespace()
        {
            string nome = cbOptionNamespace.Text;

            Task<V1Status> status;
            try
            {
                status = cliente.DeleteNamespaceAsync(nome, new V1DeleteOptions());

            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return;
            }

            MessageBox.Show("Namespace " + nome + " eliminado.");

            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            switch (cbOption.SelectedIndex)
            {
                case 0:
                    delete_pode();
                    break;
                case 1:
                    delete_namespace();
                    break;
                case 2:
                    delete_deployment();
                    break;
                case 3:
                    delete_service();
                    break;
            }

            
        }

        private void delete_deployment()
        {
            string nome = cbDeployments.Text;

            try
            {
                cliente.DeleteNamespacedDeploymentAsync(nome, cbOptionNamespace.Text, new V1DeleteOptions());
            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return;
            }
            
        }

        private void delete_pode()
        {
            string nome = cbOptionPod.Text;
            try
            {
                cliente.DeleteNamespacedPodAsync(nome, cbOptionNamespace.Text, new V1DeleteOptions());
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return;
            }
            MessageBox.Show("Pod " + nome + " eliminado");
        }

        private void delete_service()
        {
            string nome = cbServices.Text;
            try
            {
                cliente.DeleteNamespacedServiceAsync(nome, cbOptionNamespace.Text, new V1DeleteOptions());
            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return;
            }
            MessageBox.Show("Serviço " + nome + " eliminado com sucesso.");
        }

        private void cbOptionNamespace_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCbOtionPod();
            getServices();
            getCbDeployments();
        }
    }
}