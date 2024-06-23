using Repositories;

namespace BookManagerGUIForms
{
    public partial class BookManagerMainForm : Form
    {
        public BookManagerMainForm()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào! Welcome to Win Forms - a kind of desktop app", "Xin chào", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you really want to quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowCountry_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected the country code: " + cboCountry.SelectedValue);
        }

        private void btnFillCountry_Click(object sender, EventArgs e)
        {
            List<Country> arr = new List<Country>();
            arr.Add(new Country() { CountryCode = 84, Name = "Vietnam" });
            arr.Add(new Country() { CountryCode = 1, Name = "USA" });
            arr.Add(new Country() { CountryCode = 44, Name = "United Kingdom" });

            cboCountry.DataSource = arr;
            cboCountry.DisplayMember = "Name"; //show cột name, ẩn cột code
            cboCountry.ValueMember = "CountryCode"; //chọn tên quốc gia nhưng cái ta cần là mã quốc gia
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFillBooks_Click(object sender, EventArgs e)
        {
            //đổ table Books vào lưới dgvBookList
            BookManagementDbContext context = new();
            dgvBookList.DataSource = context.Books.ToList();
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            BookDetailForm detail = new(); //new mới tạo, chưa render
            detail.Text = "Tạo mới | Cập nhật sách";
            detail.ShowDialog(); //render là đẩy ra màn hình xem
        }
    }
}
