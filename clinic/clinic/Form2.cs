using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic
{
    public partial class Form2 : Form
    {
        public string account;
        public Form2()
        {
            InitializeComponent();
        }
        public void roles()
        {
            if (account == "Dentist")
            {
                PatientRecordbutton.Enabled = false;
                PatientCardbutton.Enabled = false;
                Appointmentbutton.Enabled = false;
                Dentistbutton.Enabled = false;
                TreatmentProceduresbutton.Enabled = false;
            }
            else if(account == "Director")
            {
                PatientRecordbutton.Enabled = false;
                PatientCardbutton.Enabled = false;
                Appointmentbutton.Enabled = false;
                Dentistbutton.Enabled = false;
                TreatmentProceduresbutton.Enabled = false;
            }
            else
            {
                PatientRecordbutton.Enabled = true;
                PatientCardbutton.Enabled = true;
                Appointmentbutton.Enabled = true;
                Dentistbutton.Enabled = true;
                TreatmentProceduresbutton.Enabled = true;
            }
        }


        private void ExitLogbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 LogForm = new Form1();
            LogForm.Show();
        }

        private void PatientRecordbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 PatientRecord = new Form3();
            PatientRecord.Show();
        }

        private void PatientCardbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 PatientCard = new Form4();
            PatientCard.Show();
        }

        private void Appointmentbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 Appointment = new Form5();
            Appointment.Show();
        }

        private void Dentistbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 Dentist = new Form6();
            Dentist.Show();
        }

        private void TreatmentProceduresbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 TreatmentProcedures = new Form7();
            TreatmentProcedures.Show();
        }
    }
}
