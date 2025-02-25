﻿using System.ComponentModel;

namespace SSTattoo;

partial class AddTattooForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.button1 = new System.Windows.Forms.Button();
        this.contextMenu1 = new System.Windows.Forms.ContextMenu();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(48, 211);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(140, 34);
        this.button1.TabIndex = 0;
        this.button1.Text = "Добавить";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(12, 58);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(210, 20);
        this.textBox1.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(12, 40);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(87, 15);
        this.label1.TabIndex = 3;
        this.label1.Text = "Название:";
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(12, 98);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(87, 16);
        this.label2.TabIndex = 4;
        this.label2.Text = "Цена:";
        // 
        // numericUpDown1
        // 
        this.numericUpDown1.Location = new System.Drawing.Point(12, 117);
        this.numericUpDown1.Maximum = new decimal(new int[] {10000000, 0, 0, 0});
        this.numericUpDown1.Name = "numericUpDown1";
        this.numericUpDown1.Size = new System.Drawing.Size(210, 20);
        this.numericUpDown1.TabIndex = 5;
        // 
        // AddTattooForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(234, 257);
        this.Controls.Add(this.numericUpDown1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.button1);
        this.Name = "AddTattooForm";
        this.Text = "Добавить тату";
        ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.NumericUpDown numericUpDown1;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ContextMenu contextMenu1;

    #endregion
}