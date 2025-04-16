using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IFOXSQLiteCodes01.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace IFOXSQLiteCodes01
{
    public partial class MainWindowViewmodel: ObservableObject
    {
        // Define your properties and commands here
        [ObservableProperty]
        private List<SQLCableQueryClass01> _itmesCable;

        [ObservableProperty]
        private SQLCableQueryClass01 _itmesQuery;

        [ObservableProperty]
        private SQL_CircuitBreaker_QueryClass01 _itmesQuery_Circuit;

        public RelayCommand<string> MyCommand { get; }

        public MainWindowViewmodel() 
        {
            // Initialize your properties and commands here
            // For example:
            // MyProperty = "Initial Value";
            MyCommand = new RelayCommand<string>(MyCommandExecute);
            ItmesCable = new List<SQLCableQueryClass01>();
            ItmesQuery = new SQLCableQueryClass01();
            ItmesQuery_Circuit=new SQL_CircuitBreaker_QueryClass01();
            ItmesQuery.Izd = 20;


        }

        private void MyCommandExecute(string obj)
        {
            if(obj =="查询")
            {
                double varIn;
                var res = new SQLCableQueryClass01();

                //if (double.TryParse(obj, out varIn))
                if (true)

                {
                    varIn = ItmesQuery.Izd;
                    res = IFOXSQLiteCodes01.Query.SQLQueryCable.SQL_Query_Cable01(varIn);
                    if (!string.IsNullOrEmpty(res.Byj380)) { ItmesQuery.Byj380 = res.Byj380; }
                    if (!string.IsNullOrEmpty(res.Yjy220)) { ItmesQuery.Yjy220 = res.Yjy220; }
                    MessageBox.Show("查询完成");

                }
                
                else
                {
                    MessageBox.Show("请输入有效的数字。", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            else if (obj == "查询断路器")
            {
                double varIn;
                var res2 = new SQL_CircuitBreaker_QueryClass01();
                string SQL_Name = "schneider";
                varIn = ItmesQuery.Izd;
                res2 = IFOXSQLiteCodes01.Query.SQLQueryCircuitBreaker.SQL_Query_CircuitBreaker01(SQL_Name,varIn);
                if (!string.IsNullOrEmpty(res2.Mcb_shell)) { ItmesQuery_Circuit.Mcb_shell = res2.Mcb_shell; }
                if (!string.IsNullOrEmpty(res2.Mccb_shell)) { ItmesQuery_Circuit.Mccb_shell = res2.Mccb_shell; }
                MessageBox.Show("查询完成");


            }
        }
    }
}
