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

        // Make a dictionary for highlighting query strings when mousehover on buttons.
        Dictionary<string, string> queryList = new Dictionary<string, string>
        {
            {"btnQuery1" , "1. Order Subtotals For each order, calculate a subtotal for each Order (identified by OrderID)." },
            {"btnQuery2" , "2. Sales by Year" },
            {"btnQuery3" , "3. Employees that 55+ ages old with their full names " },
            {"btnQuery4" , "4. Alphabetical List of Products" },
            {"btnQuery5" , "5. Current Product List (without discontinued products)" },
            {"btnQuery6" , "6. Order Details Extended. This query calculates sales price for each order after discount is applied." },
            {"btnQuery7" , "7. Sales by Category For each category." },
            {"btnQuery8" , "8. Ten Most Expensive Products" },
            {"btnQuery9" , "9. Products by Category" },
            {"btnQuery10" , "10. Customers and Suppliers by City" },
            {"btnQuery11" , "11. Products Above Average Price" },
            {"btnQuery12" , "12. Product Sales by Category for 1997" }

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

        private void btnQuery7_Click(object sender, EventArgs e)
        {
            // Query String "7. Sales by Category For each category"

            dgResults.DataSource = null;
            dgResults.DataSource = db.Order_Details.Join(db.Orders,
                ord => ord.OrderID,
                o => o.OrderID,
                (ord, o) => new { ord, o }).Join(db.Products,
                op =>op.ord.ProductID,
                p => p.ProductID,
                (op, p) => new {op,p}
                ).GroupBy(x =>x.p.Category.CategoryName).Select(x => new
                {
                    x.Key,
                    Total = x.Sum(y=> y.op.ord.Quantity*y.op.ord.UnitPrice*(int)(1-y.op.ord.Discount))
                }).ToList();  //That's disgusting.
        }

        private void btnQuery8_Click(object sender, EventArgs e)
        {
            // Query String "8. Ten Most Expensive Products"

            dgResults.DataSource = null;
            dgResults.DataSource = db.Products.OrderByDescending(x => x.UnitPrice).Take(10).ToList();
        }

        private void btnQuery9_Click(object sender, EventArgs e)
        {
            // Query String "9. Products by Category"

            dgResults.DataSource = null;
            dgResults.DataSource = db.Products.Select(x => new
            {
                x.Category.CategoryName,
                x.ProductName,
                x.QuantityPerUnit,
                x.UnitsInStock,
                x.Discontinued
            }).ToList();
        }

        private void btnQuery10_Click(object sender, EventArgs e)
        {
            // Query String "10. Customers and Suppliers by City"

            dgResults.DataSource = null;
            dgResults.DataSource = db.Customers.Select(x => new
            {
                x.City,
                x.CompanyName,
                x.ContactName
            }).Union(db.Suppliers.Select(x => new
            {
                x.City,
                x.CompanyName,
                x.ContactName
            })).OrderBy(x => x.CompanyName).ToList(); //That's weird maybe we will improve this one.
        }

        private void btnQuery11_Click(object sender, EventArgs e)
        {
            // Query String "11. Products Above Average Price"

            dgResults.DataSource = null;
            dgResults.DataSource = db.Products.Select(x => new
            {
                x.ProductName,
                x.UnitPrice,
                AvgPrice = db.Products.Average(t => t.UnitPrice),

            }).Where(z => z.AvgPrice < z.UnitPrice).ToList();
        }

        private void btnQuery12_Click(object sender, EventArgs e)
        {
            //Query String "12. Product Sales by Category for 1997"

            dgResults.DataSource = null;
            dgResults.DataSource = db.Order_Details.Join(db.Categories,
                o => o.Product.CategoryID,
                c => c.CategoryID,
                (o, c) => new { o, c }
                ).Where(x =>SqlFunctions.DatePart("Year", x.o.Order.ShippedDate)==1997).GroupBy(x => x.c.CategoryName).Select(x => new
                {
                    x.Key,
                    Sum = x.Sum(y => y.o.Quantity * y.o.UnitPrice * (int)(1 - y.o.Discount))
                }).ToList();
        }
    }
}
