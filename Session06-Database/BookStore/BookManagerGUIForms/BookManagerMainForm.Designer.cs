namespace BookManagerGUIForms
{
    partial class BookManagerMainForm
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
            btnSayHello = new Button();
            btnQuit = new Button();
            btnShowCountry = new Button();
            btnFillCountry = new Button();
            cboCountry = new ComboBox();
            label1 = new Label();
            dgvBookList = new DataGridView();
            btnFillBooks = new Button();
            btnCreateBook = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // btnSayHello
            // 
            btnSayHello.FlatStyle = FlatStyle.Flat;
            btnSayHello.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSayHello.ForeColor = Color.Yellow;
            btnSayHello.Location = new Point(12, 12);
            btnSayHello.Name = "btnSayHello";
            btnSayHello.Size = new Size(125, 45);
            btnSayHello.TabIndex = 0;
            btnSayHello.Text = "Say Hello";
            btnSayHello.UseVisualStyleBackColor = true;
            btnSayHello.Click += btnSayHello_Click;
            // 
            // btnQuit
            // 
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.Yellow;
            btnQuit.Location = new Point(663, 12);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(125, 45);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnShowCountry
            // 
            btnShowCountry.FlatStyle = FlatStyle.Flat;
            btnShowCountry.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowCountry.ForeColor = Color.Yellow;
            btnShowCountry.Location = new Point(426, 12);
            btnShowCountry.Name = "btnShowCountry";
            btnShowCountry.Size = new Size(165, 45);
            btnShowCountry.TabIndex = 2;
            btnShowCountry.Text = "Show Country";
            btnShowCountry.UseVisualStyleBackColor = true;
            btnShowCountry.Click += btnShowCountry_Click;
            // 
            // btnFillCountry
            // 
            btnFillCountry.FlatStyle = FlatStyle.Flat;
            btnFillCountry.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFillCountry.ForeColor = Color.Yellow;
            btnFillCountry.Location = new Point(206, 12);
            btnFillCountry.Name = "btnFillCountry";
            btnFillCountry.Size = new Size(151, 45);
            btnFillCountry.TabIndex = 3;
            btnFillCountry.Text = "Fill Country";
            btnFillCountry.UseVisualStyleBackColor = true;
            btnFillCountry.Click += btnFillCountry_Click;
            // 
            // cboCountry
            // 
            cboCountry.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboCountry.ForeColor = Color.Black;
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(329, 63);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(459, 38);
            cboCountry.TabIndex = 4;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(166, 66);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 5;
            label1.Text = "Select Country";
            label1.Click += label1_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(12, 205);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.Size = new Size(776, 233);
            dgvBookList.TabIndex = 6;
            dgvBookList.CellContentClick += dgvBookList_CellContentClick;
            // 
            // btnFillBooks
            // 
            btnFillBooks.FlatStyle = FlatStyle.Flat;
            btnFillBooks.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFillBooks.ForeColor = Color.Yellow;
            btnFillBooks.Location = new Point(12, 154);
            btnFillBooks.Name = "btnFillBooks";
            btnFillBooks.Size = new Size(125, 45);
            btnFillBooks.TabIndex = 7;
            btnFillBooks.Text = "Fill Books";
            btnFillBooks.UseVisualStyleBackColor = true;
            btnFillBooks.Click += btnFillBooks_Click;
            // 
            // btnCreateBook
            // 
            btnCreateBook.FlatStyle = FlatStyle.Flat;
            btnCreateBook.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateBook.ForeColor = Color.Yellow;
            btnCreateBook.Location = new Point(198, 154);
            btnCreateBook.Name = "btnCreateBook";
            btnCreateBook.Size = new Size(159, 45);
            btnCreateBook.TabIndex = 8;
            btnCreateBook.Text = "Create Books";
            btnCreateBook.UseVisualStyleBackColor = true;
            btnCreateBook.Click += btnCreateBook_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(518, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(90, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // BookManagerMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCreateBook);
            Controls.Add(btnFillBooks);
            Controls.Add(dgvBookList);
            Controls.Add(label1);
            Controls.Add(cboCountry);
            Controls.Add(btnFillCountry);
            Controls.Add(btnShowCountry);
            Controls.Add(btnQuit);
            Controls.Add(btnSayHello);
            Name = "BookManagerMainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSayHello;
        private Button btnQuit;
        private Button btnShowCountry;
        private Button btnFillCountry;
        private ComboBox cboCountry;
        private Label label1;
        private DataGridView dgvBookList;
        private Button btnFillBooks;
        private Button btnCreateBook;
        private DateTimePicker dateTimePicker1;
    }
}
