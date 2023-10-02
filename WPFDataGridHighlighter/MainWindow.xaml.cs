using System;
using System.Collections.Generic;
using System.Data;
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

namespace WPFDataGridHighlighter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataView Data
        {
            get
            {
                var dt = new DataTable();

                dt.Columns.Add(new DataColumn("col1", typeof(double)));
                dt.Columns.Add(new DataColumn("col2", typeof(double)));

                var row = dt.NewRow();
                row[0] = 0.02;
                row[1] = 0.53;
                dt.Rows.Add(row);

                row = dt.NewRow();
                row[0] = 0.8;
                row[1] = 1.0;
                dt.Rows.Add(row);

                row = dt.NewRow();
                row[0] = 2.1;
                row[1] = 8.0;
                dt.Rows.Add(row);

                row = dt.NewRow();
                row[0] = 1.8;
                row[1] = 1.0;
                dt.Rows.Add(row);

                return dt.DefaultView;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
