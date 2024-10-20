using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registeration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Registration";

            Register.Click += Register_Click;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            ResetWarn();

            string name = NameBox.Text;
            bool T = true;
            if(name == null || name.Length < 5)
            {
                this.NameWorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                NameWorn.ForeColor = Color.Red;
                NameWorn.Text = "Name Must Contain At Least 5 Character";
                T = false;
            }

            string email = EmailBox.Text;
            if(!email.Contains("@"))
            {
                this.EmailWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.EmailWarn.ForeColor = Color.Red;
                this.EmailWarn.Text = "Email Must Contain @";
                T = false; 
            }

            if(!FootBall.Checked && !Tennis.Checked && !Swimming.Checked)
            {
                this.HappiesWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.HappiesWarn.ForeColor = Color.Red;
                this.HappiesWarn.Text = "Chooce At Least One Hoppy";
                T = false;
            }

            if (T)
            {
                this.SuccessfulRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.SuccessfulRegister.ForeColor = Color.Green;
                this.SuccessfulRegister.Text = "Thank You,  Your Registeration Is Valid";
            }

        }
        private void ResetWarn()
        {
            this.NameWorn.Text = null;
            this.EmailWarn.Text = null;
            this.HappiesWarn.Text = null;
            this.SuccessfulRegister.Text = null;
        }
    }
}
