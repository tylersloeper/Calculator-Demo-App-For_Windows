using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calc
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
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.B_decimal = new System.Windows.Forms.Button();
            this.B_Plus = new System.Windows.Forms.Button();
            this.B_Minus = new System.Windows.Forms.Button();
            this.B_multiply = new System.Windows.Forms.Button();
            this.B_divide = new System.Windows.Forms.Button();
            this.B_Equals = new System.Windows.Forms.Button();
            this.B_clear = new System.Windows.Forms.Button();
            this.B_ClearEntry = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number1.Location = new System.Drawing.Point(38, 100);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(45, 45);
            this.number1.TabIndex = 0;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // number2
            // 
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number2.Location = new System.Drawing.Point(89, 100);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(45, 45);
            this.number2.TabIndex = 1;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // number5
            // 
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number5.Location = new System.Drawing.Point(89, 151);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(45, 45);
            this.number5.TabIndex = 3;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // number4
            // 
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number4.Location = new System.Drawing.Point(38, 151);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(45, 45);
            this.number4.TabIndex = 2;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // number6
            // 
            this.number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number6.Location = new System.Drawing.Point(140, 151);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(45, 45);
            this.number6.TabIndex = 5;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // number3
            // 
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number3.Location = new System.Drawing.Point(140, 100);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(45, 45);
            this.number3.TabIndex = 4;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // number9
            // 
            this.number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number9.Location = new System.Drawing.Point(140, 202);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(45, 45);
            this.number9.TabIndex = 8;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // number8
            // 
            this.number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number8.Location = new System.Drawing.Point(89, 202);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(45, 45);
            this.number8.TabIndex = 7;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // number7
            // 
            this.number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number7.Location = new System.Drawing.Point(38, 202);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(45, 45);
            this.number7.TabIndex = 6;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // number0
            // 
            this.number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number0.Location = new System.Drawing.Point(38, 253);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(96, 45);
            this.number0.TabIndex = 9;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // B_decimal
            // 
            this.B_decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.B_decimal.Location = new System.Drawing.Point(140, 253);
            this.B_decimal.Name = "B_decimal";
            this.B_decimal.Size = new System.Drawing.Size(45, 45);
            this.B_decimal.TabIndex = 10;
            this.B_decimal.Text = ".";
            this.B_decimal.UseVisualStyleBackColor = true;
            this.B_decimal.Click += new System.EventHandler(this.Number_Pressed);
            // 
            // B_Plus
            // 
            this.B_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.B_Plus.Location = new System.Drawing.Point(191, 253);
            this.B_Plus.Name = "B_Plus";
            this.B_Plus.Size = new System.Drawing.Size(45, 45);
            this.B_Plus.TabIndex = 14;
            this.B_Plus.Text = "+";
            this.B_Plus.UseVisualStyleBackColor = true;
            this.B_Plus.Click += new System.EventHandler(this.Operator_Clicked);
            // 
            // B_Minus
            // 
            this.B_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.B_Minus.Location = new System.Drawing.Point(191, 202);
            this.B_Minus.Name = "B_Minus";
            this.B_Minus.Size = new System.Drawing.Size(45, 45);
            this.B_Minus.TabIndex = 13;
            this.B_Minus.Text = "-";
            this.B_Minus.UseVisualStyleBackColor = true;
            this.B_Minus.Click += new System.EventHandler(this.Operator_Clicked);
            // 
            // B_multiply
            // 
            this.B_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.B_multiply.Location = new System.Drawing.Point(191, 151);
            this.B_multiply.Name = "B_multiply";
            this.B_multiply.Size = new System.Drawing.Size(45, 45);
            this.B_multiply.TabIndex = 12;
            this.B_multiply.Text = "x";
            this.B_multiply.UseVisualStyleBackColor = true;
            this.B_multiply.Click += new System.EventHandler(this.Operator_Clicked);
            // 
            // B_divide
            // 
            this.B_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.B_divide.Location = new System.Drawing.Point(191, 100);
            this.B_divide.Name = "B_divide";
            this.B_divide.Size = new System.Drawing.Size(45, 45);
            this.B_divide.TabIndex = 11;
            this.B_divide.Text = "/";
            this.B_divide.UseVisualStyleBackColor = true;
            this.B_divide.Click += new System.EventHandler(this.Operator_Clicked);
            // 
            // B_Equals
            // 
            this.B_Equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.B_Equals.Location = new System.Drawing.Point(242, 202);
            this.B_Equals.Name = "B_Equals";
            this.B_Equals.Size = new System.Drawing.Size(45, 96);
            this.B_Equals.TabIndex = 18;
            this.B_Equals.Text = "=";
            this.B_Equals.UseVisualStyleBackColor = true;
            this.B_Equals.Click += new System.EventHandler(this.Operator_Clicked);
            // 
            // B_clear
            // 
            this.B_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.B_clear.Location = new System.Drawing.Point(242, 151);
            this.B_clear.Name = "B_clear";
            this.B_clear.Size = new System.Drawing.Size(45, 45);
            this.B_clear.TabIndex = 16;
            this.B_clear.Text = "C";
            this.B_clear.UseVisualStyleBackColor = true;
            this.B_clear.Click += new System.EventHandler(this.Operator_Clicked);
            // 
            // B_ClearEntry
            // 
            this.B_ClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.B_ClearEntry.Location = new System.Drawing.Point(242, 100);
            this.B_ClearEntry.Name = "B_ClearEntry";
            this.B_ClearEntry.Size = new System.Drawing.Size(45, 45);
            this.B_ClearEntry.TabIndex = 15;
            this.B_ClearEntry.Text = "CE";
            this.B_ClearEntry.UseVisualStyleBackColor = true;
            this.B_ClearEntry.Click += new System.EventHandler(this.Operator_Clicked);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(38, 34);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(249, 35);
            this.result.TabIndex = 19;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 20;
            //do the cool copyright year to year thing.
            if(DateTime.Now.Year == 2017)
            {
                this.label1.Text = "Tyler Loeper Ⓒ2017";
            }
            else
            {
                this.label1.Text = "Tyler Loeper Ⓒ2017" + " - " + DateTime.Now.Year.ToString();
            }
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.B_Equals);
            this.Controls.Add(this.B_clear);
            this.Controls.Add(this.B_ClearEntry);
            this.Controls.Add(this.B_Plus);
            this.Controls.Add(this.B_Minus);
            this.Controls.Add(this.B_multiply);
            this.Controls.Add(this.B_divide);
            this.Controls.Add(this.B_decimal);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button B_decimal;
        private System.Windows.Forms.Button B_Plus;
        private System.Windows.Forms.Button B_Minus;
        private System.Windows.Forms.Button B_multiply;
        private System.Windows.Forms.Button B_divide;
        private System.Windows.Forms.Button B_Equals;
        private System.Windows.Forms.Button B_clear;
        private System.Windows.Forms.Button B_ClearEntry;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
    }
}

