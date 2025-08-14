using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENTE
{
    public partial class FormConsultarMisPedidos : Form
    {
        private readonly int _clienteId;
        private readonly string _clienteNombre;

        public FormConsultarMisPedidos()
        {
            InitializeComponent();
            Text = "Consultar mis pedidos";
        }

        public FormConsultarMisPedidos(int clienteId, string clienteNombre) : this()
        {
            _clienteId = clienteId;
            _clienteNombre = clienteNombre;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Aquí consultarás los pedidos del cliente al servidor (Fase 5.3)
        }
    }
}