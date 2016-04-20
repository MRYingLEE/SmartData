using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartData.API;

namespace L2SDemo
{
    [SmartData.API.SmartDataRoot]
    [System.Composition.Export(typeof(SmartData.API.ISmartDataRoot))]
    public class Root : SmartData.API.ISmartDataRoot
    {
        Type[] SmartData.API.ISmartDataRoot.GetIgnoredPropertiesOfTypes()
        {
            return new Type[] { };
        }
        public string Description
        {
            get { return "This is a demo. You may find the source code at the folder of DemoData\\L2SDemo.\r\n You may add more data by the Data Wizard."; }
        }

        private DataClasses1DataContext context = new DataClasses1DataContext();

        public Root()
        {
            // It is very important to take care of connection, especially relative folder.
            string codeBase = typeof(Root).Assembly.CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            string folder = System.IO.Path.GetDirectoryName(path);

            string connection = string.Format("Data Source=(LocalDB)\\v11.0;AttachDbFilename={0}\\XCRM_14.2.mdf;Integr" +
            "ated Security=True;Connect Timeout=30", folder);


            context = new DataClasses1DataContext(connection);
        }

        public System.Data.Linq.Table<ActivityTarget> ActivityTargets
        {
            get
            {
                return context.GetTable<ActivityTarget>();
            }
        }

        public System.Data.Linq.Table<User> Users
        {
            get
            {
                return context.GetTable<User>();
            }
        }

        public System.Data.Linq.Table<Address> Addresses
        {
            get
            {
                return context.GetTable<Address>();
            }
        }

        public System.Data.Linq.Table<Event> Events
        {
            get
            {
                return context.GetTable<Event>();
            }
        }

        public System.Data.Linq.Table<FileData> FileDatas
        {
            get
            {
                return context.GetTable<FileData>();
            }
        }

        public System.Data.Linq.Table<HCategory> HCategories
        {
            get
            {
                return context.GetTable<HCategory>();
            }
        }

        public System.Data.Linq.Table<KpiDefinition> KpiDefinitions
        {
            get
            {
                return context.GetTable<KpiDefinition>();
            }
        }

        public System.Data.Linq.Table<KpiHistoryItem> KpiHistoryItems
        {
            get
            {
                return context.GetTable<KpiHistoryItem>();
            }
        }

        public System.Data.Linq.Table<KpiInstanceKpiScorecard> KpiInstanceKpiScorecards
        {
            get
            {
                return context.GetTable<KpiInstanceKpiScorecard>();
            }
        }

        public System.Data.Linq.Table<KpiInstance> KpiInstances
        {
            get
            {
                return context.GetTable<KpiInstance>();
            }
        }

        public System.Data.Linq.Table<KpiScorecard> KpiScorecards
        {
            get
            {
                return context.GetTable<KpiScorecard>();
            }
        }

        public System.Data.Linq.Table<LeadHistoryRecord> LeadHistoryRecords
        {
            get
            {
                return context.GetTable<LeadHistoryRecord>();
            }
        }

        public System.Data.Linq.Table<ModuleInfoe> ModuleInfoes
        {
            get
            {
                return context.GetTable<ModuleInfoe>();
            }
        }

        public System.Data.Linq.Table<Note> Notes
        {
            get
            {
                return context.GetTable<Note>();
            }
        }

        public System.Data.Linq.Table<People> Peoples
        {
            get
            {
                return context.GetTable<People>();
            }
        }

        public System.Data.Linq.Table<Product> Products
        {
            get
            {
                return context.GetTable<Product>();
            }
        }

        public System.Data.Linq.Table<ReportData> ReportDatas
        {
            get
            {
                return context.GetTable<ReportData>();
            }
        }

        public System.Data.Linq.Table<ResourceEvent> ResourceEvents
        {
            get
            {
                return context.GetTable<ResourceEvent>();
            }
        }

        public System.Data.Linq.Table<Resource> Resources
        {
            get
            {
                return context.GetTable<Resource>();
            }
        }

        public System.Data.Linq.Table<RoleRole> RoleRoles
        {
            get
            {
                return context.GetTable<RoleRole>();
            }
        }

        public System.Data.Linq.Table<Role> Roles
        {
            get
            {
                return context.GetTable<Role>();
            }
        }

        public System.Data.Linq.Table<SaleItem> SaleItems
        {
            get
            {
                return context.GetTable<SaleItem>();
            }
        }

        public System.Data.Linq.Table<SecuritySystemMemberPermissionsObject> SecuritySystemMemberPermissionsObjects
        {
            get
            {
                return context.GetTable<SecuritySystemMemberPermissionsObject>();
            }
        }

        public System.Data.Linq.Table<SecuritySystemObjectPermissionsObject> SecuritySystemObjectPermissionsObjects
        {
            get
            {
                return context.GetTable<SecuritySystemObjectPermissionsObject>();
            }
        }

        public System.Data.Linq.Table<TypePermissionObject> TypePermissionObjects
        {
            get
            {
                return context.GetTable<TypePermissionObject>();
            }
        }

        public System.Data.Linq.Table<UserRole> UserRoles
        {
            get
            {
                return context.GetTable<UserRole>();
            }
        }

    }
}
