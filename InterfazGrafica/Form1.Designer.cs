namespace Actividad_2__Interfaz_con_conexion_a_MySQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            btn_buscar = new Button();
            label3 = new Label();
            label5 = new Label();
            combo_emociones = new ComboBox();
            panel_libros = new Panel();
            flp_libros = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel_libros.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(329, 23);
            label1.Name = "label1";
            label1.Size = new Size(156, 32);
            label1.TabIndex = 0;
            label1.Text = "BookMood";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Font = new Font("Georgia", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(297, 64);
            label2.Name = "label2";
            label2.Size = new Size(461, 17);
            label2.TabIndex = 1;
            label2.Text = "La app que te conecta tu estado de ánimo con el libro perfecto";
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(178, 221, 179);
            btn_buscar.Location = new Point(360, 172);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 26);
            btn_buscar.TabIndex = 2;
            btn_buscar.Text = "Buscar libros";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(325, 117);
            label3.Name = "label3";
            label3.Size = new Size(182, 21);
            label3.TabIndex = 5;
            label3.Text = "¿Cómo te sientes hoy?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(296, 240);
            label5.Name = "label5";
            label5.Size = new Size(208, 21);
            label5.TabIndex = 7;
            label5.Text = "Libros recomendados para ti";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // combo_emociones
            // 
            combo_emociones.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_emociones.FormattingEnabled = true;
            combo_emociones.Location = new Point(349, 141);
            combo_emociones.Name = "combo_emociones";
            combo_emociones.Size = new Size(121, 25);
            combo_emociones.TabIndex = 8;
            // 
            // panel_libros
            // 
            panel_libros.AutoScroll = true;
            panel_libros.BorderStyle = BorderStyle.FixedSingle;
            panel_libros.Controls.Add(flp_libros);
            panel_libros.Location = new Point(205, 288);
            panel_libros.Name = "panel_libros";
            panel_libros.Size = new Size(364, 198);
            panel_libros.TabIndex = 11;
            // 
            // flp_libros
            // 
            flp_libros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flp_libros.AutoScroll = true;
            flp_libros.Location = new Point(0, 0);
            flp_libros.Name = "flp_libros";
            flp_libros.Size = new Size(359, 197);
            flp_libros.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 100);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(205, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 232);
            ClientSize = new Size(884, 561);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(panel_libros);
            Controls.Add(combo_emociones);
            Controls.Add(label3);
            Controls.Add(btn_buscar);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Libros y emociones";
            Load += Form1_Load;
            panel_libros.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_buscar;
        private Label label3;
        private Label label5;
        private ComboBox combo_emociones;
        private Panel panel_libros;
        private FlowLayoutPanel flp_libros;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
