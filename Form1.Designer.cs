﻿namespace WindowsFormsApplication15
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItemFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.MenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
      this.textBoxMain = new System.Windows.Forms.TextBox();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(292, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // MenuItemFile
      // 
      this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileNew,
            this.MenuItemFileOpen,
            this.MenuItemFileSave,
            this.MenuItemFileSaveAs,
            this.MenuItemFileSeparator1,
            this.MenuItemFileExit});
      this.MenuItemFile.Name = "MenuItemFile";
      this.MenuItemFile.Size = new System.Drawing.Size(66, 20);
      this.MenuItemFile.Text = "ファイル(&F)";
      // 
      // MenuItemFileNew
      // 
      this.MenuItemFileNew.Name = "MenuItemFileNew";
      this.MenuItemFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.MenuItemFileNew.Size = new System.Drawing.Size(180, 22);
      this.MenuItemFileNew.Text = "新規(&N)...";
      this.MenuItemFileNew.Click += new System.EventHandler(this.MenuItemFileNew_Click);
      // 
      // MenuItemFileOpen
      // 
      this.MenuItemFileOpen.Name = "MenuItemFileOpen";
      this.MenuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.MenuItemFileOpen.Size = new System.Drawing.Size(180, 22);
      this.MenuItemFileOpen.Text = "開く(&O)...";
      this.MenuItemFileOpen.Click += new System.EventHandler(this.MenuItemFileOpen_Click);
      // 
      // MenuItemFileSave
      // 
      this.MenuItemFileSave.Name = "MenuItemFileSave";
      this.MenuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.MenuItemFileSave.Size = new System.Drawing.Size(180, 22);
      this.MenuItemFileSave.Text = "上書き保存(&S)";
      this.MenuItemFileSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
      // 
      // MenuItemFileSaveAs
      // 
      this.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs";
      this.MenuItemFileSaveAs.Size = new System.Drawing.Size(180, 22);
      this.MenuItemFileSaveAs.Text = "名前を付けて保存(&A)...";
      this.MenuItemFileSaveAs.Click += new System.EventHandler(this.MenuItemFileSaveAs_Click);
      // 
      // MenuItemFileSeparator1
      // 
      this.MenuItemFileSeparator1.Name = "MenuItemFileSeparator1";
      this.MenuItemFileSeparator1.Size = new System.Drawing.Size(177, 6);
      // 
      // MenuItemFileExit
      // 
      this.MenuItemFileExit.Name = "MenuItemFileExit";
      this.MenuItemFileExit.Size = new System.Drawing.Size(180, 22);
      this.MenuItemFileExit.Text = "終了(&X)";
      this.MenuItemFileExit.Click += new System.EventHandler(this.MenuItemFileExit_Click);
      // 
      // textBoxMain
      // 
      this.textBoxMain.Location = new System.Drawing.Point(27, 55);
      this.textBoxMain.Name = "textBoxMain";
      this.textBoxMain.Size = new System.Drawing.Size(100, 19);
      this.textBoxMain.TabIndex = 1;
      this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 273);
      this.Controls.Add(this.textBoxMain);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileExit;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator MenuItemFileSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

