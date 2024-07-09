namespace Latih10_KonekDatabase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            NewButton = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            DeleteButton = new Button();
            SaveButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            KotaText = new TextBox();
            AlamatText = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            TempatLahirText = new TextBox();
            TglLahirPicker = new DateTimePicker();
            label5 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            NisText = new TextBox();
            label4 = new Label();
            SiswaNameText = new TextBox();
            label3 = new Label();
            SiswaIdText = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1130, 639);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.PaleGoldenrod;
            tabPage1.Controls.Add(NewButton);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1122, 601);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List Data";
            // 
            // NewButton
            // 
            NewButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            NewButton.BackColor = Color.ForestGreen;
            NewButton.FlatStyle = FlatStyle.Flat;
            NewButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewButton.ForeColor = SystemColors.Control;
            NewButton.Location = new Point(954, 523);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(144, 40);
            NewButton.TabIndex = 2;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Click += NewButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.DarkKhaki;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1080, 456);
            dataGridView1.TabIndex = 1;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.PaleGoldenrod;
            tabPage2.Controls.Add(DeleteButton);
            tabPage2.Controls.Add(SaveButton);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1122, 601);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Input Data";
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteButton.BackColor = Color.Red;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = SystemColors.Control;
            DeleteButton.Location = new Point(870, 544);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(112, 34);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.BackColor = Color.Blue;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = SystemColors.Control;
            SaveButton.Location = new Point(1002, 544);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(112, 34);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.DarkKhaki;
            panel2.Controls.Add(KotaText);
            panel2.Controls.Add(AlamatText);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(TempatLahirText);
            panel2.Controls.Add(TglLahirPicker);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(566, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 521);
            panel2.TabIndex = 0;
            // 
            // KotaText
            // 
            KotaText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            KotaText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KotaText.Location = new Point(16, 404);
            KotaText.Name = "KotaText";
            KotaText.Size = new Size(518, 31);
            KotaText.TabIndex = 8;
            // 
            // AlamatText
            // 
            AlamatText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AlamatText.Location = new Point(16, 280);
            AlamatText.Multiline = true;
            AlamatText.Name = "AlamatText";
            AlamatText.Size = new Size(518, 109);
            AlamatText.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 249);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 11;
            label7.Text = "Alamat - Kota";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(518, 33);
            comboBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 139);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 9;
            label6.Text = "Gender";
            // 
            // TempatLahirText
            // 
            TempatLahirText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TempatLahirText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TempatLahirText.Location = new Point(16, 47);
            TempatLahirText.Name = "TempatLahirText";
            TempatLahirText.Size = new Size(518, 31);
            TempatLahirText.TabIndex = 4;
            // 
            // TglLahirPicker
            // 
            TglLahirPicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TglLahirPicker.Location = new Point(16, 92);
            TglLahirPicker.Name = "TglLahirPicker";
            TglLahirPicker.Size = new Size(518, 31);
            TglLahirPicker.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 16);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 4;
            label5.Text = "Tempat - Tgl Lahir";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.DarkKhaki;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(NisText);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SiswaNameText);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SiswaIdText);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 521);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 16);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 8;
            label2.Text = "Siswa Id";
            // 
            // NisText
            // 
            NisText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NisText.Location = new Point(18, 206);
            NisText.Name = "NisText";
            NisText.Size = new Size(516, 31);
            NisText.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 175);
            label4.Name = "label4";
            label4.Size = new Size(182, 28);
            label4.TabIndex = 7;
            label4.Text = "Nomor Induk Siswa";
            // 
            // SiswaNameText
            // 
            SiswaNameText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SiswaNameText.Location = new Point(16, 125);
            SiswaNameText.Name = "SiswaNameText";
            SiswaNameText.Size = new Size(518, 31);
            SiswaNameText.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 94);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 5;
            label3.Text = "Siswa Name";
            // 
            // SiswaIdText
            // 
            SiswaIdText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SiswaIdText.Location = new Point(16, 47);
            SiswaIdText.Name = "SiswaIdText";
            SiswaIdText.ReadOnly = true;
            SiswaIdText.Size = new Size(518, 31);
            SiswaIdText.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 639);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button NewButton;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox SiswaNameText;
        private Label label3;
        private TextBox SiswaIdText;
        private TextBox NisText;
        private Label label4;
        private Label label5;
        private DateTimePicker TglLahirPicker;
        private TextBox TempatLahirText;
        private TextBox AlamatText;
        private Label label7;
        private ComboBox comboBox1;
        private Label label6;
        private Button SaveButton;
        private TextBox KotaText;
        private Label label2;
        private Button DeleteButton;
    }
}
