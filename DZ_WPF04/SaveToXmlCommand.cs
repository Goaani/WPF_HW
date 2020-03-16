using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Serialization;

namespace DZ_WPF04
{
    class SaveToXmlCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            bool flag = parameter is ItemCollection collection && collection.Count > 0;
            return flag;
        }

        public void Execute(object parameter)
        {
            var collection = parameter as ItemCollection;
            var fs = new FileStream("books.xml", FileMode.Create, FileAccess.Write);
            var xs = new XmlSerializer(typeof(List<Book>));
            List<Book> books = new List<Book>();
            foreach (Book o in collection)
            {
                books.Add(o);

            }
            xs.Serialize(fs, books);
            fs.Close();
            MessageBox.Show("GridView was saved to the file 'books.xml'");
        }
    }
}
