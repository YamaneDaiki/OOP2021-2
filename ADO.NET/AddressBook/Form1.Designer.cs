
namespace AddressBook {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.personDataGridView = new System.Windows.Forms.DataGridView();
            this.dbConnect = new System.Windows.Forms.Button();
            this.btNameFilter = new System.Windows.Forms.Button();
            this.tbNameSearch = new System.Windows.Forms.TextBox();
            this.dbSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btBirthdayFill = new System.Windows.Forms.Button();
            this.tbBirthdaySearch = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202124DataSet = new AddressBook.infosys202124DataSet();
            this.personTableAdapter = new AddressBook.infosys202124DataSetTableAdapters.PersonTableAdapter();
            this.tableAdapterManager = new AddressBook.infosys202124DataSetTableAdapters.TableAdapterManager();
            this.dtpBirthdaySearch = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202124DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // personDataGridView
            // 
            this.personDataGridView.AllowUserToAddRows = false;
            this.personDataGridView.AutoGenerateColumns = false;
            this.personDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.personDataGridView.DataSource = this.personBindingSource;
            this.personDataGridView.Location = new System.Drawing.Point(3, 238);
            this.personDataGridView.MultiSelect = false;
            this.personDataGridView.Name = "personDataGridView";
            this.personDataGridView.ReadOnly = true;
            this.personDataGridView.RowTemplate.Height = 21;
            this.personDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personDataGridView.Size = new System.Drawing.Size(633, 145);
            this.personDataGridView.TabIndex = 1;
            this.personDataGridView.SelectionChanged += new System.EventHandler(this.personDataGridView_SelectionChanged);
            // 
            // dbConnect
            // 
            this.dbConnect.Location = new System.Drawing.Point(12, 401);
            this.dbConnect.Name = "dbConnect";
            this.dbConnect.Size = new System.Drawing.Size(64, 35);
            this.dbConnect.TabIndex = 2;
            this.dbConnect.Text = "接続";
            this.dbConnect.UseVisualStyleBackColor = true;
            this.dbConnect.Click += new System.EventHandler(this.dbConnect_Click);
            // 
            // btNameFilter
            // 
            this.btNameFilter.Location = new System.Drawing.Point(370, 401);
            this.btNameFilter.Name = "btNameFilter";
            this.btNameFilter.Size = new System.Drawing.Size(64, 35);
            this.btNameFilter.TabIndex = 3;
            this.btNameFilter.Text = "名前抽出";
            this.btNameFilter.UseVisualStyleBackColor = true;
            this.btNameFilter.Click += new System.EventHandler(this.btNameFilter_Click);
            // 
            // tbNameSearch
            // 
            this.tbNameSearch.Location = new System.Drawing.Point(203, 409);
            this.tbNameSearch.Name = "tbNameSearch";
            this.tbNameSearch.Size = new System.Drawing.Size(161, 19);
            this.tbNameSearch.TabIndex = 4;
            // 
            // dbSave
            // 
            this.dbSave.Location = new System.Drawing.Point(94, 401);
            this.dbSave.Name = "dbSave";
            this.dbSave.Size = new System.Drawing.Size(64, 37);
            this.dbSave.TabIndex = 5;
            this.dbSave.Text = "保存";
            this.dbSave.UseVisualStyleBackColor = true;
            this.dbSave.Click += new System.EventHandler(this.dbSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "誕生日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "電話番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "備考";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(84, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(192, 19);
            this.tbName.TabIndex = 7;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(84, 137);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(192, 19);
            this.tbTelephone.TabIndex = 7;
            // 
            // tbMemo
            // 
            this.tbMemo.Location = new System.Drawing.Point(349, 46);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(261, 110);
            this.tbMemo.TabIndex = 7;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(84, 81);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(192, 19);
            this.dtpDate.TabIndex = 8;
            // 
            // btBirthdayFill
            // 
            this.btBirthdayFill.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btBirthdayFill.Location = new System.Drawing.Point(371, 466);
            this.btBirthdayFill.Name = "btBirthdayFill";
            this.btBirthdayFill.Size = new System.Drawing.Size(75, 23);
            this.btBirthdayFill.TabIndex = 9;
            this.btBirthdayFill.Text = "誕生日抽出";
            this.btBirthdayFill.UseVisualStyleBackColor = true;
            this.btBirthdayFill.Click += new System.EventHandler(this.btBirthdayFill_Click);
            // 
            // tbBirthdaySearch
            // 
            this.tbBirthdaySearch.Location = new System.Drawing.Point(475, 410);
            this.tbBirthdaySearch.Name = "tbBirthdaySearch";
            this.tbBirthdaySearch.Size = new System.Drawing.Size(161, 19);
            this.tbBirthdaySearch.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn3.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Memo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Memo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.infosys202124DataSet;
            // 
            // infosys202124DataSet
            // 
            this.infosys202124DataSet.DataSetName = "infosys202124DataSet";
            this.infosys202124DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonTableAdapter = this.personTableAdapter;
            this.tableAdapterManager.UpdateOrder = AddressBook.infosys202124DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dtpBirthdaySearch
            // 
            this.dtpBirthdaySearch.Location = new System.Drawing.Point(203, 470);
            this.dtpBirthdaySearch.Name = "dtpBirthdaySearch";
            this.dtpBirthdaySearch.Size = new System.Drawing.Size(161, 19);
            this.dtpBirthdaySearch.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 494);
            this.Controls.Add(this.dtpBirthdaySearch);
            this.Controls.Add(this.btBirthdayFill);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbBirthdaySearch);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbSave);
            this.Controls.Add(this.tbNameSearch);
            this.Controls.Add(this.btNameFilter);
            this.Controls.Add(this.dbConnect);
            this.Controls.Add(this.personDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202124DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private infosys202124DataSet infosys202124DataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private infosys202124DataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private infosys202124DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView personDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button dbConnect;
        private System.Windows.Forms.Button btNameFilter;
        private System.Windows.Forms.TextBox tbNameSearch;
        private System.Windows.Forms.Button dbSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btBirthdayFill;
        private System.Windows.Forms.TextBox tbBirthdaySearch;
        private System.Windows.Forms.DateTimePicker dtpBirthdaySearch;
    }
}

