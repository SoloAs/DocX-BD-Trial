using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Novacode;

namespace DocXTask
{
    public partial class MyForm : Form
    {
        public bool TableIsReady { get; set; }
        public bool TemplateIsReady { get; set; }
        public TextOperator textOperator { get; private set; }
    

        public MyForm()
        {
            InitializeComponent();
            TableIsReady = TemplateIsReady = false;
            textOperator = new TextOperator();
            try
            {
                using (OrdersDBEntities db = new OrdersDBEntities())
                {
                    CustomersGrid.DataSource = db.Customers;
                    MessageBox.Show("Choose customer and template");
                }
            }
            catch
            {
                MessageBox.Show("Database not found");
                System.Environment.Exit(0);
            }
            

        }


        private void CustomersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (OrdersDBEntities db = new OrdersDBEntities())
            {
                if (textOperator.Words.Count != 0) textOperator.Words.Clear();
                var properties = db.Customers.EntitySet.ElementType.Properties;
                for (int i = 0; i < CustomersGrid.ColumnCount; i++)
                {
                    if (CustomersGrid[i, e.RowIndex].Value != null)
                        textOperator.Words.Add(properties[i].Name, CustomersGrid[i, e.RowIndex].Value.ToString());
                }
                try
                {
                    textOperator.Head = db.People.Where(person => person.PositionId == "Директор").First();
                }
                catch
                {
                    MessageBox.Show("Warning: Head not found");
                    textOperator.Head = null;                  
                }
            }
            TableIsReady = true;
        }

        
        private void Form1_Resize(object sender, EventArgs e)
        {
            OpenFileBtn.Location = new Point(CustomersGrid.Location.X + 112, CustomersGrid.Location.Y + CustomersGrid.Height + 6);
            ChooseTemplateBtn.Location = new Point(CustomersGrid.Location.X,
                CustomersGrid.Location.Y + CustomersGrid.Height + 6);

        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            if (TableIsReady && TemplateIsReady)
            {
                textOperator.Replace();
            }
            else
                MessageBox.Show("Choose customer and template");
        }

        private void ChooseTemplateBtn_Click(object sender, EventArgs e)
        {
            OpenTemplateDialog.ShowDialog();
            try
            {
                textOperator.FileName = OpenTemplateDialog.FileName;
                textOperator.Doc = DocX.Load(OpenTemplateDialog.FileName);
                TemplateIsReady = true;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
    }
}
