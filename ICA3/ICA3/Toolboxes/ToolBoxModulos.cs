using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infoware.Consola.Base;
using WeifenLuo.WinFormsUI.Docking;

namespace ICA3.Toolboxes
{
    public partial class ToolBoxModulos : FormBaseToolbox
    {
        public ToolBoxModulos()
        {
            InitializeComponent();
        }

        public Sistema SistemaActual
        {
            get
            {
                if (treeView1.SelectedNode is null)
                {
                    return null;
                }
                TreeNode _nodo = treeView1.SelectedNode;
                while (_nodo.Parent != null)
                {
                    _nodo = _nodo.Parent;
                }
                return (Sistema)_nodo.Tag;
            }
        }

        public SistemaList mSistemas { get; private set; } = new SistemaList();

        public void AgregarSistema(Sistema _Sistema)
        {
            bool _existe = false;
            foreach(TreeNode _nodo in treeView1.Nodes)
            {
                if (_nodo.Tag == _Sistema)
                {
                    treeView1.SelectedNode = _nodo;
                    _existe = true;
                    break;
                }
            }

            if (!_existe)
            {
                TreeNode _node = new TreeNode()
                {
                    Text = _Sistema.NombrePublico,
                    Tag = _Sistema,
                    ImageIndex = 1,
                    SelectedImageIndex = 1
                };
                treeView1.Nodes.Add(_node);
                treeView1.SelectedNode = _node;
                mSistemas.Add(_Sistema);
                if (!_Sistema.Probarconexion())
                {
                    MessageBox.Show(_Sistema.MensajeError, "Error");
                    return;
                }
                _node.ImageIndex = 0;
                _node.SelectedImageIndex = 0;
                TreeNode _primeraopcion = null;
                _Sistema.SistemaObjeto.ActualizacionesMensaje += SistemaObjeto_ActualizacionesMensaje;
                _Sistema.SistemaObjeto.ComprobarActualizaciones().ConfigureAwait(false);
                List<GrupoOpcion> _grupoopciones = _Sistema.SistemaObjeto.CargarListaGrupoOpciones(_Sistema);
                foreach(GrupoOpcion _grupoopcion in _grupoopciones)
                {
                    TreeNode _nodogrupo = new TreeNode()
                    {
                        Text = _grupoopcion.GrupoOpciones.Pardet_Descripcion
                    };
                    try
                    {
                        if (_grupoopcion.GrupoOpciones.get_Pardet_Imagen() is null)
                        {
                            ImageList1.Images.Add(ImageList1.Images.Count.ToString(), Properties.Resources.empty);
                        }
                        else
                        {
                            ImageList1.Images.Add(ImageList1.Images.Count.ToString(), _grupoopcion.GrupoOpciones.get_Pardet_Imagen());
                        }
                    }
                    catch (Exception)
                    {
                        ImageList1.Images.Add(ImageList1.Images.Count.ToString(), Properties.Resources.empty);
                    }
                    _nodogrupo.Tag = _grupoopcion;
                    _nodogrupo.ImageIndex = ImageList1.Images.Count - 1;
                    _nodogrupo.SelectedImageIndex = ImageList1.Images.Count - 1;

                    foreach (Opcion _opcion in _grupoopcion.Opciones)
                    {
                        TreeNode _nodoopcion = new TreeNode();
                        if (!string.IsNullOrWhiteSpace(_opcion.DescripcionAlternativa))
                        {
                            _nodoopcion.Text = _opcion.DescripcionAlternativa;
                        }
                        else
                        {
                            _nodoopcion.Text = _opcion.Restriccion.PardetOpcionString;
                        }
                        if (_opcion.Restriccion.PardetOpcion.get_Pardet_Imagen() is null)
                        {
                            ImageList1.Images.Add(ImageList1.Images.Count.ToString(), Properties.Resources.empty);
                        }
                        else
                        {
                            try
                            {
                                ImageList1.Images.Add(ImageList1.Images.Count.ToString(), _opcion.Restriccion.PardetOpcion.get_Pardet_Imagen());
                            }
                            catch (Exception)
                            {
                                ImageList1.Images.Add(ImageList1.Images.Count.ToString(), Properties.Resources.empty);
                            }
                        }
                        _nodoopcion.Tag = _opcion;
                        _nodoopcion.ImageIndex = ImageList1.Images.Count - 1;
                        _nodoopcion.SelectedImageIndex = ImageList1.Images.Count - 1;

                        if (_primeraopcion is null)
                        {
                            _primeraopcion = _nodoopcion;
                        }
                        _nodogrupo.Nodes.Add(_nodoopcion);
                    }

                    if (_nodogrupo.Nodes.Count > 0)
                    {
                        _node.Nodes.Add(_nodogrupo);
                        _node.ExpandAll();
                    }
                }

                if (_Sistema.CargaralIniciar)
                {
                    treeView1.SelectedNode = _primeraopcion;
                    EjecutarOpcion();
                }

                _Sistema.OperadorDatos.OperadorDatosError += CapturarError;
            }
        }

        private void SistemaObjeto_ActualizacionesMensaje(object sender, string e)
        {
            MensajeError?.Invoke(this, e);
        }

        private void EjecutarOpcion()
        {
            if (!(treeView1.SelectedNode.Tag is Opcion))
            {
                return;
            }
            Opcion _opcion = (Opcion)treeView1.SelectedNode.Tag;
            bool _existe = false;

            if (DockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form forma in MdiChildren)
                {
                    if (forma.Tag != null && forma.Tag is Opcion)
                    {
                        if (forma.Tag == _opcion)
                        {
                            _existe = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int index = DockPanel.Contents.Count -1; index >=0; index--)
                {
                    if (DockPanel.Contents[index] is IDockContent)
                    {
                        if (((Form) DockPanel.Contents[index]).Tag == _opcion)
                        {
                            _existe = true;
                            DockPanel.Contents[index].DockHandler.Show();
                        }
                    }
                }
            }

            if (!_existe || _opcion.Restriccion.PardetOpcion.Pardet_DatoInt1 == 1)
            {
                DockContent f = (DockContent)_opcion.CargarOpcion((Sistema)treeView1.SelectedNode.Parent.Parent.Tag, _opcion.Restriccion);
                if (f != null)
                {
                    f.Tag = _opcion;
                    f.HideOnClose = false;
                    f.Show(DockPanel, DockState.Document);
                    //If f.FullScreen Then
                    //  RaiseEvent FullScreenOpcion(Me, Nothing)
                    //End If
                }
            }
        }

        public event EventHandler DesconectarSistema;

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesconectarSistema?.Invoke(this, null);
        }

        public void CerrarSistema(Sistema _Sistema)
        {
            DockPanel.SuspendLayout();
            foreach(TreeNode _nodo in treeView1.Nodes)
            {
                if (_nodo.Tag == _Sistema)
                {
                    foreach (TreeNode _nodogrp in _nodo.Nodes)
                    {
                        foreach(TreeNode _nodoopc in _nodogrp.Nodes)
                        {
                            for (int t = DockPanel.Contents.Count -1; t>=0; t--)
                            {
                                DockContent dockContent = ((DockContent)DockPanel.Contents[t]);
                                if (dockContent.Tag == _nodoopc.Tag)
                                {
                                    dockContent.DockHandler.Close();
                                }
                            }
                        }
                    }
                    _Sistema.OperadorDatos.OperadorDatosError -= CapturarError;
                    treeView1.Nodes.Remove(_nodo);
                }
            }
            DockPanel.ResumeLayout(true, true);
        }

        public event EventHandler<string> MensajeError;
        private void CapturarError(object sender, Infoware.Datos.OperadorDatosErrorEventArgs e)
        {
            MensajeError?.Invoke(this, e.Message);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            EjecutarOpcion();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            EjecutarOpcion();
        }

        public event EventHandler CambioFavoritos;

        private void agregarAFavoritosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MarcarFavorito(true);
        }

        private void MarcarFavorito(bool favorito)
        {
            if (treeView1.SelectedNode is null)
            {
                return;
            }
            if (treeView1.SelectedNode.Tag is Opcion)
            {
                Opcion _opcion = (Opcion)treeView1.SelectedNode.Tag;

                _opcion.Restriccion.Restri_Favorito = favorito;
                _opcion.Restriccion.Guardar();
                CambioFavoritos?.Invoke(this, null);
            }
        }

        private void quitarDeFavoritosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MarcarFavorito(false);
        }
    }
}
