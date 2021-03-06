﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {

      private string FileNameValue;
      private string FileName {
        get {
          return FileNameValue;
        }
        set {
          FileNameValue = value;
          Edited = false;
        }
      }

      private bool EditedValue;
      private bool Edited {
        get { return EditedValue; }
        set {
          EditedValue = value;
          UpdateStatus();
        }
      }

      private void UpdateStatus() {
        string s = applicationName;
        if (FileName != "")
          s += " -" + FileName;
        if (Edited) s += "(変更あり)";
        this.Text = s;

        MenuItemFileSave.Enabled = !(FileName == "" || !Edited || textBoxMain.TextLength == 0);
        MenuItemFileSaveAs.Enabled = Edited && textBoxMain.TextLength > 0;

      }

      const string applicationName = "MyMemo";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
          FileName = "";
          textBoxMain.Multiline = true;
          textBoxMain.ScrollBars = ScrollBars.Vertical;
          textBoxMain.Dock = DockStyle.Fill;
          saveFileDialog1.Filter = "テキスト文書|*.txt|すべてのファイル|*.*";
        }

        private void MenuItemFileExit_Click(object sender, EventArgs e) {
          this.Close();
        }

        private void MenuItemFileOpen_Click(object sender, EventArgs e) {
          openFileDialog1.FileName = "";
          if (DialogResult.OK == openFileDialog1.ShowDialog())
            LoadFile(openFileDialog1.FileName);
        }

        private void LoadFile(string value) {
          textBoxMain.Text = System.IO.File.ReadAllText(
            value, System.Text.Encoding.GetEncoding("Shift_JIS"));
          textBoxMain.Select(0, 0);
          FileName = value;
        }

        private void MenuItemFileSaveAs_Click(object sender, EventArgs e) {
          saveFileDialog1.FileName = System.IO.Path.GetFileName(FileName);
          if (DialogResult.OK == saveFileDialog1.ShowDialog())
            SaveFile(saveFileDialog1.FileName);
        }
        private void SaveFile(string value) {
          System.IO.File.WriteAllText(value, textBoxMain.Text,
            System.Text.Encoding.GetEncoding("Shift_JIS"));
          FileName = value;
        }

        private void MenuItemFileSave_Click(object sender, EventArgs e) {
          SaveFile(FileName);
        }

        private void textBoxMain_TextChanged(object sender, EventArgs e) {
          Edited = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
          if (!AskGiveUpText()) e.Cancel = true;
        }
        private bool AskGiveUpText() {
          if (!Edited || textBoxMain.TextLength == 0) return true;

          if (DialogResult.Yes ==
            MessageBox.Show("編集内容を破棄しますか？",
            applicationName, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)) {
            return true;
          }
          else {
            return false;
          }
        }

        private void MenuItemFileNew_Click(object sender, EventArgs e) {
          if (!AskGiveUpText()) return;
          textBoxMain.Clear();
          FileName = "";
        }
    }
}
