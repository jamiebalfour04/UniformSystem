using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace UniformSystem
{
    partial class PupilDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNoUniform = new System.Windows.Forms.Button();
            this.btnNoTie = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.Controls.Add(this.btnNoUniform, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNoTie, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 38);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNoUniform
            // 
            this.btnNoUniform.BackColor = System.Drawing.Color.Transparent;
            this.btnNoUniform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNoUniform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoUniform.Location = new System.Drawing.Point(483, 2);
            this.btnNoUniform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoUniform.Name = "btnNoUniform";
            this.btnNoUniform.Size = new System.Drawing.Size(128, 34);
            this.btnNoUniform.TabIndex = 2;
            this.btnNoUniform.Text = "No uniform";
            this.btnNoUniform.UseVisualStyleBackColor = false;
            this.btnNoUniform.Click += new System.EventHandler(this.btnNoUniform_Click);
            // 
            // btnNoTie
            // 
            this.btnNoTie.BackColor = System.Drawing.Color.Transparent;
            this.btnNoTie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNoTie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoTie.Location = new System.Drawing.Point(349, 2);
            this.btnNoTie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoTie.Name = "btnNoTie";
            this.btnNoTie.Size = new System.Drawing.Size(128, 34);
            this.btnNoTie.TabIndex = 0;
            this.btnNoTie.Text = "No tie";
            this.btnNoTie.UseVisualStyleBackColor = false;
            this.btnNoTie.Click += new System.EventHandler(this.btnNoTie_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(151, 11);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label1";
            // 
            // PupilDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(0, 40);
            this.Name = "PupilDetail";
            this.Size = new System.Drawing.Size(614, 38);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNoTie;
        private Label nameLabel;
        private Button btnNoUniform;
    }
}
