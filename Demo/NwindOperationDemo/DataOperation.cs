using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Composition;

using DevExpress.Utils.Menu;
using nwind;

namespace NwindOperationDemo
{

    [Export(typeof(SmartData.API.IDXMenuItemsProvider<object>))]
    public class ProductOperations : SmartData.API.IDXMenuItemsProvider<object>
    {

        public DXMenuItem[] GetNullableEditItem(object obj)
        {
            if (obj == null) return null;
            Type type = obj.GetType();

            if (type != typeof(nwind.Products))
                return null;

            DXMenuCheckItem menuItem = new DXMenuCheckItem();
            menuItem.Checked = !(obj as Products).Discontinued;
            if (menuItem.Checked)
            {
                menuItem.Caption = "Active Product (Toggle Mode Demo)";
                menuItem.Image = Properties.Resources.active;
            }
            else
            {
                menuItem.Caption = "Inactive Product (Toggle Mode Demo)";
                menuItem.Image = Properties.Resources.inactive;
            }

            menuItem.Tag = obj;
            

            menuItem.Click += ToggleProductStatus;

            return new DXMenuItem[] { menuItem };
        }

        void ToggleProductStatus(object sender, System.EventArgs e)
        {
            ((sender as DXMenuCheckItem).Tag as Products).Discontinued = !(sender as DXMenuCheckItem).Checked;
            ((sender as DXMenuCheckItem).Tag as Products).Save();
        }


    }

    [Export(typeof(SmartData.API.IDXMenuItemsProvider<object>))]
    public class CategoryOperations : SmartData.API.IDXMenuItemsProvider<object>
    {

        public DXMenuItem[] GetNullableEditItem(object obj)
        {
            if (obj == null) return null;
            Type type = obj.GetType();

            if (type != typeof(Categories))
                return null;

            DXMenuItem menuItem = new DXMenuItem(string.Format("Including {0} Products (General Method Demo)", (obj as Categories).Products.Count().ToString()));
            menuItem.Tag = obj;
            //menuItem.Image = Properties.Resources.ValueImage.ToBitmap();
            menuItem.Click += ShowValueAsString;

            return new DXMenuItem[] { menuItem };

        }

        void ShowValueAsString(object sender, System.EventArgs e)
        {
            MessageBox.Show(String.Format("There are totally {0} ACTIVE Products in this category", ((sender as DXMenuCheckItem).Tag as Categories).Products.Where(p => p.Discontinued == false).Count().ToString()));
        }
    }

}
