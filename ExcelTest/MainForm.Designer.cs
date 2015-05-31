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

namespace ExcelTest {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.output = new System.Windows.Forms.TextBox();
            this.write = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sheet = new System.Windows.Forms.TextBox();
            this.cell = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.excel = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.listNames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 147);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(445, 188);
            this.output.TabIndex = 0;
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(12, 341);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(75, 23);
            this.write.TabIndex = 1;
            this.write.Text = "Write";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(382, 341);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(93, 341);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 23);
            this.read.TabIndex = 3;
            this.read.Text = "Read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sheet:";
            // 
            // sheet
            // 
            this.sheet.Location = new System.Drawing.Point(52, 38);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(405, 20);
            this.sheet.TabIndex = 5;
            // 
            // cell
            // 
            this.cell.Location = new System.Drawing.Point(52, 64);
            this.cell.Name = "cell";
            this.cell.Size = new System.Drawing.Size(405, 20);
            this.cell.TabIndex = 6;
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(52, 90);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(405, 20);
            this.value.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cell:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output:";
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(52, 12);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(405, 20);
            this.excel.TabIndex = 13;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(9, 15);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(36, 13);
            this.label0.TabIndex = 12;
            this.label0.Text = "Excel:";
            // 
            // listNames
            // 
            this.listNames.Location = new System.Drawing.Point(301, 341);
            this.listNames.Name = "listNames";
            this.listNames.Size = new System.Drawing.Size(75, 23);
            this.listNames.TabIndex = 14;
            this.listNames.Text = "Show names";
            this.listNames.UseVisualStyleBackColor = true;
            this.listNames.Click += new System.EventHandler(this.listNames_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 372);
            this.Controls.Add(this.listNames);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value);
            this.Controls.Add(this.cell);
            this.Controls.Add(this.sheet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.read);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.write);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Excel Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sheet;
        private System.Windows.Forms.TextBox cell;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox excel;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button listNames;
    }
}
