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

        public void ChangeUserFio(int id, string newFio)
        {
            
        }

    }
}
