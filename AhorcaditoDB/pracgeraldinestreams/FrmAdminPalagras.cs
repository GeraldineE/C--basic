using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracGeraldineStreams
{
    public partial class FrmAdminPalagras : Form
    {
        public FrmAdminPalagras()
        {
            InitializeComponent();
        }

        private void palabrasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.palabrasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBAhorcaditoDataSetPalabras);

        }

        private void FrmAdminPalagras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBAhorcaditoDataSetPalabras.Palabras' Puede moverla o quitarla según sea necesario.
            this.palabrasTableAdapter.Fill(this.dBAhorcaditoDataSetPalabras.Palabras);

        }
    }
}
