namespace Base_de_datos
{
    partial class ContultaUsuariosViaticos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContultaUsuariosViaticos));
            this.sCUTDataSet = new Base_de_datos.SCUTDataSet();
            this.usuariosViaticosSalidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosViaticosSalidaTableAdapter = new Base_de_datos.SCUTDataSetTableAdapters.UsuariosViaticosSalidaTableAdapter();
            this.tableAdapterManager = new Base_de_datos.SCUTDataSetTableAdapters.TableAdapterManager();
            this.usuariosViaticosSalidaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.usuariosViaticosSalidaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fechaInicialToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fechaInicialToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fechaFinalToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fechaFinalToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.usuariosViaticosSalidaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sCUTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosViaticosSalidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosViaticosSalidaBindingNavigator)).BeginInit();
            this.usuariosViaticosSalidaBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosViaticosSalidaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sCUTDataSet
            // 
            this.sCUTDataSet.DataSetName = "SCUTDataSet";
            this.sCUTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosViaticosSalidaBindingSource
            // 
            this.usuariosViaticosSalidaBindingSource.DataMember = "UsuariosViaticosSalida";
            this.usuariosViaticosSalidaBindingSource.DataSource = this.sCUTDataSet;
            // 
            // usuariosViaticosSalidaTableAdapter
            // 
            this.usuariosViaticosSalidaTableAdapter.ClearBeforeFill = true;
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
            // usuariosViaticosSalidaBindingNavigator
            // 
            this.usuariosViaticosSalidaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuariosViaticosSalidaBindingNavigator.BindingSource = this.usuariosViaticosSalidaBindingSource;
            this.usuariosViaticosSalidaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuariosViaticosSalidaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuariosViaticosSalidaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.usuariosViaticosSalidaBindingNavigatorSaveItem});
            this.usuariosViaticosSalidaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuariosViaticosSalidaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuariosViaticosSalidaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuariosViaticosSalidaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuariosViaticosSalidaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuariosViaticosSalidaBindingNavigator.Name = "usuariosViaticosSalidaBindingNavigator";
            this.usuariosViaticosSalidaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuariosViaticosSalidaBindingNavigator.Size = new System.Drawing.Size(772, 25);
            this.usuariosViaticosSalidaBindingNavigator.TabIndex = 0;
            this.usuariosViaticosSalidaBindingNavigator.Text = "bindingNavigator1";
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
            // usuariosViaticosSalidaBindingNavigatorSaveItem
            // 
            this.usuariosViaticosSalidaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuariosViaticosSalidaBindingNavigatorSaveItem.Enabled = false;
            this.usuariosViaticosSalidaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosViaticosSalidaBindingNavigatorSaveItem.Image")));
            this.usuariosViaticosSalidaBindingNavigatorSaveItem.Name = "usuariosViaticosSalidaBindingNavigatorSaveItem";
            this.usuariosViaticosSalidaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.usuariosViaticosSalidaBindingNavigatorSaveItem.Text = "Guardar datos";
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
            this.fillToolStrip.Size = new System.Drawing.Size(772, 25);
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
            // usuariosViaticosSalidaDataGridView
            // 
            this.usuariosViaticosSalidaDataGridView.AutoGenerateColumns = false;
            this.usuariosViaticosSalidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosViaticosSalidaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.usuariosViaticosSalidaDataGridView.DataSource = this.usuariosViaticosSalidaBindingSource;
            this.usuariosViaticosSalidaDataGridView.Location = new System.Drawing.Point(12, 53);
            this.usuariosViaticosSalidaDataGridView.Name = "usuariosViaticosSalidaDataGridView";
            this.usuariosViaticosSalidaDataGridView.Size = new System.Drawing.Size(748, 287);
            this.usuariosViaticosSalidaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_U";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_U";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cedula";
            this.dataGridViewTextBoxColumn3.HeaderText = "cedula";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID Viatico";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID Viatico";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Detalle";
            this.dataGridViewTextBoxColumn5.HeaderText = "Detalle";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "monto";
            this.dataGridViewTextBoxColumn6.HeaderText = "monto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // ContultaUsuariosViaticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 352);
            this.Controls.Add(this.usuariosViaticosSalidaDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.usuariosViaticosSalidaBindingNavigator);
            this.Name = "ContultaUsuariosViaticos";
            this.Text = "ContultaUsuariosViaticos";
            ((System.ComponentModel.ISupportInitialize)(this.sCUTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosViaticosSalidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosViaticosSalidaBindingNavigator)).EndInit();
            this.usuariosViaticosSalidaBindingNavigator.ResumeLayout(false);
            this.usuariosViaticosSalidaBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosViaticosSalidaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SCUTDataSet sCUTDataSet;
        private System.Windows.Forms.BindingSource usuariosViaticosSalidaBindingSource;
        private SCUTDataSetTableAdapters.UsuariosViaticosSalidaTableAdapter usuariosViaticosSalidaTableAdapter;
        private SCUTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuariosViaticosSalidaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton usuariosViaticosSalidaBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel fechaInicialToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fechaInicialToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fechaFinalToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fechaFinalToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView usuariosViaticosSalidaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}