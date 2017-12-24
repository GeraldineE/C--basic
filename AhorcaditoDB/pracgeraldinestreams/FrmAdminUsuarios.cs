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
    public partial class FrmAdminUsuarios : Form
    {
        public FrmAdminUsuarios()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBAhorcaditoDataSetUsuarios);

        }

        private void FrmAdminUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBAhorcaditoDataSetUsuarios.Usuarios' 
            this.usuariosTableAdapter.Fill(this.dBAhorcaditoDataSetUsuarios.Usuarios);

        }
    }
}
