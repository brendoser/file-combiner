using FileCombiner.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace FileCombiner
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        private ObservableCollection<ListItemData> _files { get; set; } = new ObservableCollection<ListItemData>() { };

        public ObservableCollection<ListItemData> Files
        {
            get { return _files; }
            set { _files = value; OnPropertyChanged("Files"); }
        }

        public MainWindow()
        {
            InitializeComponent();

            dropArea.AddHandler(Border.DragOverEvent, new DragEventHandler(DropArea_DragOver), true);
            dropArea.AddHandler(Border.DropEvent, new DragEventHandler(DropArea_Drop), true);
            DataContext = this;
        }

        private void DropArea_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                FileInfo fileInfo = new FileInfo(docPath[0]);

                Files.Add(new ListItemData(docPath[0], fileInfo.Length.ToString(), fileInfo.LastWriteTime.ToString()));
            }
        }

        private void DropArea_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.All;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void ListViewItem_Drop(object sender, DragEventArgs e)
        {
            ListItemData droppedData = e.Data.GetData(typeof(ListItemData)) as ListItemData;
            ListItemData target = ((ListViewItem)(sender)).DataContext as ListItemData;

            int removedIdx = listView.Items.IndexOf(droppedData);
            int targetIdx = listView.Items.IndexOf(target);

            if (removedIdx < targetIdx)
            {
                Files.Insert(targetIdx + 1, droppedData);
                Files.RemoveAt(removedIdx);
            }
            else
            {
                int remIdx = removedIdx + 1;
                if (Files.Count + 1 > remIdx)
                {
                    Files.Insert(targetIdx, droppedData);
                    Files.RemoveAt(remIdx);
                }
            }
        }

        private void ListViewItem_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && sender is ListBoxItem)
            {
                ListBoxItem draggedItem = sender as ListBoxItem;
                DragDrop.DoDragDrop(draggedItem, draggedItem.DataContext, DragDropEffects.Move);
                draggedItem.IsSelected = true;
            }
        }
    }
}
