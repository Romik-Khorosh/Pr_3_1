using Pr_3_1.Models;

namespace Pr_3_1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            using (Pr2Context db = new Pr2Context())
            {
                foreach (TypesOfPartner type in db.TypesOfPartners.ToList())
                {
                    label3.Text += $"\n{type.Id}. {type.TypeOfPartner}\n";
                }
                foreach (TypesProduct type in db.TypesProducts.ToList())
                {
                    label4.Text += $"\n{type.Id}. {type.TypeProduct}\n";
                }
            }
        }
    }
}
