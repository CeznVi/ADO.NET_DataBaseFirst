using ADO.NET_DataBaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            testedEntities testedEntities = new testedEntities();
            
            UserInfoModel userInfoModel = new UserInfoModel(testedEntities);

            userInfoModel.ShowAllData();

            //Изменения без сохранения в БД
            userInfoModel.ChangeUserFio(1, $"Admin{DateTime.Now.Minute} Adminovich{DateTime.Now.Second}");

            //Cохранение изменений в базе данных
            userInfoModel.SaveChanges();

            //Изменение ФИО с сохранением
            userInfoModel.ChangeUserFioWithSave(2, $"User Uzirov{DateTime.Now.Date.ToShortDateString()}");

            //Изменение даты рождения с сохранением
            userInfoModel.ChangeUserBirthDayWithSave(4, DateTime.Now.AddYears(50));

            Console.WriteLine("Информация в базе данных сохранена");
            Console.ReadKey();
            Console.Clear();

            ///Проверка изменений в базе данных
            testedEntities = null; 
            testedEntities = new testedEntities();
            userInfoModel = null;
            userInfoModel = new UserInfoModel(testedEntities);
            userInfoModel.ShowAllData();

        }




    }
}
