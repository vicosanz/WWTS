using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICA3.Formas;
using Infoware.Consola.Base;

namespace ICA3.Toolboxes
{
    public partial class ToolBoxSistemas : FormBaseToolbox
    {
        private bool mCargarArgumentos = true;
        private string configFile = "";

        private SistemaList Sistemas { get; set; } = null;

        public Sistema SistemaSeleccionado
        {
            get
            {
                return (Sistema)treeView1.SelectedNode?.Tag;
            }
        }

        public string DirectorioConfig { get; internal set; }

        public ToolBoxSistemas()
        {
            InitializeComponent();
        }

        private void agregarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crearsistema();
        }

        private void Crearsistema( string _ensamblado = "")
        {
            FrmSistemas f = new FrmSistemas
            {
                Sistema = new Sistema(),
                Ensamblado = _ensamblado
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                Sistemas.Add(f.Sistema);

                SistemaList.SerializeList(Sistemas, configFile);

                TreeNode _node = new TreeNode()
                {
                    Text = f.Sistema.NombrePublico,
                    Tag = f.Sistema,
                    ImageIndex = 1,
                    SelectedImageIndex = 1,
                };
                treeView1.Nodes.Add(_node);
            }
        }

        private void ToolBoxSistemas_Load(object sender, EventArgs e)
        {
            configFile = Path.Combine(DirectorioConfig, "Sistemas.config");
            try
            {
                Sistemas = SistemaList.DeSerializeList(configFile);

                if (mCargarArgumentos && Environment.GetCommandLineArgs().Count() >1)
                {
                    int index = 1;
                    while(index < Environment.GetCommandLineArgs().Count())
                    {
                        string _arg = Environment.GetCommandLineArgs()[index];
                        bool _existearg = false;
                        foreach(Sistema _sistema in Sistemas)
                        {
                            if (_arg.ToUpper() == _sistema.Ensamblado.ToUpper())
                            {
                                _existearg = true;
                                int _existen2 = 0;
                                foreach(Sistema _sistema2 in Sistemas)
                                {
                                    if (_arg.ToUpper() == _sistema2.Ensamblado.ToUpper())
                                    {
                                        _existen2++;
                                    }
                                }

                                if (_existen2 == 1)
                                {
                                    _sistema.CargarAhora = true;
                                }
                            }
                            else if (Path.GetFileName(_arg).ToUpper() == Path.GetFileName(_sistema.Ensamblado).ToUpper())
                            {
                                if (MessageBox.Show($"Existe una nueva versión del programa {Path.GetFileName(_arg)}, ¿Desea que se actualice automáticamente los parámetros para acceder a este sistema?", 
                                    "Pregunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    _existearg = true;
                                    foreach (Sistema _sistema2 in Sistemas)
                                    {
                                        if (Path.GetFileName(_arg).ToUpper() == Path.GetFileName(_sistema2.Ensamblado).ToUpper())
                                        {
                                            _sistema2.Ensamblado = _arg;
                                        }
                                    }
                                }
                            }
                        }

                        if (!_existearg)
                        {
                            Crearsistema(_arg);
                        }
                        index++;
                    }

                    mCargarArgumentos = false;
                    treeView1.Nodes.Clear();
                    SistemaList.SerializeList(Sistemas, configFile);
                }

                foreach(Sistema _sistema in Sistemas)
                {
                    TreeNode _node = new TreeNode
                    {
                        Text = _sistema.NombrePublico,
                        Tag = _sistema,
                        ImageIndex = 1,
                        SelectedImageIndex = 1,
                    };
                    treeView1.Nodes.Add(_node);

                    if (_sistema.CargaralIniciar || _sistema.CargarAhora)
                    {
                        treeView1.SelectedNode = _node;
                        EjecutarSistema();
                    }
                }
            }
            catch (Exception)
            {
                Sistemas = new SistemaList();
            }
        }

        public Sistema SistemaActual
        {
            get => (Sistema) treeView1.SelectedNode?.Tag;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SistemaActual is null)
            {
                return;
            }
            Sistemas.Remove(SistemaActual);
            treeView1.SelectedNode.Remove();
            SistemaList.SerializeList(Sistemas, configFile);
        }

        private void modificarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SistemaActual is null)
            {
                return;
            }
            FrmSistemas f = new FrmSistemas()
            {
                Sistema = SistemaActual
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Text = f.Sistema.NombrePublico;
                SistemaList.SerializeList(Sistemas, configFile);
            }
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            EjecutarSistema();
        }

        public event EventHandler AbrirSitema;
        private void EjecutarSistema()
        {
            if (treeView1.SelectedNode is null)
            {
                return;
            }
            if (!SistemaActual.Probarconexion())
            {
                if (!modificarLogin() || !SistemaActual.Probarconexion())
                {
                    treeView1.SelectedNode.ImageIndex = 1;
                    treeView1.SelectedNode.SelectedImageIndex = 1;

                    MessageBox.Show("No se puede iniciar sesión en este sistema", "Error");
                    return;
                }
            }
            treeView1.SelectedNode.ImageIndex = 0;
            treeView1.SelectedNode.SelectedImageIndex = 0;

            AbrirSitema?.Invoke(this, null);
        }

        private bool modificarLogin()
        {
            if (SistemaActual is null)
            {
                return false;
            }
            FrmSistemasLogin f = new FrmSistemasLogin()
            {
                Sistema = SistemaActual
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Text = f.Sistema.NombrePublico;
                SistemaList.SerializeList(Sistemas, configFile);
                return true;
            }
            return false;
        }

        public void CerrarSistema(Sistema _sistema)
        {
            foreach(TreeNode _nodo in treeView1.Nodes)
            {
                if (_nodo.Tag == _sistema)
                {
                    if (!_sistema.GuardarContrasena)
                    {
                        _sistema.ContrasenaString = "";
                    }
                    _nodo.ImageIndex = 1;
                    _nodo.SelectedImageIndex = 1;
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            desconectarToolStripMenuItem.Enabled = treeView1.SelectedNode?.ImageIndex == 0;
            modificarSistemaToolStripMenuItem.Enabled = SistemaActual != null;
            eliminarToolStripMenuItem.Enabled = SistemaActual != null;
        }

        public event EventHandler<Sistema> DesconectarSistema;

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SistemaActual is null)
            {
                return;
            }
            DesconectarSistema?.Invoke(this, SistemaActual);
        }
    }
}
