using MigrationsDEMO.Model;
using MigrationsDEMO.Repositories;
using System.Collections.Generic;
using System.Windows;

namespace MigrationsDEMO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BookRepository _bookRepository;
        private List<Book>? booksList;
        public MainWindow()
        {
            InitializeComponent();
            _bookRepository = new BookRepository();
            BooksDataGrid.ItemsSource = booksList;
            FillDataGrid();
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            _bookRepository.AddBook(BookTextBox.Text);
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            booksList = _bookRepository.GetAllBooks();
            BooksDataGrid.ItemsSource = booksList;
        }
    }
}
