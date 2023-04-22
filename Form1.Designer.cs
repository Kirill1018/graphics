namespace graph
{
    partial class Graph_edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph_edit));
            this.dialog = new System.Windows.Forms.OpenFileDialog();
            this.filedialog = new System.Windows.Forms.SaveFileDialog();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.кистиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.узкаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средняяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.большаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip_split_butt = new System.Windows.Forms.ToolStripSplitButton();
            this.прямоугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_strip = new System.Windows.Forms.ToolStrip();
            this.strip_split_butt = new System.Windows.Forms.ToolStripSplitButton();
            this.лазурьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индийскийКрасныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip.SuspendLayout();
            this.tool_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialog
            // 
            this.dialog.FileName = "openFileDialog1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click_1);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // menu_strip
            // 
            this.menu_strip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.кистиToolStripMenuItem});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Size = new System.Drawing.Size(800, 24);
            this.menu_strip.TabIndex = 2;
            this.menu_strip.Text = "menuStrip1";
            // 
            // кистиToolStripMenuItem
            // 
            this.кистиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.узкаяToolStripMenuItem,
            this.средняяToolStripMenuItem,
            this.большаяToolStripMenuItem});
            this.кистиToolStripMenuItem.Name = "кистиToolStripMenuItem";
            this.кистиToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.кистиToolStripMenuItem.Text = "кисти";
            // 
            // узкаяToolStripMenuItem
            // 
            this.узкаяToolStripMenuItem.Name = "узкаяToolStripMenuItem";
            this.узкаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.узкаяToolStripMenuItem.Text = "узкая";
            this.узкаяToolStripMenuItem.Click += new System.EventHandler(this.узкаяToolStripMenuItem_Click);
            // 
            // средняяToolStripMenuItem
            // 
            this.средняяToolStripMenuItem.Name = "средняяToolStripMenuItem";
            this.средняяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.средняяToolStripMenuItem.Text = "средняя";
            this.средняяToolStripMenuItem.Click += new System.EventHandler(this.средняяToolStripMenuItem_Click);
            // 
            // большаяToolStripMenuItem
            // 
            this.большаяToolStripMenuItem.Name = "большаяToolStripMenuItem";
            this.большаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.большаяToolStripMenuItem.Text = "большая";
            this.большаяToolStripMenuItem.Click += new System.EventHandler(this.большаяToolStripMenuItem_Click);
            // 
            // tool_strip_split_butt
            // 
            this.tool_strip_split_butt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tool_strip_split_butt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_strip_split_butt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прямоугольникToolStripMenuItem,
            this.точкаToolStripMenuItem});
            this.tool_strip_split_butt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tool_strip_split_butt.Image = global::graph.Properties.Resources.graphics_editor63_41882;
            this.tool_strip_split_butt.ImageTransparentColor = System.Drawing.Color.OrangeRed;
            this.tool_strip_split_butt.Name = "tool_strip_split_butt";
            this.tool_strip_split_butt.Size = new System.Drawing.Size(32, 22);
            this.tool_strip_split_butt.Text = "toolStripSplitButton1";
            // 
            // прямоугольникToolStripMenuItem
            // 
            this.прямоугольникToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.прямоугольникToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            this.прямоугольникToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.прямоугольникToolStripMenuItem.Text = "прямоугольник";
            this.прямоугольникToolStripMenuItem.Click += new System.EventHandler(this.прямоугольникToolStripMenuItem_Click);
            // 
            // точкаToolStripMenuItem
            // 
            this.точкаToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.точкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.точкаToolStripMenuItem.Name = "точкаToolStripMenuItem";
            this.точкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.точкаToolStripMenuItem.Text = "точка";
            this.точкаToolStripMenuItem.Click += new System.EventHandler(this.точкаToolStripMenuItem_Click);
            // 
            // tool_strip
            // 
            this.tool_strip.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tool_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_strip_split_butt,
            this.strip_split_butt});
            this.tool_strip.Location = new System.Drawing.Point(0, 24);
            this.tool_strip.Name = "tool_strip";
            this.tool_strip.Size = new System.Drawing.Size(800, 25);
            this.tool_strip.TabIndex = 3;
            this.tool_strip.Text = "toolStrip1";
            // 
            // strip_split_butt
            // 
            this.strip_split_butt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.strip_split_butt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.strip_split_butt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лазурьToolStripMenuItem,
            this.индийскийКрасныйToolStripMenuItem});
            this.strip_split_butt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.strip_split_butt.Image = global::graph.Properties.Resources.graphics_editor66_41916;
            this.strip_split_butt.ImageTransparentColor = System.Drawing.Color.AntiqueWhite;
            this.strip_split_butt.Name = "strip_split_butt";
            this.strip_split_butt.Size = new System.Drawing.Size(32, 22);
            this.strip_split_butt.Text = "toolStripSplitButton2";
            // 
            // лазурьToolStripMenuItem
            // 
            this.лазурьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.лазурьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.лазурьToolStripMenuItem.Name = "лазурьToolStripMenuItem";
            this.лазурьToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.лазурьToolStripMenuItem.Text = "лазурь";
            this.лазурьToolStripMenuItem.Click += new System.EventHandler(this.лазурьToolStripMenuItem_Click);
            // 
            // индийскийКрасныйToolStripMenuItem
            // 
            this.индийскийКрасныйToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.индийскийКрасныйToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.индийскийКрасныйToolStripMenuItem.Name = "индийскийКрасныйToolStripMenuItem";
            this.индийскийКрасныйToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.индийскийКрасныйToolStripMenuItem.Text = "индийский красный";
            this.индийскийКрасныйToolStripMenuItem.Click += new System.EventHandler(this.индийскийКрасныйToolStripMenuItem_Click);
            // 
            // Graph_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tool_strip);
            this.Controls.Add(this.menu_strip);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graph_edit";
            this.Text = "графический редактор";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.graph_edit_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graph_edit_MouseClick);
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            this.tool_strip.ResumeLayout(false);
            this.tool_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog dialog;
        private System.Windows.Forms.SaveFileDialog filedialog;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu_strip;
        private System.Windows.Forms.ToolStripMenuItem кистиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem узкаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средняяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem большаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tool_strip_split_butt;
        private System.Windows.Forms.ToolStripMenuItem прямоугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точкаToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tool_strip;
        private System.Windows.Forms.ToolStripSplitButton strip_split_butt;
        private System.Windows.Forms.ToolStripMenuItem лазурьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индийскийКрасныйToolStripMenuItem;
    }
}

