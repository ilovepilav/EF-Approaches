using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> queryList = new Dictionary<string, string>
        {
            {"btnQuery1" , "1. Order Subtotals For each order, calculate a subtotal for each Order (identified by OrderID)." },
            {"btnQuery2" , "2. Sales by Year" },
            {"btnQuery3" , "3. Employees that 55+ ages old with their full names " },
            {"btnQuery4" , "4. Alphabetical List of Products" },
            {"btnQuery5" , "5. Current Product List (without discontinued products)" },
            {"btnQuery6" , "6. Order Details Extended. This query calculates sales price for each order after discount is applied." }

        };
        NorthwindEntities db;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Created an instance of our database when we load our form.
            db = new NorthwindEntities();

            foreach (Control item in gbQueries.Controls)
            {
                if (item is Button)
                {
                    item.MouseHover += Button_MouseHover;
                }
            }
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Labelise(btn);
        }

        public void Labelise(Button btn)
        {
            lblQueryDetail.Text = "";
            lblQueryDetail.Text = queryList[btn.Name];
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            // Query string "1. Order Subtotals For each order, calculate a subtotal for each Order (identified by OrderID)."

            dgResults.DataSource = null; // To prevent data collapses
            dgResults.DataSource = db.Order_Details.GroupBy(x => x.OrderID).Select(x => new
            {                
                x.Key,
                Subtotal = x.Sum(z=>((z.UnitPrice) * (z.Quantity) * (int)(1 - z.Discount)))
            }).ToList();

        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            //Query String "2. Sales by Year"
            dgResults.DataSource = null;
            // Some orders dont have shipping date value so we need to implement a nullable object to Datetime.Year which returns int value.
            dgResults.DataSource = db.Order_Details.GroupBy(x => (int?)x.Order.ShippedDate.Value.Year??0).Select(x => new
            {
                Year = x.Key,
                Subtotal = x.Sum(z => ((z.UnitPrice) * (z.Quantity) * (int)(1 - z.Discount)))
            }).ToList();
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            //Query String "3. Employees that 55+ ages old with their full names "
            
            dgResults.DataSource = null;
            dgResults.DataSource = db.Employees.Where(x => SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now)>=55).Select(x=> new 
            { 
                Name = x.TitleOfCourtesy+x.FirstName+" "+x.LastName,
                Age = SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now),
                BirthDate = SqlFunctions.DatePart("Year", x.BirthDate)                
            }).ToList();

        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            // Query String "4. Alphabetical List of Products"

            dgResults.DataSource = null;
            dgResults.DataSource = db.Products.Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.Category.CategoryName
            }).OrderBy(x => x.ProductName).ToList();
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            // Query String "5. Current Product List (without discontinued products)"

            dgResults.DataSource = null;
            dgResults.DataSource = db.Products.Where(x => x.Discontinued == false).ToList();
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            // Query String "6. Order Details Extended. This query calculates sales price for each order after discount is applied."

            dgResults.DataSource = null;
            dgResults.DataSource = db.Order_Details.Select(x => new
            {
                x.OrderID,
                x.ProductID,
                x.Product.ProductName,
                x.UnitPrice,
                x.Quantity,
                x.Discount,
                ExtendedPrice = x.UnitPrice*x.Quantity*(int)(1-x.Discount) 
            }).ToList();
        }
    }
}
