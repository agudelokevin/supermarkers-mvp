namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            DgPayMode = new DataGridView();
            btnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            TxtPayModeObservation = new TextBox();
            label5 = new Label();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            TxtPayModeId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 147);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(828, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 22);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 147);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(999, 481);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnClose);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnEdit);
            tabPage1.Controls.Add(btnNew);
            tabPage1.Controls.Add(DgPayMode);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(TxtSearch);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(991, 446);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pay Mode List ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.cerrar;
            btnClose.Location = new Point(721, 332);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(69, 39);
            btnClose.TabIndex = 7;
            btnClose.Text = " Search";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(721, 277);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(69, 39);
            btnDelete.TabIndex = 6;
            btnDelete.Text = " Search";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(721, 216);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(69, 39);
            btnEdit.TabIndex = 5;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(721, 155);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(69, 39);
            btnNew.TabIndex = 4;
            btnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(115, 163);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowTemplate.Height = 25;
            DgPayMode.Size = new Size(502, 184);
            DgPayMode.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(702, 83);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 28);
            btnSearch.TabIndex = 2;
            btnSearch.Text = " Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(202, 83);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(415, 29);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 58);
            label2.Name = "label2";
            label2.Size = new Size(173, 22);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnCancel);
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(TxtPayModeObservation);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(TxtPayModeName);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TxtPayModeId);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(991, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pay Mode Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(507, 280);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 65);
            btnCancel.TabIndex = 9;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(331, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 65);
            btnSave.TabIndex = 8;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(549, 104);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(415, 115);
            TxtPayModeObservation.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(640, 79);
            label5.Name = "label5";
            label5.Size = new Size(221, 22);
            label5.TabIndex = 6;
            label5.Text = "Pay Mode Observation";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(9, 190);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(415, 29);
            TxtPayModeName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 165);
            label4.Name = "label4";
            label4.Size = new Size(159, 22);
            label4.TabIndex = 4;
            label4.Text = "Pay Mode Name";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(9, 104);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(415, 29);
            TxtPayModeId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 79);
            label3.Name = "label3";
            label3.Size = new Size(124, 22);
            label3.TabIndex = 2;
            label3.Text = "Pay Mode Id";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 628);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "PayModeView";
            Text = "PayModeView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnClose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private DataGridView DgPayMode;
        private Button btnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPage2;
        private Button btnCancel;
        private Button btnSave;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private TextBox TxtPayModeName;
        private Label label4;
        private TextBox TxtPayModeId;
        private Label label3;
    }
}