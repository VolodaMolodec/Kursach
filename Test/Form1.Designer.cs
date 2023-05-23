namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.A_input = new System.Windows.Forms.TextBox();
            this.C_input = new System.Windows.Forms.TextBox();
            this.Z_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(12, 12);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(500, 500);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GL_POINTS",
            "GL_LINES",
            "GL_QUADS"});
            this.comboBox1.Location = new System.Drawing.Point(533, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(642, 297);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 215);
            this.trackBar1.TabIndex = 2;
            // 
            // RenderTimer
            // 
            this.RenderTimer.Interval = 30;
            this.RenderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Test",
            "Цилиндр",
            "Эллиптический парраболоид",
            "Конус",
            "Эллипсоид"});
            this.comboBox2.Location = new System.Drawing.Point(533, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // A_input
            // 
            this.A_input.Location = new System.Drawing.Point(533, 96);
            this.A_input.Name = "A_input";
            this.A_input.Size = new System.Drawing.Size(100, 20);
            this.A_input.TabIndex = 4;
            this.A_input.Text = "5";
            this.A_input.TextChanged += new System.EventHandler(this.A_input_TextChanged);
            // 
            // C_input
            // 
            this.C_input.Location = new System.Drawing.Point(533, 122);
            this.C_input.Name = "C_input";
            this.C_input.Size = new System.Drawing.Size(100, 20);
            this.C_input.TabIndex = 5;
            this.C_input.Text = "1";
            this.C_input.TextChanged += new System.EventHandler(this.C_input_TextChanged);
            // 
            // Z_input
            // 
            this.Z_input.Location = new System.Drawing.Point(533, 148);
            this.Z_input.Name = "Z_input";
            this.Z_input.Size = new System.Drawing.Size(100, 20);
            this.Z_input.TabIndex = 6;
            this.Z_input.Text = "5";
            this.Z_input.TextChanged += new System.EventHandler(this.Z_input_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 527);
            this.Controls.Add(this.Z_input);
            this.Controls.Add(this.C_input);
            this.Controls.Add(this.A_input);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox A_input;
        private System.Windows.Forms.TextBox C_input;
        private System.Windows.Forms.TextBox Z_input;
    }
}

