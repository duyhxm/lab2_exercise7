namespace Lab2_NguyenHuuMinhDuy_2251012049
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(departmentNameValue.Text)) || (string.IsNullOrEmpty(empNumValue.Text)))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = departmentNameValue.Text;

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, (empNumValue.Text));
                item.SubItems.Add(subitem);

                listView1.Items.Add(item);

                departmentNameValue.Clear();
                empNumValue.Clear();
                departmentNameValue.Focus();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Bạn muốn xóa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                    listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else MessageBox.Show("Xóa lỗi");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
