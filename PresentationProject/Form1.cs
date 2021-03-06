using System.Data;
using System.Windows.Forms;
using DataProject;
using System.Linq;
using System;

namespace PresentationProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            salesContext sctx = new salesContext();
            var allRows = sctx.Customers.OrderBy(a => a.LastName).Select(s => new { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
            grid.DataSource = allRows;
        }

        //private void custLnamebx_TextChanged(object sender, System.EventArgs e)
        //{
        //    salesContext sctx = new salesContext();
        //    foreach (Customer c in sctx.Customers.Where(c => c.LastName.StartsWith(custLnamebx.Text)))
        //    {
        //        var allRows = sctx.Customers.OrderBy(a => a.LastName).Select(s => new { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
        //        grid.DataSource = allRows;
        //    }
        //}

        private void upDCust_Click(object sender, EventArgs e)
        {
            salesContext sctx = new salesContext();
            Customer updatecust = sctx.Customers.Single(c => c.LastName == custLnamebx.Text);
            updatecust.FirstName = custFnamebx.Text;
            updatecust.LastName = custLnamebx.Text;
            updatecust.City = cityBx.Text;
            updatecust.Country = countryBx.Text;
            updatecust.Phone = phoneBx.Text;
            //sctx.Customers.Update(updatecust);
            sctx.SaveChanges();
            var allRows = sctx.Customers.OrderBy(a => a.LastName).Select(s => new { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
            grid.DataSource = allRows;
        }

        private void DltCust_Click(object sender, EventArgs e)
        {
            salesContext sctx = new salesContext();
            //Customer oldcust = sctx.Customers.All(c => c.LastName == custLnamebx.Text);
            //int deleteId = oldcust.id;
            void button1_Click(object sender, EventArgs e)
            {
                var someRows = sctx.Customers.Where(s => s.LastName == custLnamebx.Text);
                //&& f.FirstName == userFirst && f.City == userCity && f.Country == userCountry &&
                //f.Phone == userPhone).Select(i => i.Id).FirstOrDefault();
                grid.DataSource = someRows;
            }
            //grid.SelectedRows.
            //make delete for multiple instances
            //sctx.Customers.Remove(oldcust);
            sctx.SaveChanges();
            var allRows = sctx.Customers.OrderBy(a => a.LastName).Select(s => new { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
            grid.DataSource = allRows;
        }

        private void NewCust_Click(object sender, EventArgs e)
        {
            salesContext sctx = new salesContext();
            Customer newcust = new Customer();
            int idnum = sctx.Customers.Count();
            newcust.Id = idnum + 1;
            newcust.FirstName = custFnamebx.Text;
            newcust.LastName = custLnamebx.Text;
            newcust.City = cityBx.Text;
            newcust.Country = countryBx.Text;
            newcust.Phone = phoneBx.Text;
            sctx.Customers.Add(newcust);
            sctx.SaveChanges();
            var allRows = sctx.Customers.OrderBy(a => a.LastName).Select(s => new { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
            grid.DataSource = allRows;
        }

        private void LnameFilter_CheckedChanged(object sender, EventArgs e)
        {
            salesContext sctx = new salesContext();
        }

        private void CFilter_CheckedChanged(object sender, EventArgs e)
        {
            salesContext sctx = new salesContext();
        }

        private void LoadCTbl_Click(object sender, EventArgs e)
        {
            salesContext sctx = new salesContext();
            sctx.Customers.Single(c => c.LastName == custLnamebx.Text);
            var oneRow = sctx.Customers.OrderBy(a => a.LastName).Select(s => new { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
            grid.DataSource = oneRow;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }



        //private bool CustNameIncludes(Customer customer)
        //{
        //    return customer.LastName.StartsWith(custLnamebx.Text) == true;
        //}
    
}
