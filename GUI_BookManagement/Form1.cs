using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_BookManagement
{
    public partial class Form1 : Form
    {
        private BookManager bookManager = new BookManager();
        private string filePath = "../../Resources/books.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                bookManager.LoadFromFile(filePath);
                MessageBox.Show("Data loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            if (int.TryParse(txtYear.Text.Trim(), out int year) && year > 0)
            {
                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
                {
                    MessageBox.Show("Title and Author cannot be empty.");
                    return;
                }

                Book newBook = new Book(title, author, year);
                bookManager.AddBook(newBook);
                MessageBox.Show("Book added successfully!");
                txtTitle.Clear();
                txtAuthor.Clear();
                txtYear.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid year.");
            }
            try
            {
                bookManager.SaveToFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = bookManager.GetAllBooks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTitle = txtSearch.Text.Trim();
            var results = bookManager.SearchBooks(searchTitle, searchTitle, searchTitle);
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("No books found!");
            }
        }
    }
}
