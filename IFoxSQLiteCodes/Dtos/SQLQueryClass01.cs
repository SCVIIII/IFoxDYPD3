#nullable enable
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFoxSQLiteCodes.Dtos
{

    public partial class SQLCableQueryClass01 : ObservableObject
    {
        [ObservableProperty]
        private int _idkey; //主键
        [ObservableProperty]
        private double _izd; //整定电流
        [ObservableProperty]
        private string? _byj380; //三相电线
        [ObservableProperty]
        private string? _byj220; //单相电线
        [ObservableProperty]
        private string? _yjy380; //三相电缆
        [ObservableProperty]
        private string? _yjy220; //单相电缆
        [ObservableProperty]
        private string? _scbyj380; //三相电线套管
        [ObservableProperty]
        private string? _scbyj220; //单相电线套管
        [ObservableProperty]
        private string? _scyjy380; //三相电缆套管
        [ObservableProperty]
        private string? _scyjy220; //单相电缆套管
    }


    public partial class SQL_CircuitBreaker_QueryClass01 : ObservableObject
    {
        [ObservableProperty]
        private int _idkey; //主键
        [ObservableProperty]
        private double? _izd; //塑壳壳架
        [ObservableProperty]
        private string? _mcb_shell; //塑壳壳架
        [ObservableProperty]
        private string? _mcb_fas; //塑壳附件：切非
        [ObservableProperty]
        private string? _mcb_ma; //消防MA的附件型号
        [ObservableProperty]
        private string? _mccb_shell; //微断的型号
        [ObservableProperty]
        private string? _rcb0_shell; //RCB0的型号
        [ObservableProperty]
        private string? _rcb0_suf; //RCB0的附件型号

    }


}
