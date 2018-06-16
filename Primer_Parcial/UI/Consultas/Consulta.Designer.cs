namespace Primer_Parcial.UI.Consultas
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CriterioBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DesdeFechaBox = new System.Windows.Forms.DateTimePicker();
            this.HastaFechaBox = new System.Windows.Forms.DateTimePicker();
            this.ConsultaBoton = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.primerParcialDBDataSet1 = new Primer_Parcial.PrimerParcialDBDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primerParcialDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FiltroCombo
            // 
            this.FiltroCombo.FormattingEnabled = true;
            this.FiltroCombo.Items.AddRange(new object[] {
            "ID",
            "Descripcion ",
            "Fecha"});
            this.FiltroCombo.Location = new System.Drawing.Point(64, 26);
            this.FiltroCombo.Name = "FiltroCombo";
            this.FiltroCombo.Size = new System.Drawing.Size(121, 21);
            this.FiltroCombo.TabIndex = 1;
            this.FiltroCombo.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(197, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criterio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CriterioBox
            // 
            this.CriterioBox.Location = new System.Drawing.Point(260, 27);
            this.CriterioBox.Name = "CriterioBox";
            this.CriterioBox.Size = new System.Drawing.Size(272, 20);
            this.CriterioBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(570, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filtrar Usando Rango de fechas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(627, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(627, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hasta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DesdeFechaBox
            // 
            this.DesdeFechaBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeFechaBox.Location = new System.Drawing.Point(679, 64);
            this.DesdeFechaBox.Name = "DesdeFechaBox";
            this.DesdeFechaBox.Size = new System.Drawing.Size(106, 20);
            this.DesdeFechaBox.TabIndex = 7;
            // 
            // HastaFechaBox
            // 
            this.HastaFechaBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaFechaBox.Location = new System.Drawing.Point(679, 90);
            this.HastaFechaBox.Name = "HastaFechaBox";
            this.HastaFechaBox.Size = new System.Drawing.Size(106, 20);
            this.HastaFechaBox.TabIndex = 8;
            // 
            // ConsultaBoton
            // 
            this.ConsultaBoton.Image = ((System.Drawing.Image)(resources.GetObject("ConsultaBoton.Image")));
            this.ConsultaBoton.Location = new System.Drawing.Point(75, 66);
            this.ConsultaBoton.Name = "ConsultaBoton";
            this.ConsultaBoton.Size = new System.Drawing.Size(100, 32);
            this.ConsultaBoton.TabIndex = 9;
            this.ConsultaBoton.Text = "Buscar";
            this.ConsultaBoton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConsultaBoton.UseVisualStyleBackColor = true;
            this.ConsultaBoton.Click += new System.EventHandler(this.ConsultaBoton_Click);
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(12, 118);
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.Size = new System.Drawing.Size(773, 165);
            this.DataView.TabIndex = 10;
            this.DataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellContentClick);
            // 
            // primerParcialDBDataSet1
            // 
            this.primerParcialDBDataSet1.DataSetName = "PrimerParcialDBDataSet";
            this.primerParcialDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 301);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.ConsultaBoton);
            this.Controls.Add(this.HastaFechaBox);
            this.Controls.Add(this.DesdeFechaBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CriterioBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltroCombo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primerParcialDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltroCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CriterioBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DesdeFechaBox;
        private System.Windows.Forms.DateTimePicker HastaFechaBox;
        private System.Windows.Forms.Button ConsultaBoton;
        private System.Windows.Forms.DataGridView DataView;
        private PrimerParcialDBDataSet primerParcialDBDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}