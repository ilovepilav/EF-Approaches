using _2_CodeFirst.DataAccessLayer.Context;
using _2_CodeFirst.EntityLayer.Entities.Concrete;
using _2_CodeFirst.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbCategoryPicker.Hide();
            txtAddDescription.Show();
            dataGridMain.DataSource = db.Categories.Where(x => x.Status != Status.Passive).ToList();
            CBoxRefresher();
        }

        private void CBoxRefresher()
        {
            cbCategoryPicker.Items.Clear();
            cbModifyCategoryPicker.Items.Clear();
            var categoryResult = db.Categories.Where(x => x.Status != Status.Passive).ToList();
            foreach (Category item in categoryResult)
            {
                cbCategoryPicker.Items.Add(item);
                cbModifyCategoryPicker.Items.Add(item);
            }
        }

        ProjectContext db = new ProjectContext(); // Get a Database instance

        int id; // The id which we use in modifying things
        bool isItemProduct = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbTypeChoose.Text=="Product")
            {
                Product product = new Product();
                product.ProductName = txtAddName.Text;
                product.CategoryId = ((Category)cbCategoryPicker.SelectedItem).Id;
                db.Products.Add(product);
                db.SaveChanges();
                Refresher(gbAdd);
                dataGridMain.DataSource = null;
                dataGridMain.DataSource = db.Products.Where(x => x.Status != Status.Passive).ToList();
            }
            else if (cbTypeChoose.Text=="Category")
            {
                Category category = new Category();
                category.CategoryName = txtAddName.Text;
                category.Description = txtAddDescription.Text;
                db.Categories.Add(category);
                db.SaveChanges();
                Refresher(gbAdd);
                CBoxRefresher();
                dataGridMain.DataSource = null;
                dataGridMain.DataSource = db.Categories.Where(x => x.Status != Status.Passive).ToList();
            }
        }

        private void Refresher(GroupBox groupbox) // TetxBox cleaner and Datagrid refresher
        {
            foreach (Control item in groupbox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = -1;
                }
            }
            
        }

        private void cbTypeChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeChoose.Text=="Product")
            {
                dataGridMain.DataSource = null;
                dataGridMain.DataSource = db.Products.Where(x => x.Status != Status.Passive).ToList();
                cbCategoryPicker.Show();
                txtAddDescription.Hide();
                lblAddType.Text = "Pick a Category";
            }
            else if (cbTypeChoose.Text == "Category")
            {
                dataGridMain.DataSource = null;
                dataGridMain.DataSource = db.Categories.Where(x => x.Status != Status.Passive).ToList();
                cbCategoryPicker.Hide();
                txtAddDescription.Show();
                lblAddType.Text = "Description";
            }
        }

        private void dataGridMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try // We made a dirty trick here :) to understand which table's element is selected
            {
                txtModifyName.Text = dataGridMain.CurrentRow.Cells["ProductName"].Value.ToString();
                id = Convert.ToInt32(dataGridMain.CurrentRow.Cells["id"].Value);
                Product product = db.Products.Where(x => x.Id == id).FirstOrDefault();
                txtModifyName.Text = product.ProductName;
                isItemProduct = true;
                lblModifyType.Text = "Pick a Category";
                txtModifyDescription.Text = "";
                txtModifyDescription.Hide();
                cbModifyCategoryPicker.Show();
            }
            catch (Exception)
            {
                id = Convert.ToInt32(dataGridMain.CurrentRow.Cells["id"].Value);
                Category category = db.Categories.Where(x => x.Id == id).FirstOrDefault();
                txtModifyName.Text = category.CategoryName;
                txtModifyDescription.Text = category.Description;
                isItemProduct = false;
                lblModifyType.Text = "Description :";
                txtModifyDescription.Show();
                cbModifyCategoryPicker.Hide();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isItemProduct)
            {
                Product product = db.Products.Where(x => x.Id == id).FirstOrDefault();
                product.ProductName = txtModifyName.Text;
                product.ModifiedTime = DateTime.Now;
                product.CategoryId = ((Category)cbModifyCategoryPicker.SelectedItem).Id;
                product.Status = Status.Modified;
                db.SaveChanges();
                Refresher(gbModifyDelete);
                CBoxRefresher();
                dataGridMain.DataSource = null;
                dataGridMain.DataSource = db.Products.Where(x => x.Status != Status.Passive).ToList();
            }
            if (!isItemProduct)
            {               
                Category category = db.Categories.Where(x=>x.Id==id).FirstOrDefault();
                category.CategoryName = txtModifyName.Text;
                category.Description = txtModifyDescription.Text;
                category.ModifiedTime = DateTime.Now;
                category.Status = Status.Modified;
                db.SaveChanges();
                Refresher(gbModifyDelete);
                CBoxRefresher();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isItemProduct)
            {
                Product product = db.Products.Where(x => x.Id == id).FirstOrDefault();
                product.DeletedDate = DateTime.Now;
                product.Status = Status.Passive;
                db.SaveChanges();
                dataGridMain.DataSource = null;
                dataGridMain.DataSource = db.Products.Where(x => x.Status != Status.Passive).ToList();
            }
            if (!isItemProduct)
            {
                Category category = db.Categories.Where(x => x.Id == id).FirstOrDefault();
                category.DeletedDate = DateTime.Now;
                category.Status = Status.Passive;
                db.SaveChanges();
                CBoxRefresher();
                dataGridMain.DataSource = null;
                dataGridMain.DataSource = db.Categories.Where(x => x.Status != Status.Passive).ToList();
            }
        }
    }
}
