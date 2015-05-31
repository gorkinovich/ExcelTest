// An application in spanish to test the ExcelHandler library.
// Copyright (C) 2009  Gorka Suárez García
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Excel;

namespace ExcelTest {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            this.handler = null;
        }

        private void write_Click(object sender, EventArgs e) {
            this.open();
            this.handler.Write(this.sheet.Text, this.cell.Text, this.value.Text);
            this.close();
            this.output.Text += "Write completed...\r\n";
        }

        private void read_Click(object sender, EventArgs e) {
            this.open();
            this.value.Text = this.handler.Read(this.sheet.Text, this.cell.Text);
            this.close();
            this.output.Text += "Read completed...\r\n";
        }

        private void clear_Click(object sender, EventArgs e) {
            this.open();
            this.handler.Clear();
            this.close();
            this.output.Text += "Clear completed...\r\n";
        }

        private void listNames_Click(object sender, EventArgs e) {
            this.open();
            string[] names = handler.GetSheetsNames();
            this.close();

            this.output.Text = "Names of the sheets:\r\n";
            foreach(string name in names) {
                this.output.Text += (name + "\r\n");
            }
        }

        private void open() {
            string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            string path = (execPath + @"\" + this.excel.Text);
            this.handler = new ExcelHandler();
            this.handler.Open(path);
        }

        private void close() {
            this.handler.Close();
            this.handler = null;
            GC.Collect();
        }

        private ExcelHandler handler;
    }
}
