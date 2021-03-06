
namespace MDIPaint
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерХолстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слеваНаправоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сверхуВнизToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упорядочитьЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.желтыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фиолетовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.черныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.другойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Minus_Scale = new System.Windows.Forms.Button();
            this.Plus_Scale = new System.Windows.Forms.Button();
            this.Brush = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Star = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисунокToolStripMenuItem,
            this.окноToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1287, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("файлToolStripMenuItem.Image")));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("новыйToolStripMenuItem.Image")));
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.новыйToolStripMenuItem.Text = "&Создать";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьКакToolStripMenuItem.Image")));
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.выходToolStripMenuItem.Text = "&Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерХолстаToolStripMenuItem});
            this.рисунокToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("рисунокToolStripMenuItem.Image")));
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.рисунокToolStripMenuItem.Text = "&Рисунок";
            this.рисунокToolStripMenuItem.MouseEnter += new System.EventHandler(this.рисунокToolStripMenuItem_MouseEnter);
            // 
            // размерХолстаToolStripMenuItem
            // 
            this.размерХолстаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("размерХолстаToolStripMenuItem.Image")));
            this.размерХолстаToolStripMenuItem.Name = "размерХолстаToolStripMenuItem";
            this.размерХолстаToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.размерХолстаToolStripMenuItem.Text = "Размер холста...";
            this.размерХолстаToolStripMenuItem.Click += new System.EventHandler(this.размерХолстаToolStripMenuItem_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.слеваНаправоToolStripMenuItem,
            this.сверхуВнизToolStripMenuItem,
            this.упорядочитьЗначкиToolStripMenuItem});
            this.окноToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("окноToolStripMenuItem.Image")));
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.окноToolStripMenuItem.Text = "&Окно";
            this.окноToolStripMenuItem.MouseEnter += new System.EventHandler(this.окноToolStripMenuItem_MouseEnter);
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.каскадомToolStripMenuItem_Click);
            // 
            // слеваНаправоToolStripMenuItem
            // 
            this.слеваНаправоToolStripMenuItem.Name = "слеваНаправоToolStripMenuItem";
            this.слеваНаправоToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.слеваНаправоToolStripMenuItem.Text = "Слева направо";
            this.слеваНаправоToolStripMenuItem.Click += new System.EventHandler(this.слеваНаправоToolStripMenuItem_Click);
            // 
            // сверхуВнизToolStripMenuItem
            // 
            this.сверхуВнизToolStripMenuItem.Name = "сверхуВнизToolStripMenuItem";
            this.сверхуВнизToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.сверхуВнизToolStripMenuItem.Text = "Сверху вниз";
            this.сверхуВнизToolStripMenuItem.Click += new System.EventHandler(this.сверхуВнизToolStripMenuItem_Click);
            // 
            // упорядочитьЗначкиToolStripMenuItem
            // 
            this.упорядочитьЗначкиToolStripMenuItem.Name = "упорядочитьЗначкиToolStripMenuItem";
            this.упорядочитьЗначкиToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.упорядочитьЗначкиToolStripMenuItem.Text = "Упорядочить значки";
            this.упорядочитьЗначкиToolStripMenuItem.Click += new System.EventHandler(this.упорядочитьЗначкиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripMenuItem.Image")));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.справкаToolStripMenuItem.Text = "&Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1287, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(115, 22);
            this.toolStripLabel1.Text = "Выбрать цвет кисти";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зеленыйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.желтыйToolStripMenuItem,
            this.красныйToolStripMenuItem,
            this.фиолетовыйToolStripMenuItem,
            this.черныйToolStripMenuItem,
            this.другойToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("зеленыйToolStripMenuItem.Image")));
            this.зеленыйToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Lime;
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.зеленыйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("синийToolStripMenuItem.Image")));
            this.синийToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Blue;
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // желтыйToolStripMenuItem
            // 
            this.желтыйToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("желтыйToolStripMenuItem.Image")));
            this.желтыйToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Yellow;
            this.желтыйToolStripMenuItem.Name = "желтыйToolStripMenuItem";
            this.желтыйToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.желтыйToolStripMenuItem.Text = "Желтый";
            this.желтыйToolStripMenuItem.Click += new System.EventHandler(this.желтыйToolStripMenuItem_Click);
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("красныйToolStripMenuItem.Image")));
            this.красныйToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Red;
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.красныйToolStripMenuItem_Click);
            // 
            // фиолетовыйToolStripMenuItem
            // 
            this.фиолетовыйToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("фиолетовыйToolStripMenuItem.Image")));
            this.фиолетовыйToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.фиолетовыйToolStripMenuItem.Name = "фиолетовыйToolStripMenuItem";
            this.фиолетовыйToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.фиолетовыйToolStripMenuItem.Text = "Фиолетовый";
            this.фиолетовыйToolStripMenuItem.Click += new System.EventHandler(this.фиолетовыйToolStripMenuItem_Click);
            // 
            // черныйToolStripMenuItem
            // 
            this.черныйToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("черныйToolStripMenuItem.Image")));
            this.черныйToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.черныйToolStripMenuItem.Name = "черныйToolStripMenuItem";
            this.черныйToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.черныйToolStripMenuItem.Text = "Черный";
            this.черныйToolStripMenuItem.Click += new System.EventHandler(this.черныйToolStripMenuItem_Click);
            // 
            // другойToolStripMenuItem
            // 
            this.другойToolStripMenuItem.Name = "другойToolStripMenuItem";
            this.другойToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.другойToolStripMenuItem.Text = "Другой...";
            this.другойToolStripMenuItem.Click += new System.EventHandler(this.другойToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(84, 22);
            this.toolStripLabel2.Text = "Размер кисти:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 635);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1287, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(244, 27);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(909, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Масштаб";
            // 
            // Minus_Scale
            // 
            this.Minus_Scale.BackColor = System.Drawing.SystemColors.Window;
            this.Minus_Scale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus_Scale.ForeColor = System.Drawing.SystemColors.Window;
            this.Minus_Scale.Image = ((System.Drawing.Image)(resources.GetObject("Minus_Scale.Image")));
            this.Minus_Scale.Location = new System.Drawing.Point(1016, 18);
            this.Minus_Scale.Name = "Minus_Scale";
            this.Minus_Scale.Size = new System.Drawing.Size(41, 29);
            this.Minus_Scale.TabIndex = 10;
            this.Minus_Scale.UseVisualStyleBackColor = false;
            this.Minus_Scale.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Plus_Scale
            // 
            this.Plus_Scale.BackColor = System.Drawing.SystemColors.Window;
            this.Plus_Scale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Plus_Scale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus_Scale.ForeColor = System.Drawing.SystemColors.Window;
            this.Plus_Scale.Image = ((System.Drawing.Image)(resources.GetObject("Plus_Scale.Image")));
            this.Plus_Scale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Plus_Scale.Location = new System.Drawing.Point(968, 18);
            this.Plus_Scale.Name = "Plus_Scale";
            this.Plus_Scale.Size = new System.Drawing.Size(42, 31);
            this.Plus_Scale.TabIndex = 11;
            this.Plus_Scale.UseVisualStyleBackColor = false;
            this.Plus_Scale.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Brush
            // 
            this.Brush.Location = new System.Drawing.Point(473, 24);
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(75, 23);
            this.Brush.TabIndex = 13;
            this.Brush.Text = "Перо";
            this.Brush.UseVisualStyleBackColor = true;
            this.Brush.Click += new System.EventHandler(this.Brush_Click);
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(569, 24);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(75, 23);
            this.Line.TabIndex = 14;
            this.Line.Text = "Линия";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(664, 24);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(75, 23);
            this.Ellipse.TabIndex = 15;
            this.Ellipse.Text = "Эллипс";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Star
            // 
            this.Star.Location = new System.Drawing.Point(761, 24);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(75, 23);
            this.Star.TabIndex = 16;
            this.Star.Text = "Звезда";
            this.Star.UseVisualStyleBackColor = true;
            this.Star.Click += new System.EventHandler(this.Star_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1287, 657);
            this.Controls.Add(this.Star);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Brush);
            this.Controls.Add(this.Plus_Scale);
            this.Controls.Add(this.Minus_Scale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MyPaint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерХолстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слеваНаправоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сверхуВнизToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упорядочитьЗначкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem желтыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фиолетовыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem черныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другойToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Minus_Scale;
        private System.Windows.Forms.Button Plus_Scale;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button Brush;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Star;
    }
}

