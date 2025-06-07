using System.Windows.Forms;

namespace ABHA_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //mobOTP.Appearance = TabAppearance.FlatButtons;
            //mobOTP.ItemSize = new Size(0, 1);
            //mobOTP.SizeMode = TabSizeMode.Fixed;

            //mobOTP.Visible = false;

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    tabControl1.Appearance = TabAppearance.FlatButtons;
        //    tabControl1.ItemSize = new Size(0, 1);
        //    tabControl1.SizeMode = TabSizeMode.Fixed;
        //}

        private void mobTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mobTxtBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                tenLbl.Text = "✅";
                tenLbl.ForeColor = System.Drawing.Color.Green;
                return;
            }
        }

        private OtpUserControl otpControl;
        private void genOtpBtn_Click(object sender, EventArgs e)
        {
            usingMobPanel.Visible = false;

            otpControl = new OtpUserControl();
            otpControl.Size = usingMobPanel.Size;
            otpControl.Location = usingMobPanel.Location;

            //this.Controls.Add(otpControl);
            usingMobPanel.Controls.Add(otpControl);
            otpControl.BringToFront();
        }
    }
}
