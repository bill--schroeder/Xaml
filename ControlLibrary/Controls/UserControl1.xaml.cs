using DevExpress.Xpf.Docking;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlLibrary.Controls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        void ActivateItem(BaseLayoutItem item)
        {
            dockLayoutManager1.LayoutController.Activate(item);
        }

        //DocumentPanel panel1 = null;
        LayoutPanel panel1 = null;
        int ctr = 1;

        private void btnAddPanel_Click(object sender, RoutedEventArgs e)
        {

            //panel1 = dockLayoutManager1.DockController.AddDocumentPanel(documentGroup1,
            //    new Uri(@"Views\View1.xaml", UriKind.Relative));
            //panel1.Caption = "Control " + (ctr++).ToString();

            //DocumentPanel.SetMDISize(panel1, new Size(400, 300));
            //DocumentPanel.SetMDILocation(panel1, new Point(200, 200));


            //docPanel1.Content = new Uri(@"CustomWindows\MyWindow1.xaml", UriKind.Relative);


            panel1 = dockLayoutManager1.DockController.AddPanel(DevExpress.Xpf.Layout.Core.DockType.Top);
            panel1.Caption = "Panel " + (ctr++).ToString();
            panel1.FloatSize = new Size(600, 400);

            View1 v1 = new View1();
            panel1.Content = v1;


            ActivateItem(panel1);


            dockLayoutManager1.HideView(AutoHideGroup);

        }


    }
}
