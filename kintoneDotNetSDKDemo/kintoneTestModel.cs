using System;
using System.Collections.Generic;
using kintoneDotNET.API;
using kintoneDotNET.API.Types;
using System.Configuration;

namespace kintoneDotNetSDKDemo
{
    public class kintoneTestModel : AbskintoneModel
    {

        //特にキーを設定せず、record_idをそのまま一意キーとして使用したい場合は以下のように設定する
        [kintoneItem(isUpload = false, isKey = true)]
        public override string record_id { get; set; }

        [kintoneItem(isKey = true)]
        public string my_key { get; set; }

        [kintoneItem()]
        public string methodinfo { get; set; }
        [kintoneItem()]
        public string stringField { get; set; }
        [kintoneItem()]
        public decimal numberField { get; set; }
        [kintoneItem(InitialValue = "radio1")]
        public string radio { get; set; }
        [kintoneItem()]
        public List<string> checkbox { get; set; }
        [kintoneItem(InitialValue = "drop1")]
        public string dropdown { get; set; }
        [kintoneItem()]
        public string textarea { get; set; }
        [kintoneItem()]
        public string editor { get; set; }
        [kintoneItem()]
        public List<string> multiselect { get; set; }
        [kintoneItem()]
        public DateTime dateField { get; set; }
        [kintoneItem(FieldType = kintoneDatetime.TimeType)]
        public DateTime time { get; set; }
        [kintoneItem(FieldType = kintoneDatetime.DateTimeType)]
        public DateTime datetimeField { get; set; }
        [kintoneItem()]
        public string link { get; set; }
        [kintoneItem()]
        public List<kintoneFile> attachfile { get; set; }

        [kintoneItem()]
        public string validationFld { get; set; }

        [kintoneItem()]
        public List<ChangeLog> changeLogs { get; set; }

        private string _app =  ConfigurationManager.AppSettings["testAppId"];
        public override string app
        {
            get { return _app; }
        }

        public kintoneTestModel()
        {
        }
        public kintoneTestModel(string methodInfo)
        {
            this.methodinfo = methodInfo;
        }

        public override string ToString()
        {
            string result = methodinfo + ":" + stringField;
            return result;
        }

    }

    public class ChangeLog : kintoneSubTableItem
    {

        [kintoneItem()]
        public DateTime changeYMD { get; set; }

        [kintoneItem()]
        public string historyDesc { get; set; }

        public ChangeLog()
        {
        }

        public ChangeLog(DateTime changeYMD, string historyDesc)
        {
            this.changeYMD = changeYMD;
            this.historyDesc = historyDesc;
        }

    }
}
