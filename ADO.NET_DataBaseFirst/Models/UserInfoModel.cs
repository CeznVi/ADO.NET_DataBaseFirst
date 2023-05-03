using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_DataBaseFirst.Models
{
    class UserInfoModel
    {

        private testedEntities _dbContext;
        private DbSet<usersInfo> _userInfo;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="dbContext"></param>
        public UserInfoModel(testedEntities dbContext)
        {
            _dbContext = dbContext;
            _userInfo = _dbContext.usersInfo;
        }

        /*-----------------------  Методы  -----------------------*/

        /// <summary>
        /// Показать все данные
        /// </summary>
        public void ShowAllData()
        {
            foreach (usersInfo oneUserInfo in _userInfo)
            {
                Console.WriteLine(
                    $"\n\tId: {oneUserInfo.Id}; " +
                    $"\n\tFio: {oneUserInfo.fio}; " +
                    $"\n\tBirthDate: {oneUserInfo.birthDate.ToShortDateString()};" +
                    $"\n\tInn: {oneUserInfo.inn};" +
                    $"\n\tGender: {oneUserInfo.gender};" +
                    $"\n\tUserId: {oneUserInfo.userId}.");
            }
        }

        /// <summary>
        /// Изменить ФИО пользователя
        /// </summary>
        /// <param name="id">Айди пользователя которого необходимо изменить</param>
        /// <param name="newFio">Новое ФИО</param>
        public void ChangeUserFio(int id, string newFio)
        {
            _userInfo.FirstOrDefault(u => u.Id == id).fio = newFio;
        }

        /// <summary>
        /// Изменить ФИО пользователя с сохранением данных
        /// </summary>
        /// <param name="id">Айди пользователя которого необходимо изменить</param>
        /// <param name="newFio">Новое ФИО</param>
        public void ChangeUserFioWithSave(int id, string newFio)
        {
            _userInfo.FirstOrDefault(u => u.Id == id).fio = newFio;
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Сохранить изменения 
        /// </summary>
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Изменить день рождения пользователя с сохранением данных
        /// </summary>
        /// <param name="id">Айди пользователя которого необходимо изменить</param>
        /// <param name="newDt">Новая дата рожденич</param>
        public void ChangeUserBirthDayWithSave(int id, DateTime newDt)
        {
            _userInfo.FirstOrDefault(u => u.Id == id).birthDate = newDt;
        }
    }
}
