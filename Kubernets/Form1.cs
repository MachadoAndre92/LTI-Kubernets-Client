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

            
            


            //private void CreateListView()
            //{
            //    listViewNamespaces.Clear();
            //    //criar colunas para as instancias
            //    listViewNamespaces.View = View.Details; //para mostrar os cabe�alhos
            //    listViewNamespaces.Columns.Add("Nome");
            //    listViewNamespaces.Columns.Add("uid");
            //    listViewNamespaces.Columns.Add("Data de Cria��o");
            //    listViewNamespaces.Columns.Add("Estado");


            //    foreach(var Np in Namespace.Items)
            //    {
            //        listViewNamespaces.View = View.Details;

            //        ListViewItem item1 = new ListViewItem(Np.metadata.name);

            //        item1.SubItems.Add(Np.metadata.uid);       
            //        item1.SubItems.Add(Np.metadata.creationTimestamp);
            //        item1.SubItems.Add(Np.status.phase);

            //        listViewNamespaces.Items.Add(item1);

            //        listViewNamespaces.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //        listViewNamespaces.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);  // autosize colunas

            //    }


            //}

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
                }catch(Exception e)
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

            V1NodeList nodes=new V1NodeList();
            try
            {
                nodes = cliente.ListNode();
            }catch(NullReferenceException e)
            {
                MessageBox.Show("Ficheiro de configura��o errado ou em falta",e.Message.ToString());
                return;
            }
            

            listView1.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("Nome:",-2, HorizontalAlignment.Left);
            listView1.Columns.Add("Data Cria�ao:",100, HorizontalAlignment.Left);
            listView1.Columns.Add("Arquitectura",-2, HorizontalAlignment.Left);
            listView1.Columns.Add("OS:",-2, HorizontalAlignment.Left);
            listView1.Columns.Add("Versao:",-2, HorizontalAlignment.Left);
            

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
            lbl_ListView.Text="Namespaces";
            getNamespaces();
        }

        private void getNamespaces()
        {
            var namespaces = cliente.ListNamespace();

            listView1.Clear();

            listView1.View = View.Details;
            listView1.Columns.Add("Nome:", 20, HorizontalAlignment.Left);
            listView1.Columns.Add("Data Cria�ao:", 50, HorizontalAlignment.Left);
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
    }
}