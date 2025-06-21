using System.Drawing;
using System.Windows.Forms;

namespace forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dot = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.hit = new System.Windows.Forms.Button();
            this.percentage = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.all_num = new System.Windows.Forms.TextBox();
            this.cal = new System.Windows.Forms.TextBox();
            this.square = new System.Windows.Forms.Button();
            this.quse2 = new System.Windows.Forms.Button();
            this.quse1 = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dot.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.dot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dot.Location = new System.Drawing.Point(251, 444);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(112, 46);
            this.dot.TabIndex = 2;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num0.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.num0.ForeColor = System.Drawing.Color.Yellow;
            this.num0.Location = new System.Drawing.Point(131, 445);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(112, 46);
            this.num0.TabIndex = 3;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.plus.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.plus.ForeColor = System.Drawing.Color.Lime;
            this.plus.Location = new System.Drawing.Point(371, 337);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(112, 46);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.num1.ForeColor = System.Drawing.Color.Yellow;
            this.num1.Location = new System.Drawing.Point(11, 390);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(112, 46);
            this.num1.TabIndex = 6;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.num2.ForeColor = System.Drawing.Color.Yellow;
            this.num2.Location = new System.Drawing.Point(131, 390);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(112, 46);
            this.num2.TabIndex = 7;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.num3.ForeColor = System.Drawing.Color.Yellow;
            this.num3.Location = new System.Drawing.Point(251, 390);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(112, 46);
            this.num3.TabIndex = 8;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.num6.ForeColor = System.Drawing.Color.Yellow;
            this.num6.Location = new System.Drawing.Point(251, 336);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(112, 46);
            this.num6.TabIndex = 12;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.num5.ForeColor = System.Drawing.Color.Yellow;
            this.num5.Location = new System.Drawing.Point(131, 336);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(112, 46);
            this.num5.TabIndex = 11;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.num4.ForeColor = System.Drawing.Color.Yellow;
            this.num4.Location = new System.Drawing.Point(11, 336);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(112, 46);
            this.num4.TabIndex = 10;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.min.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.min.ForeColor = System.Drawing.Color.Lime;
            this.min.Location = new System.Drawing.Point(371, 281);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(112, 46);
            this.min.TabIndex = 9;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num9.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.num9.ForeColor = System.Drawing.Color.Yellow;
            this.num9.Location = new System.Drawing.Point(251, 280);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(112, 46);
            this.num9.TabIndex = 16;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num8.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.num8.ForeColor = System.Drawing.Color.Yellow;
            this.num8.Location = new System.Drawing.Point(131, 280);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(112, 46);
            this.num8.TabIndex = 15;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num7.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.num7.ForeColor = System.Drawing.Color.Yellow;
            this.num7.Location = new System.Drawing.Point(11, 280);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(112, 46);
            this.num7.TabIndex = 14;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // hit
            // 
            this.hit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hit.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.hit.ForeColor = System.Drawing.Color.Lime;
            this.hit.Location = new System.Drawing.Point(370, 225);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(112, 46);
            this.hit.TabIndex = 13;
            this.hit.Text = "x";
            this.hit.UseVisualStyleBackColor = false;
            this.hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // percentage
            // 
            this.percentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.percentage.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.percentage.ForeColor = System.Drawing.Color.Lime;
            this.percentage.Location = new System.Drawing.Point(131, 224);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(112, 46);
            this.percentage.TabIndex = 20;
            this.percentage.Text = "%";
            this.percentage.UseVisualStyleBackColor = false;
            this.percentage.Click += new System.EventHandler(this.percentage_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(12, 225);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(112, 46);
            this.delete.TabIndex = 19;
            this.delete.Text = "C";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Del
            // 
            this.Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Del.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.Del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Del.Location = new System.Drawing.Point(11, 445);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(112, 46);
            this.Del.TabIndex = 18;
            this.Del.Text = "Delete";
            this.Del.UseVisualStyleBackColor = false;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.divide.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.divide.ForeColor = System.Drawing.Color.Lime;
            this.divide.Location = new System.Drawing.Point(250, 224);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(112, 46);
            this.divide.TabIndex = 17;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Aqua;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.result.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.result.ForeColor = System.Drawing.Color.Blue;
            this.result.Location = new System.Drawing.Point(371, 390);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(112, 100);
            this.result.TabIndex = 21;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // all_num
            // 
            this.all_num.BackColor = System.Drawing.Color.White;
            this.all_num.ForeColor = System.Drawing.Color.Black;
            this.all_num.Location = new System.Drawing.Point(12, 12);
            this.all_num.Multiline = true;
            this.all_num.Name = "all_num";
            this.all_num.Size = new System.Drawing.Size(471, 95);
            this.all_num.TabIndex = 24;
            // 
            // cal
            // 
            this.cal.BackColor = System.Drawing.Color.White;
            this.cal.ForeColor = System.Drawing.Color.Black;
            this.cal.Location = new System.Drawing.Point(11, 113);
            this.cal.Multiline = true;
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(472, 50);
            this.cal.TabIndex = 26;
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.square.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.square.ForeColor = System.Drawing.Color.Lime;
            this.square.Location = new System.Drawing.Point(370, 170);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(113, 46);
            this.square.TabIndex = 27;
            this.square.Text = "X^2";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // quse2
            // 
            this.quse2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quse2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.quse2.ForeColor = System.Drawing.Color.Lime;
            this.quse2.Location = new System.Drawing.Point(250, 169);
            this.quse2.Name = "quse2";
            this.quse2.Size = new System.Drawing.Size(112, 46);
            this.quse2.TabIndex = 28;
            this.quse2.Text = ")";
            this.quse2.UseVisualStyleBackColor = false;
            this.quse2.Click += new System.EventHandler(this.quse2_Click);
            // 
            // quse1
            // 
            this.quse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quse1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.quse1.ForeColor = System.Drawing.Color.Lime;
            this.quse1.Location = new System.Drawing.Point(131, 169);
            this.quse1.Name = "quse1";
            this.quse1.Size = new System.Drawing.Size(112, 46);
            this.quse1.TabIndex = 29;
            this.quse1.Text = "(";
            this.quse1.UseVisualStyleBackColor = false;
            this.quse1.Click += new System.EventHandler(this.quse1_Click);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.history.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.history.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.history.Location = new System.Drawing.Point(13, 169);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(112, 46);
            this.history.TabIndex = 30;
            this.history.Text = "His";
            this.history.UseVisualStyleBackColor = false;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid.Location = new System.Drawing.Point(11, 255);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 26;
            this.dataGrid.Size = new System.Drawing.Size(471, 246);
            this.dataGrid.TabIndex = 31;
            this.dataGrid.Visible = false;
            this.dataGrid.Leave += new System.EventHandler(this.dataGrid_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(494, 499);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.history);
            this.Controls.Add(this.quse1);
            this.Controls.Add(this.quse2);
            this.Controls.Add(this.square);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.all_num);
            this.Controls.Add(this.result);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.hit);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.min);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.dot);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.Button percentage;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox all_num;
        private System.Windows.Forms.TextBox cal;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button quse2;
        private System.Windows.Forms.Button quse1;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}

