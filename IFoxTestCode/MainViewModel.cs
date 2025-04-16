using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFoxTestCode
{



    public class CellItem : INotifyPropertyChanged
    {
        private string _content;
        public string Content
        {
            get => _content;
            set { _content = value; OnPropertyChanged(nameof(Content)); }
        }

        private int _rowSpan;
        public int RowSpan
        {
            get => _rowSpan;
            set { _rowSpan = value; OnPropertyChanged(nameof(RowSpan)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ColumnData
    {
        public ObservableCollection<CellItem> Cells { get; } = new ObservableCollection<CellItem>();

        public void AddCell(string content, int rowSpan)
        {
            Cells.Add(new CellItem { Content = content, RowSpan = rowSpan });
        }
    }

    public class MainViewModel
    {
        public ObservableCollection<ColumnData> Columns { get; } = new ObservableCollection<ColumnData>();

        public MainViewModel()
        {
            // 初始化8列数据
            for (int i = 0; i < 8; i++)
            {
                var column = new ColumnData();

                // 每列添加不同高度的单元格，总和为9
                column.AddCell($"列{i + 1}-单元格1", 3); // 3格
                column.AddCell($"列{i + 1}-单元格2", 2); // 2格
                column.AddCell($"列{i + 1}-单元格3", 1); // 1格
                column.AddCell($"列{i + 1}-单元格4", 3); // 3格
                                                     // 总和: 3+2+1+3 = 9

                Columns.Add(column);
            }
        }
    }


}
