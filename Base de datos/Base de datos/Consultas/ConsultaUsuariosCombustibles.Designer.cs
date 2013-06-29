namespace Base_de_datos.Consultas
{
    partial class ConsultaUsuariosCombustibles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaUsuariosCombustibles));
            this.sCUTDataSet = new Base_de_datos.SCUTDataSet();
            this.usuariosMontoCombustibleVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosMontoCombustibleVehiculosTableAdapter = new Base_de_datos.SCUTDataSetTableAdapters.UsuariosMontoCombustibleVehiculosTableAdapter();
            this.tableAdapterManager = new Base_de_datos.SCUTDataSetTableAdapters.TableAdapterManager();
            this.usuariosMontoCombustibleVehiculosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.usuariosMontoCombustibleVehiculosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fechaInicialToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fechaInicialToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fechaFinalToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fechaFinalToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.usuariosMontoCombustibleVehiculosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sCUTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosMontoCombustibleVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosMontoCombustibleVehiculosBindingNavigator)).BeginInit();
            this.usuariosMontoCombustibleVehiculosBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosMontoCombustibleVehiculosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sCUTDataSet
            // 
            this.sCUTDataSet.DataSetName = "SCUTDataSet";
            this.sCUTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosMontoCombustibleVehiculosBindingSource
            // 
            this.usuariosMontoCombustibleVehiculosBindingSource.DataMember = "UsuariosMontoCombustibleVehiculos";
            this.usuariosMontoCombustibleVehiculosBindingSource.DataSource = this.sCUTDataSet;
            // 
            // usuariosMontoCombustibleVehiculosTableAdapter
            // 
            this.usuariosMontoCombustibleVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agenc_garantTableAdapter = null;
            this.tableAdapterManager.agenciaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Centro_CostoTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.garantiaTableAdapter = null;
            this.tableAdapterManager.gasto_combustibleTableAdapter = null;
            this.tableAdapterManager.horas_extraTableAdapter = null;
            this.tableAdapterManager.mantenimientoTableAdapter = null;
            this.tableAdapterManager.Solicitud_FichaSalidaTableAdapter = null;
            this.tableAdapterManager.talleresTableAdapter = null;
            this.tableAdapterManager.telefonosTableAdapter = null;
            this.tableAdapterManager.Tipos_LicenciaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Base_de_datos.SCUTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.vehiculosTableAdapter = null;
            this.tableAdapterManager.viaticosTableAdapter = null;
            // 
            // usuariosMontoCombustibleVehiculosBindingNavigator
            // 
            this.usuariosMontoCombustibleVehiculosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuariosMontoCombustibleVehiculosBindingNavigator.BindingSource = this.usuariosMontoCombustibleVehiculosBindingSource;
            this.usuariosMontoCombustibleVehiculosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuariosMontoCombustibleVehiculosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuariosMontoCombustibleVehiculosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usuariosMontoCombustibleVehiculosBindingNavigatorSaveItem});
            this.usuariosMontoCombustibleVehiculosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuariosMontoCombustibleVehiculosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuariosMontoCombustibleVehiculosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuariosMontoCombustibleVehiculosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuariosMontoCombustibleVehiculosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuariosMontoCombustibleVehiculosBindingNavigator.Name = "usuariosMontoCombustibleVehiculosBindingNavigator";
            this.usuariosMontoCombustibleVehiculosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuariosMontoCombustibleVehiculosBindingNavigator.Size = new System.Drawing.Size(686, 25);
            this.usuariosMontoCombustibleVehiculosBindingNavigator.TabIndex = 0;
            this.usuariosMontoCombustibleVehiculosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // usuariosMontoCombustibleVehiculosBindingNavigatorSaveItem
            // 
            this.usuariosMontoCombustibleVehiculosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuariosMontoCombustibleVehiculosBindingNavigatorSaveItem.Enabled = false;
            this.usuariosMontoCombustibleVehiculosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosMontoCombustibleVehiculosBindingNavigatorSaveItem.Image")));
            this.usuariosMontoCombustibleVehiculosBindingNavigatorSaveItem.Name = "usuariosMontoCombustibleVehiculosBindingNavigatorSaveItem";
            this.usuariosMontoCombustibleVehiculosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.usuariosMontoCombustibleVehiculosBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaInicialToolStripLabel,
            this.fechaInicialToolStripTextBox,
            this.fechaFinalToolStripLabel,
            this.fechaFinalToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(686, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fechaInicialToolStripLabel
            // 
            this.fechaInicialToolStripLabel.Name = "fechaInicialToolStripLabel";
            this.fechaInicialToolStripLabel.Size = new System.Drawing.Size(70, 22);
            this.fechaInicialToolStripLabel.Text = "fechaInicial:";
            // 
            // fechaInicialToolStripTextBox
            // 
            this.fechaInicialToolStripTextBox.Name = "fechaInicialToolStripTextBox";
            this.fechaInicialToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fechaFinalToolStripLabel
            // 
            this.fechaFinalToolStripLabel.Name = "fechaFinalToolStripLabel";
            this.fechaFinalToolStripLabel.Size = new System.Drawing.Size(64, 15);
            this.fechaFinalToolStripLabel.Text = "fechaFinal:";
            // 
            // fechaFinalToolStripTextBox
            // 
            this.fechaFinalToolStripTextBox.Name = "fechaFinalToolStripTextBox";
            this.fechaFinalToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // usuariosMontoCombustibleVehiculosDataGridView
            // 
            this.usuariosMontoCombustibleVehiculosDataGridView.AutoGenerateColumns = false;
            this.usuariosMontoCombustibleVehiculosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosMontoCombustibleVehiculosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.usuariosMontoCombustibleVehiculosDataGridView.DataSource = this.usuariosMontoCombustibleVehiculosBindingSource;
            this.usuariosMontoCombustibleVehiculosDataGridView.Location = new System.Drawing.Point(12, 53);
            this.usuariosMontoCombustibleVehiculosDataGridView.Name = "usuariosMontoCombustibleVehiculosDataGridView";
            this.usuariosMontoCombustibleVehiculosDataGridView.Size = new System.Drawing.Size(662, 302);
            this.usuariosMontoCombustibleVehiculosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Placa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Placa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tipo de Combustible";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo de Combustible";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gasto de Combustible";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gasto de Combustible";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gasto en Efectivo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gasto en Efectivo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ConsultaUsuariosCombustibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 367);
            this.Controls.Add(this.usuariosMontoCombustibleVehiculosDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.usuariosMontoCombustibleVehiculosBindingNavigator);
            this.Name = "ConsultaUsuariosCombustibles";
            this.Text = "ConsultaUsuariosCombustibles";
            ((System.ComponentModel.ISupportInitialize)(this.sCUTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosMontoCombustibleVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosMontoCombustibleVehiculosBindingNavigator)).EndInit();
            this.usuariosMontoCombustibleVehiculosBindingNavigator.ResumeLayout(false);
            this.usuariosMontoCombustibleVehiculosBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosMontoCombustibleVehiculosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SCUTDataSet sCUTDataSet;
        private System.Windows.Forms.BindingSource usuariosMontoCombustibleVehiculosBindingSource;
        private SCUTDataSetTableAdapters.UsuariosMontoCombustibleVehiculosTableAdapter usuariosMontoCombustibleVehiculosTableAdapter;
        private SCUTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuariosMontoCombustibleVehiculosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usuariosMontoCombustibleVehiculosBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel fechaInicialToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fechaInicialToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fechaFinalToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fechaFinalToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView usuariosMontoCombustibleVehiculosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}