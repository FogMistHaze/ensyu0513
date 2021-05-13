
namespace ensyu0513
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.heart = new System.Windows.Forms.Button();
            this.savana = new System.Windows.Forms.Button();
            this.oct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heart
            // 
            this.heart.BackColor = System.Drawing.Color.Red;
            this.heart.Font = new System.Drawing.Font("游明朝", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heart.Location = new System.Drawing.Point(12, 12);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(301, 51);
            this.heart.TabIndex = 0;
            this.heart.Text = "ハーツラビュルの寮長";
            this.heart.UseVisualStyleBackColor = false;
            this.heart.Click += new System.EventHandler(this.redbutton_Click);
            // 
            // savana
            // 
            this.savana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.savana.Font = new System.Drawing.Font("游明朝", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savana.Location = new System.Drawing.Point(12, 69);
            this.savana.Name = "savana";
            this.savana.Size = new System.Drawing.Size(301, 51);
            this.savana.TabIndex = 1;
            this.savana.Text = "サバナクローの寮長";
            this.savana.UseVisualStyleBackColor = false;
            this.savana.Click += new System.EventHandler(this.savana_Click);
            // 
            // oct
            // 
            this.oct.BackColor = System.Drawing.Color.Purple;
            this.oct.Font = new System.Drawing.Font("游明朝", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oct.Location = new System.Drawing.Point(12, 126);
            this.oct.Name = "oct";
            this.oct.Size = new System.Drawing.Size(301, 51);
            this.oct.TabIndex = 2;
            this.oct.Text = "オクタヴィネルの寮長";
            this.oct.UseVisualStyleBackColor = false;
            this.oct.Click += new System.EventHandler(this.oct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oct);
            this.Controls.Add(this.savana);
            this.Controls.Add(this.heart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button heart;
        private System.Windows.Forms.Button savana;
        private System.Windows.Forms.Button oct;
    }
}

