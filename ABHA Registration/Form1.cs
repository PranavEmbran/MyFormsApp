namespace ABHA_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
