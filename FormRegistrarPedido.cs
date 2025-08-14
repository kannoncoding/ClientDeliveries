using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Universidad Estatal a Distancia (UNED)
// II Cuatrimestre 2025
// Programación Avanzada con C# - Proyecto 2
// Jorge Luis Arias Melendez
// Descripción del archivo: Form para registrar pedidos del cliente autenticado.
// La carga de artículos y el envío al servidor se implementan en la Fase 5.3.


namespace CLIENTE
{
    public partial class FormRegistrarPedido : Form
    {
        private readonly int _clienteId;
        private readonly string _clienteNombre;

        public FormRegistrarPedido()
        {
            InitializeComponent();
            Text = "Registrar pedido";
        }

        public FormRegistrarPedido(int clienteId, string clienteNombre) : this()
        {
            _clienteId = clienteId;
            _clienteNombre = clienteNombre;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Aquí cargarás artículos del servidor (Fase 5.3)
        }
    }
}

