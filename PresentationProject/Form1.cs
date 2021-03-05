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

        private void custLnamebx_TextChanged(object sender, System.EventArgs e)
        {
            salesContext sctx = new salesContext();
            foreach (Customer c in sctx.Customers.Where(c => c.LastName.StartsWith(custLnamebx.Text)))
            {
                var allRows = sctx.Customers.OrderBy(a => a.LastName).Select(s => new { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
                grid.DataSource = allRows;
            }
        }
        private void LoadCTbl_Click(object sender, EventArgs e)
        {
            salesContext sctx = new salesContext();
            foreach (Customer c in sctx.Customers)
            {
                var allRows = sctx.Customers.OrderBy(a => a.LastName).Where(s => c.LastName.StartsWith(custLnamebx.Text) { s.FirstName, s.LastName, s.City, s.Country, s.Phone }).ToList();
                grid.DataSource = allRows;
            }
        }

        private void upDCust_Click(object sender, EventArgs e)
        {
            salesContext sctx = new salesContext();

        }

        private void DltCust_Click(object sender, EventArgs e)
        {

        }

        private void NewCust_Click(object sender, EventArgs e)
        {

        }

        private void LnameFilter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CFilter_CheckedChanged(object sender, EventArgs e)
        {

        }
    }



        //private bool CustNameIncludes(Customer customer)
        //{
        //    return customer.LastName.StartsWith(custLnamebx.Text) == true;
        //}
    
}
