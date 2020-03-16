using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DZ_WPF04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Book> Books { get; set; }
        
        public RemoveFromCollection RemoveFromCollection { get;  set; }

        public MainWindow()
        {
            InitializeComponent();

            Books = new ObservableCollection<Book>();

            LoadData();
            RemoveFromCollection = new RemoveFromCollection(RemoveBook);
            DataContext = this;
        }

        private void LoadData()
        {
            Books.Add(new Book { Name = "WPF 4.5", Author = "Jason", Pages = 1290, Description = "WPF - аналог WinForms, система для построения клиентских приложений Windows с визуально привлекательными возможностями взаимодействия с пользователем" });
            Books.Add(new Book { Name = "Java 8", Author = "Tom", Pages = 898, Description = "WPF - аналог WinForms, система для построения клиентских приложений Windows с визуально привлекательными возможностями взаимодействия с пользователем" });
            Books.Add(new Book { Name = "C# 8", Author = "Victor", Pages = 1456, Description = "WPF - аналог WinForms, система для построения клиентских приложений Windows с визуально привлекательными возможностями взаимодействия с пользователем" });
            Books.Add(new Book { Name = "ECMA Script 6", Author = "Olga", Pages = 1250, Description = "WPF - аналог WinForms, система для построения клиентских приложений Windows с визуально привлекательными возможностями взаимодействия с пользователем" });
            Books.Add(new Book { Name = "Robinson", Author = "Daniel Defo", Pages = 560, Description = "WPF - аналог WinForms, система для построения клиентских приложений Windows с визуально привлекательными возможностями взаимодействия с пользователем" });

        }

        private void RemoveBook(object param)
        {
            if(param is Book book)
            {
                Books.Remove(book);
            }
        }
    }
}
