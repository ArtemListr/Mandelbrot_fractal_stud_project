
namespace Fractal_listr
{
    partial class Fractal_form
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
            this.components = new System.ComponentModel.Container();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.bt_Restart = new System.Windows.Forms.Button();
            this.bt_savepic = new System.Windows.Forms.Button();
            this.tb_rules = new System.Windows.Forms.TextBox();
            this.gb_animation = new System.Windows.Forms.GroupBox();
            this.rb_iteration = new System.Windows.Forms.RadioButton();
            this.rb_deep = new System.Windows.Forms.RadioButton();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_loadparam = new System.Windows.Forms.Button();
            this.StatStrip = new System.Windows.Forms.StatusStrip();
            this.tssl_Cursor = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_size = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.bt_saveparam = new System.Windows.Forms.Button();
            this.gr_Draw = new System.Windows.Forms.GroupBox();
            this.l_Zoom = new System.Windows.Forms.Label();
            this.nudZoom = new System.Windows.Forms.NumericUpDown();
            this.l_iter = new System.Windows.Forms.Label();
            this.l_Size = new System.Windows.Forms.Label();
            this.nudIter = new System.Windows.Forms.NumericUpDown();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.gr_Coord = new System.Windows.Forms.GroupBox();
            this.l_Y = new System.Windows.Forms.Label();
            this.l_X = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.sfd_image = new System.Windows.Forms.SaveFileDialog();
            this.sfd_param = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ofd_param = new System.Windows.Forms.OpenFileDialog();
            this.ofd_image = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.panel_main.SuspendLayout();
            this.gb_animation.SuspendLayout();
            this.StatStrip.SuspendLayout();
            this.gr_Draw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.gr_Coord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbox.Location = new System.Drawing.Point(0, 0);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(913, 673);
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            this.picbox.Paint += new System.Windows.Forms.PaintEventHandler(this.picbox_Paint);
            this.picbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picbox_MouseDoubleClick);
            this.picbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbox_MouseDown);
            this.picbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbox_MouseMove);
            this.picbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbox_MouseUp);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.bt_Restart);
            this.panel_main.Controls.Add(this.bt_savepic);
            this.panel_main.Controls.Add(this.tb_rules);
            this.panel_main.Controls.Add(this.gb_animation);
            this.panel_main.Controls.Add(this.bt_loadparam);
            this.panel_main.Controls.Add(this.StatStrip);
            this.panel_main.Controls.Add(this.bt_saveparam);
            this.panel_main.Controls.Add(this.gr_Draw);
            this.panel_main.Controls.Add(this.gr_Coord);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_main.Location = new System.Drawing.Point(913, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(349, 673);
            this.panel_main.TabIndex = 1;
            // 
            // bt_Restart
            // 
            this.bt_Restart.Location = new System.Drawing.Point(228, 177);
            this.bt_Restart.Name = "bt_Restart";
            this.bt_Restart.Size = new System.Drawing.Size(116, 68);
            this.bt_Restart.TabIndex = 13;
            this.bt_Restart.Text = "Сброс до изначальных параметров";
            this.bt_Restart.UseVisualStyleBackColor = true;
            this.bt_Restart.Click += new System.EventHandler(this.bt_Restart_Click);
            // 
            // bt_savepic
            // 
            this.bt_savepic.Location = new System.Drawing.Point(228, 326);
            this.bt_savepic.Name = "bt_savepic";
            this.bt_savepic.Size = new System.Drawing.Size(116, 59);
            this.bt_savepic.TabIndex = 12;
            this.bt_savepic.Text = "Сохранить картинку";
            this.bt_savepic.UseVisualStyleBackColor = true;
            this.bt_savepic.Click += new System.EventHandler(this.bt_savepic_Click);
            // 
            // tb_rules
            // 
            this.tb_rules.Location = new System.Drawing.Point(178, 406);
            this.tb_rules.Multiline = true;
            this.tb_rules.Name = "tb_rules";
            this.tb_rules.Size = new System.Drawing.Size(144, 227);
            this.tb_rules.TabIndex = 11;
            this.tb_rules.Text = ">Двойной щелчок ЛКМ - увеличение масштаба\r\n>Двойной щелчок ПКМ - уменьшение масшт" +
    "аба\r\n>Зажать и отпустить ЛКМ - перемещение по картинке";
            // 
            // gb_animation
            // 
            this.gb_animation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gb_animation.Controls.Add(this.rb_iteration);
            this.gb_animation.Controls.Add(this.rb_deep);
            this.gb_animation.Controls.Add(this.bt_start);
            this.gb_animation.Controls.Add(this.bt_stop);
            this.gb_animation.Location = new System.Drawing.Point(26, 423);
            this.gb_animation.Name = "gb_animation";
            this.gb_animation.Size = new System.Drawing.Size(144, 210);
            this.gb_animation.TabIndex = 10;
            this.gb_animation.TabStop = false;
            this.gb_animation.Text = "Анимация";
            // 
            // rb_iteration
            // 
            this.rb_iteration.AutoSize = true;
            this.rb_iteration.Checked = true;
            this.rb_iteration.Location = new System.Drawing.Point(6, 65);
            this.rb_iteration.Name = "rb_iteration";
            this.rb_iteration.Size = new System.Drawing.Size(121, 24);
            this.rb_iteration.TabIndex = 1;
            this.rb_iteration.TabStop = true;
            this.rb_iteration.Text = "По итерации";
            this.rb_iteration.UseVisualStyleBackColor = true;
            // 
            // rb_deep
            // 
            this.rb_deep.AutoSize = true;
            this.rb_deep.Location = new System.Drawing.Point(6, 26);
            this.rb_deep.Name = "rb_deep";
            this.rb_deep.Size = new System.Drawing.Size(140, 24);
            this.rb_deep.TabIndex = 0;
            this.rb_deep.Text = "По увеличению";
            this.rb_deep.UseVisualStyleBackColor = true;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(6, 114);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(94, 29);
            this.bt_start.TabIndex = 5;
            this.bt_start.Text = "Старт";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(6, 160);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(94, 29);
            this.bt_stop.TabIndex = 6;
            this.bt_stop.Text = "Стоп";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_loadparam
            // 
            this.bt_loadparam.Location = new System.Drawing.Point(228, 110);
            this.bt_loadparam.Name = "bt_loadparam";
            this.bt_loadparam.Size = new System.Drawing.Size(116, 48);
            this.bt_loadparam.TabIndex = 7;
            this.bt_loadparam.Text = "Загрузить параметры";
            this.bt_loadparam.UseVisualStyleBackColor = true;
            this.bt_loadparam.Click += new System.EventHandler(this.bt_loadparam_Click);
            // 
            // StatStrip
            // 
            this.StatStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Cursor,
            this.tssl_size,
            this.tssl_status});
            this.StatStrip.Location = new System.Drawing.Point(0, 645);
            this.StatStrip.Name = "StatStrip";
            this.StatStrip.Size = new System.Drawing.Size(347, 26);
            this.StatStrip.TabIndex = 4;
            this.StatStrip.Text = "statusStrip1";
            // 
            // tssl_Cursor
            // 
            this.tssl_Cursor.Name = "tssl_Cursor";
            this.tssl_Cursor.Size = new System.Drawing.Size(59, 20);
            this.tssl_Cursor.Text = "Курсор";
            // 
            // tssl_size
            // 
            this.tssl_size.Name = "tssl_size";
            this.tssl_size.Size = new System.Drawing.Size(122, 20);
            this.tssl_size.Text = "Размер полотна";
            // 
            // tssl_status
            // 
            this.tssl_status.Name = "tssl_status";
            this.tssl_status.Size = new System.Drawing.Size(71, 20);
            this.tssl_status.Text = "Работает";
            // 
            // bt_saveparam
            // 
            this.bt_saveparam.Location = new System.Drawing.Point(228, 46);
            this.bt_saveparam.Name = "bt_saveparam";
            this.bt_saveparam.Size = new System.Drawing.Size(116, 48);
            this.bt_saveparam.TabIndex = 3;
            this.bt_saveparam.Text = "Сохранить параметры";
            this.bt_saveparam.UseVisualStyleBackColor = true;
            this.bt_saveparam.Click += new System.EventHandler(this.bt_saveparam_Click);
            // 
            // gr_Draw
            // 
            this.gr_Draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gr_Draw.Controls.Add(this.l_Zoom);
            this.gr_Draw.Controls.Add(this.nudZoom);
            this.gr_Draw.Controls.Add(this.l_iter);
            this.gr_Draw.Controls.Add(this.l_Size);
            this.gr_Draw.Controls.Add(this.nudIter);
            this.gr_Draw.Controls.Add(this.nudSize);
            this.gr_Draw.Location = new System.Drawing.Point(26, 177);
            this.gr_Draw.Name = "gr_Draw";
            this.gr_Draw.Size = new System.Drawing.Size(196, 223);
            this.gr_Draw.TabIndex = 1;
            this.gr_Draw.TabStop = false;
            this.gr_Draw.Text = "Рисование";
            // 
            // l_Zoom
            // 
            this.l_Zoom.AutoSize = true;
            this.l_Zoom.Location = new System.Drawing.Point(6, 158);
            this.l_Zoom.Name = "l_Zoom";
            this.l_Zoom.Size = new System.Drawing.Size(169, 20);
            this.l_Zoom.TabIndex = 5;
            this.l_Zoom.Text = "Кратность увеличения:";
            // 
            // nudZoom
            // 
            this.nudZoom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudZoom.Location = new System.Drawing.Point(14, 181);
            this.nudZoom.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.nudZoom.Name = "nudZoom";
            this.nudZoom.Size = new System.Drawing.Size(150, 27);
            this.nudZoom.TabIndex = 4;
            this.nudZoom.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // l_iter
            // 
            this.l_iter.AutoSize = true;
            this.l_iter.Location = new System.Drawing.Point(6, 93);
            this.l_iter.Name = "l_iter";
            this.l_iter.Size = new System.Drawing.Size(164, 20);
            this.l_iter.TabIndex = 3;
            this.l_iter.Text = "Количество итераций:";
            // 
            // l_Size
            // 
            this.l_Size.AutoSize = true;
            this.l_Size.Location = new System.Drawing.Point(6, 28);
            this.l_Size.Name = "l_Size";
            this.l_Size.Size = new System.Drawing.Size(74, 20);
            this.l_Size.TabIndex = 2;
            this.l_Size.Text = "Размеры:";
            // 
            // nudIter
            // 
            this.nudIter.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudIter.Location = new System.Drawing.Point(14, 116);
            this.nudIter.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudIter.Name = "nudIter";
            this.nudIter.Size = new System.Drawing.Size(150, 27);
            this.nudIter.TabIndex = 2;
            this.nudIter.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nudIter.ValueChanged += new System.EventHandler(this.nudIter_ValueChanged);
            // 
            // nudSize
            // 
            this.nudSize.DecimalPlaces = 8;
            this.nudSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            this.nudSize.Location = new System.Drawing.Point(14, 51);
            this.nudSize.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1048576});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(150, 27);
            this.nudSize.TabIndex = 2;
            this.nudSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // gr_Coord
            // 
            this.gr_Coord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gr_Coord.Controls.Add(this.l_Y);
            this.gr_Coord.Controls.Add(this.l_X);
            this.gr_Coord.Controls.Add(this.nudY);
            this.gr_Coord.Controls.Add(this.nudX);
            this.gr_Coord.Location = new System.Drawing.Point(26, 46);
            this.gr_Coord.Name = "gr_Coord";
            this.gr_Coord.Size = new System.Drawing.Size(196, 112);
            this.gr_Coord.TabIndex = 0;
            this.gr_Coord.TabStop = false;
            this.gr_Coord.Text = "Координаты";
            // 
            // l_Y
            // 
            this.l_Y.AutoSize = true;
            this.l_Y.Location = new System.Drawing.Point(15, 72);
            this.l_Y.Name = "l_Y";
            this.l_Y.Size = new System.Drawing.Size(20, 20);
            this.l_Y.TabIndex = 2;
            this.l_Y.Text = "Y:";
            // 
            // l_X
            // 
            this.l_X.AutoSize = true;
            this.l_X.Location = new System.Drawing.Point(14, 33);
            this.l_X.Name = "l_X";
            this.l_X.Size = new System.Drawing.Size(21, 20);
            this.l_X.TabIndex = 2;
            this.l_X.Text = "X:";
            // 
            // nudY
            // 
            this.nudY.DecimalPlaces = 8;
            this.nudY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudY.Location = new System.Drawing.Point(41, 70);
            this.nudY.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(150, 27);
            this.nudY.TabIndex = 2;
            this.nudY.Value = new decimal(new int[] {
            200000000,
            0,
            0,
            -2146959360});
            // 
            // nudX
            // 
            this.nudX.DecimalPlaces = 8;
            this.nudX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudX.Location = new System.Drawing.Point(41, 31);
            this.nudX.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(150, 27);
            this.nudX.TabIndex = 2;
            this.nudX.Value = new decimal(new int[] {
            200000000,
            0,
            0,
            -2146959360});
            // 
            // sfd_image
            // 
            this.sfd_image.FileName = "Fractal_image";
            this.sfd_image.Filter = "Файл \"PNG\"(*.png)|*.png| Файл \"JPEG\"(*jpg)|*.jpg| Файл \"BMP\"(*bmp)|*.bmp";
            // 
            // sfd_param
            // 
            this.sfd_param.FileName = "Fractal_Points.txt";
            this.sfd_param.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ofd_param
            // 
            this.ofd_param.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // ofd_image
            // 
            this.ofd_image.FileName = "openFileDialog1";
            // 
            // Fractal_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.panel_main);
            this.Name = "Fractal_form";
            this.Text = "Множество Мандельброта";
            this.Resize += new System.EventHandler(this.Fractal_form_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.gb_animation.ResumeLayout(false);
            this.gb_animation.PerformLayout();
            this.StatStrip.ResumeLayout(false);
            this.StatStrip.PerformLayout();
            this.gr_Draw.ResumeLayout(false);
            this.gr_Draw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.gr_Coord.ResumeLayout(false);
            this.gr_Coord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.GroupBox gr_Draw;
        private System.Windows.Forms.Label l_iter;
        private System.Windows.Forms.Label l_Size;
        private System.Windows.Forms.NumericUpDown nudIter;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.GroupBox gr_Coord;
        private System.Windows.Forms.Label l_Y;
        private System.Windows.Forms.Label l_X;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.SaveFileDialog sfd_image;
        private System.Windows.Forms.Button bt_saveparam;
        private System.Windows.Forms.SaveFileDialog sfd_param;
        private System.Windows.Forms.StatusStrip StatStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Cursor;
        private System.Windows.Forms.ToolStripStatusLabel tssl_size;
        private System.Windows.Forms.Label l_Zoom;
        private System.Windows.Forms.NumericUpDown nudZoom;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_loadparam;
        private System.Windows.Forms.OpenFileDialog ofd_param;
        private System.Windows.Forms.OpenFileDialog ofd_image;
        private System.Windows.Forms.TextBox tb_rules;
        private System.Windows.Forms.GroupBox gb_animation;
        private System.Windows.Forms.RadioButton rb_iteration;
        private System.Windows.Forms.RadioButton rb_deep;
        private System.Windows.Forms.Button bt_savepic;
        private System.Windows.Forms.ToolStripStatusLabel tssl_status;
        private System.Windows.Forms.Button bt_Restart;
    }
}

