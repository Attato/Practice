namespace Practice.UI
{
    partial class MainForm
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
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practiceDataSet = new Practice.practiceDataSet();
            this.registerTableAdapter = new Practice.practiceDataSetTableAdapters.registerTableAdapter();
            this.tourAgencyDataSet = new Practice.TourAgencyDataSet();
            this.tourAgencyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelTableAdapter = new Practice.TourAgencyDataSetTableAdapters.HotelTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countOfStarsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourAgencyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.countOfStarsDataGridViewTextBoxColumn,
            this.countryCodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hotelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(113, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "register";
            this.registerBindingSource.DataSource = this.practiceDataSet;
            // 
            // practiceDataSet
            // 
            this.practiceDataSet.DataSetName = "practiceDataSet";
            this.practiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerTableAdapter
            // 
            this.registerTableAdapter.ClearBeforeFill = true;
            // 
            // tourAgencyDataSet
            // 
            this.tourAgencyDataSet.DataSetName = "TourAgencyDataSet";
            this.tourAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tourAgencyDataSetBindingSource
            // 
            this.tourAgencyDataSetBindingSource.DataSource = this.tourAgencyDataSet;
            this.tourAgencyDataSetBindingSource.Position = 0;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.tourAgencyDataSetBindingSource;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // countOfStarsDataGridViewTextBoxColumn
            // 
            this.countOfStarsDataGridViewTextBoxColumn.DataPropertyName = "CountOfStars";
            this.countOfStarsDataGridViewTextBoxColumn.HeaderText = "CountOfStars";
            this.countOfStarsDataGridViewTextBoxColumn.Name = "countOfStarsDataGridViewTextBoxColumn";
            // 
            // countryCodeDataGridViewTextBoxColumn
            // 
            this.countryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.HeaderText = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.Name = "countryCodeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourAgencyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private practiceDataSet practiceDataSet;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private practiceDataSetTableAdapters.registerTableAdapter registerTableAdapter;
        private System.Windows.Forms.BindingSource tourAgencyDataSetBindingSource;
        private TourAgencyDataSet tourAgencyDataSet;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private TourAgencyDataSetTableAdapters.HotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countOfStarsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}