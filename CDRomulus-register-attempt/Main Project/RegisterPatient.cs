using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main_Project
{
    public partial class RegisterPatient : Form
    {

        public RegisterPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string query = "INSERT INTO PatientData (patientName,address,postCode,city,dob,phoneNumber) VALUES('" + this.txtName.Text + "','" + this.txtAddress.Text + "','" + this.txtPostCode.Text + "','" + this.txtCity.Text + "','" + this.txtDOB.Text + "','" + this.textPhoneNumber.Text + "')";
            DBConnection.getDBConnectionInstance().getDataSet(query);


            MessageBox.Show("Data Inserted Successfully.");




            this.Close();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
