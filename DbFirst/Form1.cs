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
            {"btnQuery3" , "3. Employees that 55+ ages old with their full names " }

        };
        NorthwindEntities db;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Created an instance of our database when we load our form.
            db = new NorthwindEntities(); 
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
    }
}
