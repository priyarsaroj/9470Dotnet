using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (TECHNETEntities db = new TECHNETEntities())
            {
                var art = db.Articoli
                            .Join(db.Famiglie,
                                  articolo => articolo.CodFamiglia,
                                  famiglia => famiglia.CodFamiglia,
                                  (articolo, famiglia) => new { Articoli = articolo, Famiglie = famiglia })
                            .Where((x) => x.Articoli.CodArt == "ART005")
                            .FirstOrDefault();

                MessageBox.Show(art.Articoli.DesArt + " - " + art.Famiglie.DesFamiglia);
            }
        }
    }
}
