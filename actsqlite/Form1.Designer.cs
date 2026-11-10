namespace actsqlite
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
            label1 = new Label();
            lblnombre = new Label();
            lblid = new Label();
            txtnombre = new TextBox();
            txtid = new TextBox();
            txtinsertar = new Button();
            txtactualizar = new Button();
            txteliminar = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 9);
            label1.Name = "label1";
            label1.Size = new Size(408, 50);
            label1.TabIndex = 0;
            label1.Text = "Base de datos en SQlite";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(38, 77);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(57, 15);
            lblnombre.TabIndex = 1;
            lblnombre.Text = " Nombre:";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(58, 151);
            lblid.Name = "lblid";
            lblid.Size = new Size(20, 15);
            lblid.TabIndex = 2;
            lblid.Text = "id:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(134, 74);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(137, 23);
            txtnombre.TabIndex = 3;
            // 
            // txtid
            // 
            txtid.Location = new Point(134, 148);
            txtid.Name = "txtid";
            txtid.Size = new Size(137, 23);
            txtid.TabIndex = 4;
            // 
            // txtinsertar
            // 
            txtinsertar.Location = new Point(166, 220);
            txtinsertar.Name = "txtinsertar";
            txtinsertar.Size = new Size(75, 23);
            txtinsertar.TabIndex = 5;
            txtinsertar.Text = "insertar";
            txtinsertar.UseVisualStyleBackColor = true;
            txtinsertar.Click += txtinsertar_Click;
            // 
            // txtactualizar
            // 
            txtactualizar.Location = new Point(166, 275);
            txtactualizar.Name = "txtactualizar";
            txtactualizar.Size = new Size(75, 23);
            txtactualizar.TabIndex = 6;
            txtactualizar.Text = "actualizar";
            txtactualizar.UseVisualStyleBackColor = true;
            txtactualizar.Click += txtactualizar_Click;
            // 
            // txteliminar
            // 
            txteliminar.Location = new Point(166, 343);
            txteliminar.Name = "txteliminar";
            txteliminar.Size = new Size(75, 23);
            txteliminar.TabIndex = 7;
            txteliminar.Text = "eliminar";
            txteliminar.UseVisualStyleBackColor = true;
            txteliminar.Click += txteliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, ID });
            dataGridView1.Location = new Point(277, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(511, 353);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txteliminar);
            Controls.Add(txtactualizar);
            Controls.Add(txtinsertar);
            Controls.Add(txtid);
            Controls.Add(txtnombre);
            Controls.Add(lblid);
            Controls.Add(lblnombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblnombre;
        private Label lblid;
        private TextBox txtnombre;
        private TextBox txtid;
        private Button txtinsertar;
        private Button txtactualizar;
        private Button txteliminar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn ID;
    }
}
