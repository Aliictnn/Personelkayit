namespace Personelkayit
{
    partial class gorevtkpprog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.görevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.görevdurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alınacakizinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesaisaatleriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.görevKBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.loginVeriDataSet9 = new Personelkayit.LoginVeriDataSet9();
            this.görevTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginVeriDataSet6 = new Personelkayit.LoginVeriDataSet6();
            this.görevTTableAdapter = new Personelkayit.LoginVeriDataSet6TableAdapters.görevTTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.loginVeriDataSet7 = new Personelkayit.LoginVeriDataSet7();
            this.görevKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.görevKTableAdapter = new Personelkayit.LoginVeriDataSet7TableAdapters.görevKTableAdapter();
            this.txtizin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmsaat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loginVeriDataSet8 = new Personelkayit.LoginVeriDataSet8();
            this.görevKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.görevKTableAdapter1 = new Personelkayit.LoginVeriDataSet8TableAdapters.görevKTableAdapter();
            this.görevKTableAdapter2 = new Personelkayit.LoginVeriDataSet9TableAdapters.görevKTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.görevKBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.görevTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.görevKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.görevKBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.görevdurumuDataGridViewTextBoxColumn,
            this.ofDataGridViewTextBoxColumn,
            this.alınacakizinDataGridViewTextBoxColumn,
            this.mesaisaatleriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.görevKBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(7, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1488, 531);
            this.dataGridView1.TabIndex = 0;
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
            // görevdurumuDataGridViewTextBoxColumn
            // 
            this.görevdurumuDataGridViewTextBoxColumn.DataPropertyName = "Görevdurumu";
            this.görevdurumuDataGridViewTextBoxColumn.HeaderText = "Görevdurumu";
            this.görevdurumuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.görevdurumuDataGridViewTextBoxColumn.Name = "görevdurumuDataGridViewTextBoxColumn";
            this.görevdurumuDataGridViewTextBoxColumn.Width = 150;
            // 
            // ofDataGridViewTextBoxColumn
            // 
            this.ofDataGridViewTextBoxColumn.DataPropertyName = "Of";
            this.ofDataGridViewTextBoxColumn.HeaderText = "Of";
            this.ofDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ofDataGridViewTextBoxColumn.Name = "ofDataGridViewTextBoxColumn";
            this.ofDataGridViewTextBoxColumn.Width = 150;
            // 
            // alınacakizinDataGridViewTextBoxColumn
            // 
            this.alınacakizinDataGridViewTextBoxColumn.DataPropertyName = "Alınacakizin";
            this.alınacakizinDataGridViewTextBoxColumn.HeaderText = "Alınacakizin";
            this.alınacakizinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alınacakizinDataGridViewTextBoxColumn.Name = "alınacakizinDataGridViewTextBoxColumn";
            this.alınacakizinDataGridViewTextBoxColumn.Width = 150;
            // 
            // mesaisaatleriDataGridViewTextBoxColumn
            // 
            this.mesaisaatleriDataGridViewTextBoxColumn.DataPropertyName = "Mesaisaatleri";
            this.mesaisaatleriDataGridViewTextBoxColumn.HeaderText = "Mesaisaatleri";
            this.mesaisaatleriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mesaisaatleriDataGridViewTextBoxColumn.Name = "mesaisaatleriDataGridViewTextBoxColumn";
            this.mesaisaatleriDataGridViewTextBoxColumn.Width = 150;
            // 
            // görevKBindingSource2
            // 
            this.görevKBindingSource2.DataMember = "görevK";
            this.görevKBindingSource2.DataSource = this.loginVeriDataSet9;
            // 
            // loginVeriDataSet9
            // 
            this.loginVeriDataSet9.DataSetName = "LoginVeriDataSet9";
            this.loginVeriDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // görevTBindingSource
            // 
            this.görevTBindingSource.DataMember = "görevT";
            this.görevTBindingSource.DataSource = this.loginVeriDataSet6;
            // 
            // loginVeriDataSet6
            // 
            this.loginVeriDataSet6.DataSetName = "LoginVeriDataSet6";
            this.loginVeriDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // görevTTableAdapter
            // 
            this.görevTTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(21, 882);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Geri\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginVeriDataSet7
            // 
            this.loginVeriDataSet7.DataSetName = "LoginVeriDataSet7";
            this.loginVeriDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // görevKBindingSource
            // 
            this.görevKBindingSource.DataMember = "görevK";
            this.görevKBindingSource.DataSource = this.loginVeriDataSet7;
            // 
            // görevKTableAdapter
            // 
            this.görevKTableAdapter.ClearBeforeFill = true;
            // 
            // txtizin
            // 
            this.txtizin.Location = new System.Drawing.Point(334, 882);
            this.txtizin.Name = "txtizin";
            this.txtizin.Size = new System.Drawing.Size(160, 26);
            this.txtizin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(170, 881);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alınacak izin :";
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(334, 808);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(160, 26);
            this.txtıd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(180, 807);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Personel ID :";
            // 
            // txtmsaat
            // 
            this.txtmsaat.Location = new System.Drawing.Point(334, 921);
            this.txtmsaat.Name = "txtmsaat";
            this.txtmsaat.Size = new System.Drawing.Size(160, 26);
            this.txtmsaat.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(152, 918);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mesaai sattleri :";
            // 
            // loginVeriDataSet8
            // 
            this.loginVeriDataSet8.DataSetName = "LoginVeriDataSet8";
            this.loginVeriDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // görevKBindingSource1
            // 
            this.görevKBindingSource1.DataMember = "görevK";
            this.görevKBindingSource1.DataSource = this.loginVeriDataSet8;
            // 
            // görevKTableAdapter1
            // 
            this.görevKTableAdapter1.ClearBeforeFill = true;
            // 
            // görevKTableAdapter2
            // 
            this.görevKTableAdapter2.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(514, 805);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 66);
            this.button2.TabIndex = 13;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(514, 883);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 66);
            this.button3.TabIndex = 14;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtof
            // 
            this.txtof.Location = new System.Drawing.Point(335, 848);
            this.txtof.Name = "txtof";
            this.txtof.Size = new System.Drawing.Size(160, 26);
            this.txtof.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(269, 847);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Of :";
            // 
            // gorevtkpprog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1507, 970);
            this.Controls.Add(this.txtof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtmsaat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtıd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtizin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "gorevtkpprog";
            this.Text = "gorevtkpprog";
            this.Load += new System.EventHandler(this.gorevtkpprog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.görevKBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.görevTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.görevKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginVeriDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.görevKBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LoginVeriDataSet6 loginVeriDataSet6;
        private System.Windows.Forms.BindingSource görevTBindingSource;
        private LoginVeriDataSet6TableAdapters.görevTTableAdapter görevTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn görevDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private LoginVeriDataSet7 loginVeriDataSet7;
        private System.Windows.Forms.BindingSource görevKBindingSource;
        private LoginVeriDataSet7TableAdapters.görevKTableAdapter görevKTableAdapter;
        private System.Windows.Forms.TextBox txtizin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmsaat;
        private System.Windows.Forms.Label label5;
        private LoginVeriDataSet8 loginVeriDataSet8;
        private System.Windows.Forms.BindingSource görevKBindingSource1;
        private LoginVeriDataSet8TableAdapters.görevKTableAdapter görevKTableAdapter1;
        private LoginVeriDataSet9 loginVeriDataSet9;
        private System.Windows.Forms.BindingSource görevKBindingSource2;
        private LoginVeriDataSet9TableAdapters.görevKTableAdapter görevKTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn görevdurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alınacakizinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesaisaatleriDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtof;
        private System.Windows.Forms.Label label1;
    }
}