namespace Notebook
{
    partial class frmNotepad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ismiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.页面设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNotepad = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.Null = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbCut = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFont = new System.Windows.Forms.ToolStripButton();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.rtxtNotepad = new System.Windows.Forms.RichTextBox();
            this.stsBook = new System.Windows.Forms.StatusStrip();
            this.tssLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLbl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.odlgNotepad = new System.Windows.Forms.OpenFileDialog();
            this.sdlgNotepad = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fdlgNotepad = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.tlsNotepad.SuspendLayout();
            this.stsBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ismiFile,
            this.tsmiEdit,
            this.tsmiFormat,
            this.tsmiView,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ismiFile
            // 
            this.ismiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.toolStripSeparator1,
            this.页面设置ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.toolStripSeparator2,
            this.tsmiClose});
            this.ismiFile.Name = "ismiFile";
            this.ismiFile.ShowShortcutKeys = false;
            this.ismiFile.Size = new System.Drawing.Size(58, 21);
            this.ismiFile.Text = "文件(&F)";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(168, 22);
            this.tsmiNew.Text = "新建(&N)";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(168, 22);
            this.tsmiOpen.Text = "打开(&O)";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(168, 22);
            this.tsmiSave.Text = "保存(&S)";
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.ShowShortcutKeys = false;
            this.tsmiSaveAs.Size = new System.Drawing.Size(168, 22);
            this.tsmiSaveAs.Text = "另存为(&A)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // 页面设置ToolStripMenuItem
            // 
            this.页面设置ToolStripMenuItem.Name = "页面设置ToolStripMenuItem";
            this.页面设置ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.页面设置ToolStripMenuItem.Text = "页面设置(未开发)";
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.打印ToolStripMenuItem.Text = "打印(未开发)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.ShowShortcutKeys = false;
            this.tsmiClose.Size = new System.Drawing.Size(168, 22);
            this.tsmiClose.Text = "退出(&X)";
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.toolStripSeparator3,
            this.撤销ToolStripMenuItem,
            this.tsmiCopy,
            this.tsmiCut,
            this.tsmiPaste,
            this.toolStripSeparator4,
            this.tsmiSelectAll,
            this.tsmiData});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.ShowShortcutKeys = false;
            this.tsmiEdit.Size = new System.Drawing.Size(59, 21);
            this.tsmiEdit.Text = "编辑(&E)";
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiUndo.Size = new System.Drawing.Size(161, 22);
            this.tsmiUndo.Text = "撤销(&Z)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.撤销ToolStripMenuItem.Text = "撤销";
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(161, 22);
            this.tsmiCopy.Text = "复制(&C)";
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(161, 22);
            this.tsmiCut.Text = "剪切(&X)";
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(161, 22);
            this.tsmiPaste.Text = "粘贴(&V)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiSelectAll.Size = new System.Drawing.Size(161, 22);
            this.tsmiSelectAll.Text = "全选(&A)";
            // 
            // tsmiData
            // 
            this.tsmiData.Name = "tsmiData";
            this.tsmiData.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiData.Size = new System.Drawing.Size(161, 22);
            this.tsmiData.Text = "日期(&D)";
            // 
            // tsmiFormat
            // 
            this.tsmiFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAuto,
            this.tsmiFont});
            this.tsmiFormat.Name = "tsmiFormat";
            this.tsmiFormat.Size = new System.Drawing.Size(62, 21);
            this.tsmiFormat.Text = "格式(&O)";
            // 
            // tsmAuto
            // 
            this.tsmAuto.Checked = true;
            this.tsmAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmAuto.Name = "tsmAuto";
            this.tsmAuto.Size = new System.Drawing.Size(144, 22);
            this.tsmAuto.Text = "自动换行(&W)";
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(144, 22);
            this.tsmiFont.Text = "字体(&F)";
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToolStrip,
            this.tsmiStatusStrip});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(60, 21);
            this.tsmiView.Text = "查看(&V)";
            // 
            // tsmiToolStrip
            // 
            this.tsmiToolStrip.Checked = true;
            this.tsmiToolStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiToolStrip.Name = "tsmiToolStrip";
            this.tsmiToolStrip.Size = new System.Drawing.Size(127, 22);
            this.tsmiToolStrip.Text = "工具栏(&T)";
            // 
            // tsmiStatusStrip
            // 
            this.tsmiStatusStrip.Checked = true;
            this.tsmiStatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiStatusStrip.Name = "tsmiStatusStrip";
            this.tsmiStatusStrip.Size = new System.Drawing.Size(127, 22);
            this.tsmiStatusStrip.Text = "状态栏(&S)";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelp.Text = "帮助(&H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
            this.tsmiAbout.Text = "关于记事本(&A)";
            // 
            // tlsNotepad
            // 
            this.tlsNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.Null,
            this.toolStripSeparator,
            this.tsbCopy,
            this.tsbCut,
            this.tsbPaste,
            this.toolStripSeparator5,
            this.tsbFont,
            this.tsbHelp});
            this.tlsNotepad.Location = new System.Drawing.Point(0, 25);
            this.tlsNotepad.Name = "tlsNotepad";
            this.tlsNotepad.Size = new System.Drawing.Size(584, 25);
            this.tlsNotepad.TabIndex = 1;
            this.tlsNotepad.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 22);
            this.tsbNew.Text = "新建(&N)";
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbOpen.Text = "打开(&O)";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "保存(&S)";
            // 
            // Null
            // 
            this.Null.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Null.Image = ((System.Drawing.Image)(resources.GetObject("Null.Image")));
            this.Null.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Null.Name = "Null";
            this.Null.Size = new System.Drawing.Size(23, 22);
            this.Null.Text = "打印(未开发)(&P)";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCopy
            // 
            this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(23, 22);
            this.tsbCopy.Text = "剪切(&U)";
            // 
            // tsbCut
            // 
            this.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbCut.Image")));
            this.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCut.Name = "tsbCut";
            this.tsbCut.Size = new System.Drawing.Size(23, 22);
            this.tsbCut.Text = "复制(&C)";
            // 
            // tsbPaste
            // 
            this.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaste.Image")));
            this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaste.Name = "tsbPaste";
            this.tsbPaste.Size = new System.Drawing.Size(23, 22);
            this.tsbPaste.Text = "粘贴(&P)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFont
            // 
            this.tsbFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFont.Image = ((System.Drawing.Image)(resources.GetObject("tsbFont.Image")));
            this.tsbFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFont.Name = "tsbFont";
            this.tsbFont.Size = new System.Drawing.Size(23, 22);
            this.tsbFont.Text = "toolStripButton1";
            this.tsbFont.ToolTipText = "字体(F)";
            // 
            // tsbHelp
            // 
            this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(23, 22);
            this.tsbHelp.Text = "帮助(&L)";
            // 
            // rtxtNotepad
            // 
            this.rtxtNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNotepad.Location = new System.Drawing.Point(0, 53);
            this.rtxtNotepad.Name = "rtxtNotepad";
            this.rtxtNotepad.Size = new System.Drawing.Size(584, 333);
            this.rtxtNotepad.TabIndex = 2;
            this.rtxtNotepad.Text = "";
            // 
            // stsBook
            // 
            this.stsBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stsBook.Dock = System.Windows.Forms.DockStyle.None;
            this.stsBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLbl1,
            this.tssLbl2});
            this.stsBook.Location = new System.Drawing.Point(0, 389);
            this.stsBook.Name = "stsBook";
            this.stsBook.Size = new System.Drawing.Size(141, 22);
            this.stsBook.TabIndex = 3;
            this.stsBook.Text = "statusStrip1";
            // 
            // tssLbl1
            // 
            this.tssLbl1.Name = "tssLbl1";
            this.tssLbl1.Size = new System.Drawing.Size(32, 17);
            this.tssLbl1.Text = "就绪";
            this.tssLbl1.ToolTipText = "就绪";
            this.tssLbl1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tssLbl2
            // 
            this.tssLbl2.Name = "tssLbl2";
            this.tssLbl2.Size = new System.Drawing.Size(92, 17);
            this.tssLbl2.Text = "显示日期、时间";
            this.tssLbl2.ToolTipText = "显示日期、时间";
            // 
            // odlgNotepad
            // 
            this.odlgNotepad.FileName = "odlgNotepad";
            this.odlgNotepad.Filter = "RTF文件|*.rtf|所有文件|*.*";
            // 
            // sdlgNotepad
            // 
            this.sdlgNotepad.FileName = "无标题";
            this.sdlgNotepad.Filter = "RTF文件|*.rtf";
            this.sdlgNotepad.FileOk += new System.ComponentModel.CancelEventHandler(this.sdlgNotepad_FileOk);
            // 
            // frmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.stsBook);
            this.Controls.Add(this.rtxtNotepad);
            this.Controls.Add(this.tlsNotepad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNotepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "记事本";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlsNotepad.ResumeLayout(false);
            this.tlsNotepad.PerformLayout();
            this.stsBook.ResumeLayout(false);
            this.stsBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ismiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem 页面设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStrip tlsNotepad;
        private System.Windows.Forms.RichTextBox rtxtNotepad;
        private System.Windows.Forms.StatusStrip stsBook;
        private System.Windows.Forms.ToolStripStatusLabel tssLbl1;
        private System.Windows.Forms.ToolStripStatusLabel tssLbl2;
        private System.Windows.Forms.OpenFileDialog odlgNotepad;
        private System.Windows.Forms.SaveFileDialog sdlgNotepad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiData;
        private System.Windows.Forms.ToolStripMenuItem tsmAuto;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton Null;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripButton tsbCut;
        private System.Windows.Forms.ToolStripButton tsbPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbFont;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.FontDialog fdlgNotepad;
    }
}

