using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Auth;
using System.Drawing;

namespace AzureTableApp
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Tablebutton_Click(object sender, EventArgs e)
        {
            var tableName = TabletextBox.Text;
            Regex regex = new Regex("^[A-Za-z][A-Za-z0-9]*$");//Azure Table Name validation
            Match match = regex.Match(tableName);
            if (tableName == "" || !(match.Success))
            {
                MessageBox.Show("Table Names must be alphanumeric, cannot begin with a number, and must be between 3 and 36 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    var storageAccount = "hab1hydstorage";
                    var key = "UWTY4xDOszXlKJY4qv8fj467xhjScEMZwgT9ooGGJmr0IcqPLEk6RfpVj6esWATabpQDIAkuXd3WLBha6laJtg==";
                    StorageCredentials storeCred = new StorageCredentials(storageAccount, key);
                    CloudStorageAccount cloudStoreAccount = new CloudStorageAccount(storeCred, useHttps: true);
                    CloudTableClient cloudTableClient = cloudStoreAccount.CreateCloudTableClient();
                    CloudTable table = cloudTableClient.GetTableReference(tableName);
                    table.CreateIfNotExists();
                    MessageBox.Show(tableName + " " + "Table created successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    TabletextBox.Text = "";
                }
                catch (Exception)
                {

                    throw;
                }

            }
            

        }

        private void AddDatabutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IdtextBox.Text) || (String.IsNullOrEmpty(NametextBox.Text) || (String.IsNullOrEmpty(PricetextBox.Text))))
            {
                MessageBox.Show("Product Id, Name and Price cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    var storageAccount = "hab1hydstorage";
                    var key = "UWTY4xDOszXlKJY4qv8fj467xhjScEMZwgT9ooGGJmr0IcqPLEk6RfpVj6esWATabpQDIAkuXd3WLBha6laJtg==";
                    StorageCredentials storeCred = new StorageCredentials(storageAccount, key);
                    CloudStorageAccount cloudStoreAccount = new CloudStorageAccount(storeCred, useHttps: true);
                    CloudTableClient cloudTableClient = cloudStoreAccount.CreateCloudTableClient();
                    CloudTable table = cloudTableClient.GetTableReference("producttable");
                    table.CreateIfNotExists();
                    var prodEntity = new Product()
                    {
                        ProdId = Int32.Parse(IdtextBox.Text),
                        ProdName = NametextBox.Text.ToString(),
                        Price = double.Parse(PricetextBox.Text)
                    };
                    prodEntity.RowKey = prodEntity.ProdId + " " + ProductName;
                    prodEntity.PartitionKey = prodEntity.ProdName;
                    TableOperation tableOperation = TableOperation.Insert(prodEntity);
                    table.Execute(tableOperation);
                    MessageBox.Show("Product records inserted in producttable successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    IdtextBox.Text = "";
                    NametextBox.Text = "";
                    PricetextBox.Text = "";
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private void Blobbutton_Click(object sender, EventArgs e)
        {
            var storageAccount = "hab1hydstorage";
            var key = "UWTY4xDOszXlKJY4qv8fj467xhjScEMZwgT9ooGGJmr0IcqPLEk6RfpVj6esWATabpQDIAkuXd3WLBha6laJtg==";
            StorageCredentials storeCred = new StorageCredentials(storageAccount, key);
            CloudStorageAccount cloudStoreAccount = new CloudStorageAccount(storeCred, useHttps: true);
            CloudTableClient cloudTableClient = cloudStoreAccount.CreateCloudTableClient();
            CloudTable table = cloudTableClient.GetTableReference("producttable");
            table.CreateIfNotExists();
            TableQuery<Product> query = new TableQuery<Product>();
            var prodEntities = table.ExecuteQuery(query);
            foreach (var entity in prodEntities)
            {
                listBox1.Items.Add(entity.ProdId + " " + entity.ProdName + " " + entity.Price);
            }
        }
    }
}
