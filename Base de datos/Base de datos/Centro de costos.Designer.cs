namespace Base_de_datos
{
    partial class Centro_de_costos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxIDCentroCosto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label48 = new System.Windows.Forms.Label();
            this.textBoxCentroCosto = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxElimModNomCC = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.comboBoxElimModCC = new System.Windows.Forms.ComboBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 188);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxIDCentroCosto);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.label48);
            this.tabPage1.Controls.Add(this.textBoxCentroCosto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(387, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo centro de costos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBoxIDCentroCosto
            // 
            this.textBoxIDCentroCosto.Location = new System.Drawing.Point(159, 32);
            this.textBoxIDCentroCosto.Name = "textBoxIDCentroCosto";
            this.textBoxIDCentroCosto.Size = new System.Drawing.Size(208, 20);
            this.textBoxIDCentroCosto.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID Del Centro de Costo:";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(266, 113);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(101, 23);
            this.button11.TabIndex = 40;
            this.button11.Text = "Guardar";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(15, 81);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(143, 13);
            this.label48.TabIndex = 38;
            this.label48.Text = "Nombre del Centro de Costo:";
            // 
            // textBoxCentroCosto
            // 
            this.textBoxCentroCosto.Location = new System.Drawing.Point(159, 78);
            this.textBoxCentroCosto.Name = "textBoxCentroCosto";
            this.textBoxCentroCosto.Size = new System.Drawing.Size(208, 20);
            this.textBoxCentroCosto.TabIndex = 37;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxElimModNomCC);
            this.tabPage2.Controls.Add(this.label49);
            this.tabPage2.Controls.Add(this.comboBoxElimModCC);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(387, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar centros de costo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Centro de Costo:";
            // 
            // textBoxElimModNomCC
            // 
            this.textBoxElimModNomCC.Location = new System.Drawing.Point(166, 60);
            this.textBoxElimModNomCC.Name = "textBoxElimModNomCC";
            this.textBoxElimModNomCC.Size = new System.Drawing.Size(192, 20);
            this.textBoxElimModNomCC.TabIndex = 48;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(16, 63);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(141, 13);
            this.label49.TabIndex = 44;
            this.label49.Text = "Nombre del centro de costo:";
            // 
            // comboBoxElimModCC
            // 
            this.comboBoxElimModCC.FormattingEnabled = true;
            this.comboBoxElimModCC.Location = new System.Drawing.Point(166, 18);
            this.comboBoxElimModCC.Name = "comboBoxElimModCC";
            this.comboBoxElimModCC.Size = new System.Drawing.Size(192, 21);
            this.comboBoxElimModCC.TabIndex = 47;
            this.comboBoxElimModCC.SelectedIndexChanged += new System.EventHandler(this.comboBoxElimModCC_SelectedIndexChanged);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(257, 105);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(101, 23);
            this.button13.TabIndex = 46;
            this.button13.Text = "Modificar";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(150, 105);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(101, 23);
            this.button12.TabIndex = 45;
            this.button12.Text = "Eliminar";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Centro_de_costos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 212);
            this.Controls.Add(this.tabControl1);
            this.Name = "Centro_de_costos";
            this.Text = "Centro_de_costos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBoxCentroCosto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ComboBox comboBoxElimModCC;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBoxIDCentroCosto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxElimModNomCC;
    }
}