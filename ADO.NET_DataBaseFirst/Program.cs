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



        }



    }
}
