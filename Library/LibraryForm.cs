namespace Library
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void SearchBookBtn_Click(object sender, EventArgs e)
        {
            FirstForm forma = new FirstForm();
            forma.Show();
            //if(LibraryCardPanel.Visible == false)
            //    MessageBox.Show("��� ������ ���� ���������� ������ ����� ������������� ������!");
        }

        private void PrintCardBtn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }
    }
}