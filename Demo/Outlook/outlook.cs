using System;
using System.IO;
using DevExpress.Xpo;
using System.Linq;
using System.Linq.Dynamic;
using SmartData.API;
namespace outlook
{

    public partial class Messages : SDLiteObject
    {
        DateTime fDate;
        [Persistent("Date")]
        [DevExpress.Xpo.DisplayName("Date")]
        public DateTime Date
        {
            get { return fDate; }
            set { SetPropertyValue<DateTime>("Date", ref fDate, value); }
        }
        string fFolder;
        [Size(SizeAttribute.Unlimited)]
        [Persistent("Folder")]
        [DevExpress.Xpo.DisplayName("Folder")]
        public string Folder
        {
            get { return fFolder; }
            set { SetPropertyValue<string>("Folder", ref fFolder, value); }
        }
        string fFrom;
        [Size(SizeAttribute.Unlimited)]
        [Persistent("From")]
        [DevExpress.Xpo.DisplayName("From")]
        public string From
        {
            get { return fFrom; }
            set { SetPropertyValue<string>("From", ref fFrom, value); }
        }
        bool fHasAttachment;
        [Persistent("HasAttachment")]
        [DevExpress.Xpo.DisplayName("Has Attachment")]
        public bool HasAttachment
        {
            get { return fHasAttachment; }
            set { SetPropertyValue<bool>("HasAttachment", ref fHasAttachment, value); }
        }
        int fID;
        [Key]
        [Persistent("ID")]
        [DevExpress.Xpo.DisplayName("I D")]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>("ID", ref fID, value); }
        }
        bool fIsReply;
        [Persistent("IsReply")]
        [DevExpress.Xpo.DisplayName("Is Reply")]
        public bool IsReply
        {
            get { return fIsReply; }
            set { SetPropertyValue<bool>("IsReply", ref fIsReply, value); }
        }
        string fSubject;
        [Size(SizeAttribute.Unlimited)]
        [Persistent("Subject")]
        [DevExpress.Xpo.DisplayName("Subject")]
        public string Subject
        {
            get { return fSubject; }
            set { SetPropertyValue<string>("Subject", ref fSubject, value); }
        }
        string fText;
        [Size(SizeAttribute.Unlimited)]
        [Persistent("Text")]
        [DevExpress.Xpo.DisplayName("Text")]
        public string Text
        {
            get { return fText; }
            set { SetPropertyValue<string>("Text", ref fText, value); }
        }
        public Messages(Session session) : base(session) { }
        public Messages() : base(UserSession.InternalSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class UserSession : DevExpress.Xpo.Session
    {
        public UserSession()  //I slightly changed the generated code here
        {
            string filename = GetUserDBFileName();
            if (!File.Exists(filename))
                filename = "C:\\Users\\user\\Documents\\SmartData\\bin\\Publish\\UserData\\outlook.accdb";

            ConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Mode=Share Deny None;data source={0};Jet OLEDB:Database Password=;", filename);
        }
        private static UserSession defaultSession;
        public static UserSession InternalSession
        {
            get
            {
                if (defaultSession == null)
                    defaultSession = new UserSession();
                return defaultSession;
            }
        }
        private static string GetUserDBFileName()
        {
            string UserDBFileName = String.Format("{0}\\outlook.accdb", System.IO.Path.GetDirectoryName(typeof(UserSession).Assembly.Location));
            // I slightly changed the generated code here
            return UserDBFileName;
        }
    }


    [SmartData.API.SmartDataRoot]
    [System.Composition.Export(typeof(SmartData.API.ISmartDataRoot))]
    public class Root : DevExpress.Xpo.XPORoot, SmartData.API.ISmartDataRoot
    {
        public Type[] GetIgnoredPropertiesOfTypes()
        {
            return new Type[] { };
        }
        public XPQuery<Messages> Messages
        {
            get { return new XPQuery<Messages>(UserSession.InternalSession); }
        }
    }

}
