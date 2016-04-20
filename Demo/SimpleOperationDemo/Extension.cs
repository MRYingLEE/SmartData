using System;
using System.Composition;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Menu;

namespace SimpleOperationDemo
{
    [Export(typeof(SmartData.API.IDXMenuItemsProvider<object>))]
    public class TypeCheck : SmartData.API.IDXMenuItemsProvider<object>
    {

        public DXMenuItem[] GetNullableEditItem(object obj)
        {
            if (obj == null) return null;
            Type type = obj.GetType();

            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            DXMenuItem menuItem = new DXMenuItem("Type Check (General Type Demo)");

            textEdit.ReadOnly = true;
            menuItem.Tag = type;
            menuItem.Image =Properties.Resources.TypeImage;

            menuItem.Click += ShowTypeInfo;

            return new DXMenuItem[] { menuItem };
        }

        void ShowTypeInfo(object sender, System.EventArgs e)
        {
            MessageBox.Show("The location of the type is :" + ((sender as DXMenuItem).Tag as Type).AssemblyQualifiedName);
        }


    }

    [Export(typeof(SmartData.API.IDXMenuItemsProvider<object>))]
    public class ValueCheck : SmartData.API.IDXMenuItemsProvider<object>
    {

        public DXMenuItem[] GetNullableEditItem(object obj)
        {
            if (obj == null) return null;
            Type type = obj.GetType();

            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            DXMenuItem menuItem = new DXMenuItem("Value Check (General Value Demo)");
            textEdit.ReadOnly = true;
            menuItem.Tag = obj;
            menuItem.Image = Properties.Resources.ValueImage;
            menuItem.Click += ShowValueAsString;

            return new DXMenuItem[] { menuItem };

        }

        void ShowValueAsString(object sender, System.EventArgs e)
        {
            MessageBox.Show("The as string value of the object is :" + (((sender as DXMenuItem).Tag as object).ToString()));
        }
    }

}
