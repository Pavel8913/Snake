namespace Змейка
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.легкоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тяжелоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветоваяСхемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.холодныеЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тёплыеЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чёрнобелыеЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.сложностьToolStripMenuItem,
            this.цветоваяСхемаToolStripMenuItem,
            this.правилаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьToolStripMenuItem,
            this.паузаToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.играToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_контроллер_30;
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // начатьToolStripMenuItem
            // 
            this.начатьToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_воспроизведение_30;
            this.начатьToolStripMenuItem.Name = "начатьToolStripMenuItem";
            this.начатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.начатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.начатьToolStripMenuItem.Text = "Начать";
            this.начатьToolStripMenuItem.Click += new System.EventHandler(this.начатьToolStripMenuItem_Click);
            // 
            // паузаToolStripMenuItem
            // 
            this.паузаToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_пауза_в_кружке_30;
            this.паузаToolStripMenuItem.Name = "паузаToolStripMenuItem";
            this.паузаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.паузаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.паузаToolStripMenuItem.Text = "Пауза";
            this.паузаToolStripMenuItem.Click += new System.EventHandler(this.паузаToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_macos_закрыть_30;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // сложностьToolStripMenuItem
            // 
            this.сложностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.легкоToolStripMenuItem,
            this.среднеToolStripMenuItem,
            this.тяжелоToolStripMenuItem});
            this.сложностьToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_производительность_32;
            this.сложностьToolStripMenuItem.Name = "сложностьToolStripMenuItem";
            this.сложностьToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.сложностьToolStripMenuItem.Text = "Сложность";
            // 
            // легкоToolStripMenuItem
            // 
            this.легкоToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_черепаха_30;
            this.легкоToolStripMenuItem.Name = "легкоToolStripMenuItem";
            this.легкоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.легкоToolStripMenuItem.Text = "Легко";
            this.легкоToolStripMenuItem.Click += new System.EventHandler(this.легкоToolStripMenuItem_Click);
            // 
            // среднеToolStripMenuItem
            // 
            this.среднеToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_кролик_30;
            this.среднеToolStripMenuItem.Name = "среднеToolStripMenuItem";
            this.среднеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.среднеToolStripMenuItem.Text = "Средне";
            this.среднеToolStripMenuItem.Click += new System.EventHandler(this.среднеToolStripMenuItem_Click);
            // 
            // тяжелоToolStripMenuItem
            // 
            this.тяжелоToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_собака_прыгает_30;
            this.тяжелоToolStripMenuItem.Name = "тяжелоToolStripMenuItem";
            this.тяжелоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тяжелоToolStripMenuItem.Text = "Тяжело";
            this.тяжелоToolStripMenuItem.Click += new System.EventHandler(this.тяжелоToolStripMenuItem_Click);
            // 
            // цветоваяСхемаToolStripMenuItem
            // 
            this.цветоваяСхемаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.холодныеЦветаToolStripMenuItem,
            this.тёплыеЦветаToolStripMenuItem,
            this.чёрнобелыеЦветаToolStripMenuItem});
            this.цветоваяСхемаToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_выбор_цвета_48;
            this.цветоваяСхемаToolStripMenuItem.Name = "цветоваяСхемаToolStripMenuItem";
            this.цветоваяСхемаToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.цветоваяСхемаToolStripMenuItem.Text = "Цветовая схема";
            // 
            // холодныеЦветаToolStripMenuItem
            // 
            this.холодныеЦветаToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_пипетка_64;
            this.холодныеЦветаToolStripMenuItem.Name = "холодныеЦветаToolStripMenuItem";
            this.холодныеЦветаToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.холодныеЦветаToolStripMenuItem.Text = "Холодные цвета";
            this.холодныеЦветаToolStripMenuItem.Click += new System.EventHandler(this.холодныеЦветаToolStripMenuItem_Click);
            // 
            // тёплыеЦветаToolStripMenuItem
            // 
            this.тёплыеЦветаToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_пипетка_64__1_;
            this.тёплыеЦветаToolStripMenuItem.Name = "тёплыеЦветаToolStripMenuItem";
            this.тёплыеЦветаToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.тёплыеЦветаToolStripMenuItem.Text = "Тёплые цвета";
            this.тёплыеЦветаToolStripMenuItem.Click += new System.EventHandler(this.тёплыеЦветаToolStripMenuItem_Click);
            // 
            // чёрнобелыеЦветаToolStripMenuItem
            // 
            this.чёрнобелыеЦветаToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_пипетка_64__2_;
            this.чёрнобелыеЦветаToolStripMenuItem.Name = "чёрнобелыеЦветаToolStripMenuItem";
            this.чёрнобелыеЦветаToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.чёрнобелыеЦветаToolStripMenuItem.Text = "Чёрно-белые цвета";
            this.чёрнобелыеЦветаToolStripMenuItem.Click += new System.EventHandler(this.чёрнобелыеЦветаToolStripMenuItem_Click);
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.Image = global::Змейка.Properties.Resources.icons8_задать_вопрос_30;
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.правилаToolStripMenuItem.Text = "Правила";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.правилаToolStripMenuItem_Click);
            // 
            // game_timer
            // 
            this.game_timer.Interval = 200;
            this.game_timer.Tick += new System.EventHandler(this.game_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 357);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Змейка";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паузаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem легкоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тяжелоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветоваяСхемаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem холодныеЦветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тёплыеЦветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чёрнобелыеЦветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.Timer game_timer;
    }
}

