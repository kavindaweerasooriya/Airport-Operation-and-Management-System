
namespace project
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(843, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 284);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(53, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 264);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(22, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete All Data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(22, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Inserted Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(281, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 172);
            this.panel3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(161, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(248, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the passport ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DELETE ONE USER DATA ROW";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(317, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "Back to the Login Page>>";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(529, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 67);
            this.button5.TabIndex = 4;
            this.button5.Text = "Back to the Home Page>>";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Database";
            this.Text = "Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}