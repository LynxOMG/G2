using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Assignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            
            Employee form = new Employee();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            pnLibraSys.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            DashbordForm form = new DashbordForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            pnLibraSys.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            DashbordForm form = new DashbordForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            pnLibraSys.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            VendorForm form = new VendorForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            pnLibraSys.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            pnLibraSys.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }
    }
}
