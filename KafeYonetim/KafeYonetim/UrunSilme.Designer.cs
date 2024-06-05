using System.Windows.Forms;

namespace KafeYonetim
{
    partial class UrunSilme
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label2 = new Label();
            btnExit = new PictureBox();
            txtUrunAra = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 23F, FontStyle.Bold);
            label2.Location = new Point(240, 13);
            label2.Name = "label2";
            label2.Size = new Size(178, 46);
            label2.TabIndex = 18;
            label2.Text = "ÜRÜN SİLME";
            // 
            // btnExit
            // 
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.Image = Properties.Resources.pngegg__1_;
            btnExit.Location = new Point(12, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(51, 49);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 29;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtUrunAra
            // 
            txtUrunAra.BackColor = Color.SkyBlue;
            txtUrunAra.BorderStyle = BorderStyle.None;
            txtUrunAra.Font = new Font("SWRomnt", 10.7999992F, FontStyle.Bold);
            txtUrunAra.Location = new Point(204, 114);
            txtUrunAra.Multiline = true;
            txtUrunAra.Name = "txtUrunAra";
            txtUrunAra.Size = new Size(239, 54);
            txtUrunAra.TabIndex = 42;
            txtUrunAra.TextChanged += txtUrunAra_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 17F, FontStyle.Bold);
            label5.Location = new Point(282, 76);
            label5.Name = "label5";
            label5.Size = new Size(92, 35);
            label5.TabIndex = 41;
            label5.Text = "Ürün Adı";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Text Semibold", 12.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(36, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(574, 277);
            dataGridView1.TabIndex = 43;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.CornflowerBlue;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSil.Location = new Point(240, 499);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(178, 53);
            btnSil.TabIndex = 44;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // UrunSilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(651, 564);
            ControlBox = false;
            Controls.Add(btnSil);
            Controls.Add(dataGridView1);
            Controls.Add(txtUrunAra);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UrunSilme";
            Load += UrunSilme_Load;
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox btnExit;
        private TextBox txtUrunAra;
        private Label label5;
        private DataGridView dataGridView1;
        private Button btnSil;
    }
}