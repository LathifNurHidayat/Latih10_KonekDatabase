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
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            TglLahirPicker = new DateTimePicker();
            label5 = new Label();
            panel1 = new Panel();
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
            tabControl1.Size = new Size(1128, 639);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(NewButton);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1120, 601);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List Data";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(946, 519);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(152, 49);
            NewButton.TabIndex = 5;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1080, 456);
            dataGridView1.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1120, 601);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Input Data";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 16);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 3;
            label2.Text = "Siswa Id";
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
            panel2.Controls.Add(TglLahirPicker);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(569, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 600);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // TglLahirPicker
            // 
            TglLahirPicker.Location = new Point(16, 78);
            TglLahirPicker.Name = "TglLahirPicker";
            TglLahirPicker.Size = new Size(516, 31);
            TglLahirPicker.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 16);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 4;
            label5.Text = "Siswa Id";
            // 
            // panel1
            // 
            panel1.Controls.Add(NisText);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SiswaNameText);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SiswaIdText);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 600);
            panel1.TabIndex = 0;
            // 
            // NisText
            // 
            NisText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NisText.Location = new Point(18, 206);
            NisText.Name = "NisText";
            NisText.Size = new Size(516, 31);
            NisText.TabIndex = 6;
            NisText.TextChanged += NisText_TextChanged;
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
            SiswaNameText.TabIndex = 4;
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
            SiswaIdText.Size = new Size(518, 31);
            SiswaIdText.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 639);
            Controls.Add(tabControl1);
            Name = "Form1";
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
        private Label label2;
        private TextBox SiswaNameText;
        private Label label3;
        private TextBox SiswaIdText;
        private TextBox NisText;
        private Label label4;
        private Label label5;
        private DateTimePicker TglLahirPicker;
    }
}
