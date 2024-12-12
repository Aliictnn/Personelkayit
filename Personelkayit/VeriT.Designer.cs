namespace Personelkayit
{
    partial class VeriT
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.loginVeriDataSet = new Personelkayit.LoginVeriDataSet();
            this.personelVtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVtTableAdapter = new Personelkayit.LoginVeriDataSetTableAdapters.PersonelVtTableAdapter();
            this.loginVeriDataSet2 = new Personelkayit.LoginVeriDataSet2();
            this.personelVtBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelVtTableAdapter1 = new Personelkayit.LoginVeriDataSet2TableAdapters.PersonelVtTableAdapter();
            this.loginVeriDataSet3 = new Personelkayit.LoginVeriDataSet3();
            this.personelVtBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personelVtTableAdapter2 = new Personelkayit.LoginVeriDataSet3TableAdapters.PersonelVtTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginVeriDataSet4 = new Personelkayit.LoginVeriDataSet4();
            this.personelVtBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.personelVtTableAdapter3 = new Personelkayit.LoginVeriDataSet4TableAdapters.PersonelVtTableAdapter();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.görevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girişsaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVtBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVtBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVtBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(861, 830);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(643, 830);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginVeriDataSet
            // 
            this.loginVeriDataSet.DataSetName = "LoginVeriDataSet";
            this.loginVeriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelVtBindingSource
            // 
            this.personelVtBindingSource.DataMember = "PersonelVt";
            this.personelVtBindingSource.DataSource = this.loginVeriDataSet;
            // 
            // personelVtTableAdapter
            // 
            this.personelVtTableAdapter.ClearBeforeFill = true;
            // 
            // loginVeriDataSet2
            // 
            this.loginVeriDataSet2.DataSetName = "LoginVeriDataSet2";
            this.loginVeriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelVtBindingSource1
            // 
            this.personelVtBindingSource1.DataMember = "PersonelVt";
            this.personelVtBindingSource1.DataSource = this.loginVeriDataSet2;
            // 
            // personelVtTableAdapter1
            // 
            this.personelVtTableAdapter1.ClearBeforeFill = true;
            // 
            // loginVeriDataSet3
            // 
            this.loginVeriDataSet3.DataSetName = "LoginVeriDataSet3";
            this.loginVeriDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelVtBindingSource2
            // 
            this.personelVtBindingSource2.DataMember = "PersonelVt";
            this.personelVtBindingSource2.DataSource = this.loginVeriDataSet3;
            // 
            // personelVtTableAdapter2
            // 
            this.personelVtTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.departmanDataGridViewTextBoxColumn,
            this.görevDataGridViewTextBoxColumn,
            this.girişsaatiDataGridViewTextBoxColumn,
            this.profilDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.personelVtBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1570, 810);
            this.dataGridView1.TabIndex = 3;
            // 
            // loginVeriDataSet4
            // 
            this.loginVeriDataSet4.DataSetName = "LoginVeriDataSet4";
            this.loginVeriDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelVtBindingSource3
            // 
            this.personelVtBindingSource3.DataMember = "PersonelVt";
            this.personelVtBindingSource3.DataSource = this.loginVeriDataSet4;
            // 
            // personelVtTableAdapter3
            // 
            this.personelVtTableAdapter3.ClearBeforeFill = true;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 150;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // departmanDataGridViewTextBoxColumn
            // 
            this.departmanDataGridViewTextBoxColumn.DataPropertyName = "Departman";
            this.departmanDataGridViewTextBoxColumn.HeaderText = "Departman";
            this.departmanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmanDataGridViewTextBoxColumn.Name = "departmanDataGridViewTextBoxColumn";
            this.departmanDataGridViewTextBoxColumn.Width = 150;
            // 
            // görevDataGridViewTextBoxColumn
            // 
            this.görevDataGridViewTextBoxColumn.DataPropertyName = "Görev";
            this.görevDataGridViewTextBoxColumn.HeaderText = "Görev";
            this.görevDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.görevDataGridViewTextBoxColumn.Name = "görevDataGridViewTextBoxColumn";
            this.görevDataGridViewTextBoxColumn.Width = 150;
            // 
            // girişsaatiDataGridViewTextBoxColumn
            // 
            this.girişsaatiDataGridViewTextBoxColumn.DataPropertyName = "Giriş_saati";
            this.girişsaatiDataGridViewTextBoxColumn.HeaderText = "Giriş_saati";
            this.girişsaatiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.girişsaatiDataGridViewTextBoxColumn.Name = "girişsaatiDataGridViewTextBoxColumn";
            this.girişsaatiDataGridViewTextBoxColumn.Width = 150;
            // 
            // profilDataGridViewImageColumn
            // 
            this.profilDataGridViewImageColumn.DataPropertyName = "Profil";
            this.profilDataGridViewImageColumn.HeaderText = "Profil";
            this.profilDataGridViewImageColumn.MinimumWidth = 8;
            this.profilDataGridViewImageColumn.Name = "profilDataGridViewImageColumn";
            this.profilDataGridViewImageColumn.Width = 150;
            // 
            // VeriT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1590, 897);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "VeriT";
            this.Text = "VeriT";
            this.Load += new System.EventHandler(this.VeriT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVtBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVtBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVtBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private LoginVeriDataSet loginVeriDataSet;
        private System.Windows.Forms.BindingSource personelVtBindingSource;
        private LoginVeriDataSetTableAdapters.PersonelVtTableAdapter personelVtTableAdapter;
        private LoginVeriDataSet2 loginVeriDataSet2;
        private System.Windows.Forms.BindingSource personelVtBindingSource1;
        private LoginVeriDataSet2TableAdapters.PersonelVtTableAdapter personelVtTableAdapter1;
        private LoginVeriDataSet3 loginVeriDataSet3;
        private System.Windows.Forms.BindingSource personelVtBindingSource2;
        private LoginVeriDataSet3TableAdapters.PersonelVtTableAdapter personelVtTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LoginVeriDataSet4 loginVeriDataSet4;
        private System.Windows.Forms.BindingSource personelVtBindingSource3;
        private LoginVeriDataSet4TableAdapters.PersonelVtTableAdapter personelVtTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn görevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girişsaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn profilDataGridViewImageColumn;
    }
}