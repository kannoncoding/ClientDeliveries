using Entregas.Cliente;
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
    public partial class FormPrincipal : Form
    {
        // Estado (se reemplaza con validación TCP en Fase 5.2)
        private bool _autenticado = false;
        private int _clienteId = 0;
        private string _clienteNombre = string.Empty;

        // Config servidor (solo UI de estado)
        private const string HOST = "127.0.0.1";
        private const int PORT = 14100;

        // Referencias (se asignan por Name si existen)
        private MenuStrip _menu;
        private ToolStripMenuItem _mniConectar, _mniDesconectar, _mniRegistrar, _mniConsultar, _mniSalir;
        private StatusStrip _status;
        private ToolStripStatusLabel _lblEstado, _lblServidor;
        private Panel _pnlLogin, _pnlPrincipal;
        private TextBox _txtClienteId;
        private Button _btnIngresar;
        private Label _lblClienteNombre;

        public FormPrincipal()
        {
            InitializeComponent();
            BindControlsByName();   // intenta resolver por Name
            InicializarUi();
            WireEvents();
            CambiarAEstadoDesconectado();
        }

        // -------- Helpers para resolver controles por Name --------

        private T FindControl<T>(string name) where T : Control
            => this.Controls.Find(name, true).FirstOrDefault() as T;

        private ToolStripMenuItem FindMenuItem(MenuStrip menu, string name)
        {
            if (menu == null) return null;
            foreach (ToolStripMenuItem root in menu.Items.OfType<ToolStripMenuItem>())
            {
                var found = FindMenuItemRecursive(root, name);
                if (found != null) return found;
            }
            return null;
        }

        private ToolStripMenuItem FindMenuItemRecursive(ToolStripMenuItem item, string name)
        {
            if (item == null) return null;
            if (item.Name == name) return item;
            foreach (ToolStripMenuItem child in item.DropDownItems.OfType<ToolStripMenuItem>())
            {
                var found = FindMenuItemRecursive(child, name);
                if (found != null) return found;
            }
            return null;
        }

        private void BindControlsByName()
        {
            // Menu / Status
            _menu = this.Controls.OfType<MenuStrip>().FirstOrDefault();                 // toma el primero
            _status = this.Controls.OfType<StatusStrip>().FirstOrDefault();

            // Menús por Name (asegúrate de poner estos Name en el diseñador)
            _mniConectar = FindMenuItem(_menu, "mniConectar");
            _mniDesconectar = FindMenuItem(_menu, "mniDesconectar");
            _mniRegistrar = FindMenuItem(_menu, "mniRegistrarPedido");
            _mniConsultar = FindMenuItem(_menu, "mniConsultarPedidos");
            _mniSalir = FindMenuItem(_menu, "mniSalir");

            // Status labels
            if (_status != null)
            {
                var labels = _status.Items.OfType<ToolStripStatusLabel>().ToArray();
                _lblEstado = labels.FirstOrDefault(l => l.Name == "lblEstado") ?? labels.FirstOrDefault();
                _lblServidor = labels.FirstOrDefault(l => l.Name == "lblServidor");
            }

            // Paneles y campos
            _pnlLogin = FindControl<Panel>("pnlLogin");
            _pnlPrincipal = FindControl<Panel>("pnlPrincipal");
            _txtClienteId = FindControl<TextBox>("txtClienteId");
            _btnIngresar = FindControl<Button>("btnIngresar");
            _lblClienteNombre = FindControl<Label>("lblClienteNombre");

            // Aceptar con Enter
            if (_btnIngresar != null) this.AcceptButton = _btnIngresar;
        }

        private void InicializarUi()
        {
            this.Text = "ENTREGAS - Cliente";
            if (_lblServidor != null) _lblServidor.Text = $"Servidor: {HOST}:{PORT}";
        }

        private void WireEvents()
        {
            if (_mniConectar != null) _mniConectar.Click += mniConectar_Click;
            if (_mniDesconectar != null) _mniDesconectar.Click += mniDesconectar_Click;
            if (_mniRegistrar != null) _mniRegistrar.Click += mniRegistrarPedido_Click;
            if (_mniConsultar != null) _mniConsultar.Click += mniConsultarPedidos_Click;
            if (_mniSalir != null) _mniSalir.Click += (s, e) => this.Close();

            if (_btnIngresar != null) _btnIngresar.Click += btnIngresar_Click;
        }

        // -------- Estados de UI --------
        private void CambiarAEstadoDesconectado()
        {
            _autenticado = false;
            _clienteId = 0;
            _clienteNombre = string.Empty;

            if (_mniConectar != null) _mniConectar.Enabled = true;
            if (_mniDesconectar != null) _mniDesconectar.Enabled = false;
            if (_mniRegistrar != null) _mniRegistrar.Enabled = false;
            if (_mniConsultar != null) _mniConsultar.Enabled = false;

            if (_pnlLogin != null) _pnlLogin.Visible = true;
            if (_pnlPrincipal != null) _pnlPrincipal.Visible = false;

            if (_txtClienteId != null) { _txtClienteId.Clear(); _txtClienteId.Focus(); }
            if (_lblClienteNombre != null) _lblClienteNombre.Text = "(no validado)";
            if (_lblEstado != null) _lblEstado.Text = "Desconectado";
        }

        private void CambiarAEstadoConectadoNoValidado()
        {
            if (_mniConectar != null) _mniConectar.Enabled = false;
            if (_mniDesconectar != null) _mniDesconectar.Enabled = true;
            if (_mniRegistrar != null) _mniRegistrar.Enabled = false;
            if (_mniConsultar != null) _mniConsultar.Enabled = false;

            if (_pnlLogin != null) _pnlLogin.Visible = true;
            if (_pnlPrincipal != null) _pnlPrincipal.Visible = false;

            if (_lblEstado != null) _lblEstado.Text = "Conectado • pendiente de validar cliente";
            if (_txtClienteId != null) _txtClienteId.Focus();
        }

        private void CambiarAEstadoAutenticado()
        {
            _autenticado = true;

            if (_mniConectar != null) _mniConectar.Enabled = false;
            if (_mniDesconectar != null) _mniDesconectar.Enabled = true;
            if (_mniRegistrar != null) _mniRegistrar.Enabled = true;
            if (_mniConsultar != null) _mniConsultar.Enabled = true;

            if (_pnlLogin != null) _pnlLogin.Visible = false;
            if (_pnlPrincipal != null) _pnlPrincipal.Visible = true;

            if (_lblEstado != null) _lblEstado.Text = "Conectado • cliente validado";
            if (_lblClienteNombre != null) _lblClienteNombre.Text = _clienteNombre;
        }

        // -------- Eventos --------
        private void mniConectar_Click(object sender, EventArgs e)
        {
            // En Fase 5.2: conectar socket TCP
            CambiarAEstadoConectadoNoValidado();
        }

        private void mniDesconectar_Click(object sender, EventArgs e)
        {
            // En Fase 5.2: cerrar socket TCP
            CambiarAEstadoDesconectado();
        }

        private void mniRegistrarPedido_Click(object sender, EventArgs e)
        {
            using (var frm = new FormRegistrarPedido(_clienteId, _clienteNombre))
                frm.ShowDialog(this);
        }

        private void mniConsultarPedidos_Click(object sender, EventArgs e)
        {
            using (var frm = new FormConsultarMisPedidos(_clienteId, _clienteNombre))
                frm.ShowDialog(this);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (_txtClienteId == null) return;

            if (!int.TryParse(_txtClienteId.Text.Trim(), out var id) || id <= 0)
            {
                MessageBox.Show("Ingrese una identificación válida (número entero positivo).",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtClienteId.Focus();
                _txtClienteId.SelectAll();
                return;
            }

            _clienteId = id;
            _clienteNombre = $"Cliente #{_clienteId} (pendiente validación)"; // En 5.2 vendrá del servidor
            CambiarAEstadoAutenticado();
        }
    }
}