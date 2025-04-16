using IFoxDYPD3.Dtos;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace IFoxDYPD3.WPF
{
    /// <summary>
    /// XTTView.xaml 的交互逻辑
    /// </summary>
    public partial class XTTView : Window
    {
        public XTTView(List<XTTHuiluDto> XTTHuilus, List<XTTACDto> XTTACHuilus)
        {
            InitializeComponent();
            DataContext = new XTTViewModel(XTTHuilus, XTTACHuilus);
        }

        private void MyDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            // 判断是否是第四列（回路号列）

            var editedColumn = e.Column as DataGridTextColumn;
            if (editedColumn != null && e.Column.DisplayIndex <= 5)
            {
                // 获取正在编辑的控件，假设是 TextBox
                var textBox = e.EditingElement as TextBox;
                if (textBox != null)
                {
                    // 全选文本
                    textBox.SelectAll();
                }
            }
        }
    }
}
