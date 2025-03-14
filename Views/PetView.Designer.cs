namespace Veterinary.Views
{
    partial class PetView
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
            panel1 = new Panel();
            btnCerrar = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            label2 = new Label();
            tabPagePetDetail = new TabPage();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button6 = new Button();
            button5 = new Button();
            txtPetColour = new TextBox();
            txtPetType = new TextBox();
            txtPetName = new TextBox();
            txtPetID = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPagePetDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 38);
            panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Location = new Point(612, 9);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(32, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "PETS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPagePetDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 38);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(654, 412);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(646, 384);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pet list";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(565, 186);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(565, 146);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(565, 106);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Add new";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(483, 47);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(540, 270);
            dataGridView1.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(18, 47);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(437, 23);
            txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 17);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Search pet";
            // 
            // tabPagePetDetail
            // 
            tabPagePetDetail.Controls.Add(label6);
            tabPagePetDetail.Controls.Add(label5);
            tabPagePetDetail.Controls.Add(label4);
            tabPagePetDetail.Controls.Add(label3);
            tabPagePetDetail.Controls.Add(button6);
            tabPagePetDetail.Controls.Add(button5);
            tabPagePetDetail.Controls.Add(txtPetColour);
            tabPagePetDetail.Controls.Add(txtPetType);
            tabPagePetDetail.Controls.Add(txtPetName);
            tabPagePetDetail.Controls.Add(txtPetID);
            tabPagePetDetail.Location = new Point(4, 24);
            tabPagePetDetail.Name = "tabPagePetDetail";
            tabPagePetDetail.Padding = new Padding(3);
            tabPagePetDetail.Size = new Size(646, 384);
            tabPagePetDetail.TabIndex = 1;
            tabPagePetDetail.Text = "Pet detail";
            tabPagePetDetail.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 150);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 9;
            label6.Text = "Pet colour:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 88);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 8;
            label5.Text = "Pet type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 88);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Pet name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 31);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Pet ID:";
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.Location = new Point(231, 226);
            button6.Name = "button6";
            button6.Size = new Size(166, 37);
            button6.TabIndex = 5;
            button6.Text = "Cancel";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(45, 226);
            button5.Name = "button5";
            button5.Size = new Size(166, 37);
            button5.TabIndex = 4;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = false;
            // 
            // txtPetColour
            // 
            txtPetColour.Location = new Point(45, 177);
            txtPetColour.Name = "txtPetColour";
            txtPetColour.Size = new Size(353, 23);
            txtPetColour.TabIndex = 3;
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(231, 115);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(167, 23);
            txtPetType.TabIndex = 2;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(45, 115);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(154, 23);
            txtPetName.TabIndex = 1;
            // 
            // txtPetID
            // 
            txtPetID.Location = new Point(45, 58);
            txtPetID.Name = "txtPetID";
            txtPetID.Size = new Size(154, 23);
            txtPetID.TabIndex = 0;
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PetView";
            Text = "PetView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPagePetDetail.ResumeLayout(false);
            tabPagePetDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPagePetDetail;
        private TextBox txtSearch;
        private Label label2;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox txtPetType;
        private TextBox txtPetName;
        private TextBox txtPetID;
        private Button button6;
        private Button button5;
        private TextBox txtPetColour;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Button btnCerrar;
    }
}