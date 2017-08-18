using System;
using System.Collections.Generic;

namespace kintoneDotNetSDKDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            updateDaysRemaining();

            Console.ReadLine();//テスト用、実用時には削除
        }
        static void updateDaysRemaining()
        {
            // 締切日と開始日が入力されているデータのみ抽出
            List<ToDoModel> toDos = ToDoModel.Find<ToDoModel>(x => x.From > DateTime.MinValue && x.Duedate > DateTime.MinValue);

            foreach (ToDoModel toDo in toDos)
            {

                Console.WriteLine(toDo.Duedate.ToShortDateString());//締切日を表示
                Console.WriteLine(toDo.From.ToShortDateString());//開始日を表示
                Console.WriteLine(toDo.days_remaining.ToString());//残り日数を表示

                if (toDo.From < DateTime.Today)//既に開始日が経過している場合、締切日と本日の日付より残り日数を計算
                {
                    toDo.days_remaining = (toDo.Duedate - DateTime.Today).Days;
                }
                else//まだ開始日が経過していない場合は、締切日と開始日から残り日数を計算
                {
                    toDo.days_remaining = (toDo.Duedate - toDo.From).Days;
                }

                Console.WriteLine(toDo.days_remaining.ToString());//更新された残り日数を表示
                toDo.Update();//変更を更新

            }
        }
    }
}
