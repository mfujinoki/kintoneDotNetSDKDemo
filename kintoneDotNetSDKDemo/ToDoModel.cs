using kintoneDotNET.API;
using kintoneDotNET.API.Types;
using System;
using System.Configuration;
namespace kintoneDotNetSDKDemo
{
    public class ToDoModel : AbskintoneModel
    {
        [kintoneItem(isUpload = false, isKey = true)]
        public override string record_id { get; set; } //kintoneで自動生成されるレコードID
        [kintoneItem()]
        public DateTime Duedate { get; set; } //締切日フィールド
        [kintoneItem()]
        public DateTime From { get; set; }　//開始日フィールド
        [kintoneItem()]
        public int days_remaining { get; set; } //残り日数フィールド

        //kintoneのApp IDをApp.Configファイルから取得
        private string _app = ConfigurationManager.AppSettings["toDoAppId"];
        public override string app
        {
            get { return _app; }
        }
    }

}
