using kintoneDotNET.API;
using kintoneDotNET.API.Types;
using System;
using System.Configuration;
namespace kintoneDotNetSDKDemo
{
    public class ToDoModel : AbskintoneModel
    {
        [kintoneItem(isUpload = false, isKey = true)]
        public override string record_id { get; set; }
        [kintoneItem()]
        public DateTime Duedate { get; set; }
        [kintoneItem()]
        public DateTime From { get; set; }
        [kintoneItem()]
        public int days_remaining { get; set; }

        private string _app = ConfigurationManager.AppSettings["toDoAppId"];
        public override string app
        {
            get { return _app; }
        }
    }

}
