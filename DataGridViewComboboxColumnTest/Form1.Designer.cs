namespace DataGridViewComboboxColumnTest
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_User = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_User
            // 
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User.Location = new System.Drawing.Point(12, 42);
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.RowTemplate.Height = 23;
            this.dgv_User.Size = new System.Drawing.Size(654, 292);
            this.dgv_User.TabIndex = 0;
            this.dgv_User.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_User_CellBeginEdit);
            this.dgv_User.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_User_CellEndEdit);
            this.dgv_User.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_User_CellEnter);
            this.dgv_User.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_User_CellLeave);
            this.dgv_User.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_User_CellValidated);
            this.dgv_User.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_User_CellValidating);
            this.dgv_User.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgv_User_CellValueNeeded);
            this.dgv_User.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgv_User_CellValuePushed);
            this.dgv_User.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgv_User_ColumnWidthChanged);
            this.dgv_User.CurrentCellChanged += new System.EventHandler(this.dgv_User_CurrentCellChanged);
            this.dgv_User.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_User_DataBindingComplete);
            this.dgv_User.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgv_User_RowHeightChanged);
            this.dgv_User.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_User_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.addToolStripMenuItem.Text = "add";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.deleteToolStripMenuItem.Text = "delete";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 395);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 35);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Validated += new System.EventHandler(this.comboBox1_Validated);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 451);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgv_User);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_User;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

