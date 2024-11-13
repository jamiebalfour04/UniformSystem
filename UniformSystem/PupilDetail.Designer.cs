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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNoUniform = new Button();
            btnNoTie = new Button();
            nameLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tableLayoutPanel1.Controls.Add(btnNoUniform, 2, 0);
            tableLayoutPanel1.Controls.Add(btnNoTie, 1, 0);
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(616, 47);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNoUniform
            // 
            btnNoUniform.BackColor = Color.Transparent;
            btnNoUniform.Dock = DockStyle.Fill;
            btnNoUniform.FlatStyle = FlatStyle.Flat;
            btnNoUniform.Location = new Point(485, 3);
            btnNoUniform.Name = "btnNoUniform";
            btnNoUniform.Size = new Size(128, 41);
            btnNoUniform.TabIndex = 2;
            btnNoUniform.Text = "No uniform";
            btnNoUniform.UseVisualStyleBackColor = false;
            btnNoUniform.Click += btnNoUniform_Click;
            // 
            // btnNoTie
            // 
            btnNoTie.BackColor = Color.Transparent;
            btnNoTie.Dock = DockStyle.Fill;
            btnNoTie.FlatStyle = FlatStyle.Flat;
            btnNoTie.Location = new Point(351, 3);
            btnNoTie.Name = "btnNoTie";
            btnNoTie.Size = new Size(128, 41);
            btnNoTie.TabIndex = 0;
            btnNoTie.Text = "No tie";
            btnNoTie.UseVisualStyleBackColor = false;
            btnNoTie.Click += btnNoTie_Click;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(149, 13);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "label1";
            // 
            // PupilDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PupilDetail";
            Size = new Size(616, 47);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNoTie;
        private Label nameLabel;
        private Button btnNoUniform;
    }
}
