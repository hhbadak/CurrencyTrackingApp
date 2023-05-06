using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CurrencyTrackingApp
{
    public partial class RateList : Form
    {
        public RateList()
        {
            InitializeComponent();
        }
        private void RateList_Load(object sender, EventArgs e)
        {
        }
        private void btn_getRate_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
                XElement root = xmlDoc.Root;
                string chosen = cb_list.SelectedItem.ToString();

                XElement selectedElement = root.Elements("Currency").FirstOrDefault(item => item.Element("Isim").Value == chosen);

                if (selectedElement != null)
                {
                    lbl_code.Text = selectedElement.Attribute("Kod").Value;
                    lbl_name.Text = selectedElement.Element("Isim").Value;
                    tb_buying.Text = selectedElement.Element("ForexBuying").Value + "₺";
                    tb_selling.Text = selectedElement.Element("ForexSelling").Value + "₺";
                }
                else
                {
                    MessageBox.Show("Seçilen öğe bulunamadı.");
                }
            }
            catch
            {
                MessageBox.Show("Hata oluştu. Veriler alınamadı.");
            }
        }
    }
}
