using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFoxDYPD3.Dtos
{
    public class XTTFromCADDtos
    {
    }


    /// <summary>
    /// 定义类:存放筛选,排序,且设置好信息后的配电箱回路信息
    /// 供后续插入函数使用
    /// </summary>
    public class XTTHuiluList_Dto : ObservableObject
    {
        private string _name;
        private List<XTTHuiluDto> _listHuilus;

        /// <summary>
        /// 所属配电箱的名称
        /// </summary>
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        public List<XTTHuiluDto> ListHuilus
        {
            get => _listHuilus;
            set => SetProperty(ref _listHuilus, value);
        }
    }

    /// <summary>
    /// 判断照明平面的是否正确编号程序的返回类，若正确返回一个class
    /// </summary>
    public class XTTHuiLuIsValidDto : ObservableObject
    {
        //string name, out string huilu, out double pe)

        private string _idGuihao;
        /// <summary>
        /// 所属配电箱的名称
        /// </summary>
        public string IdGuihao
        {
            get => _idGuihao;
            set => SetProperty(ref _idGuihao, value);
        }
        private string _pre;
        /// <summary>
        /// 所属配电箱的名称
        /// </summary>
        public string Pre
        {
            get => _pre;
            set => SetProperty(ref _pre, value);
        }
        private string _idHuilu;
        /// <summary>
        /// 回路编号
        /// </summary>
        public string IdHuilu
        {
            get => _idHuilu;
            set => SetProperty(ref _idHuilu, value);
        }

        private double _pe = 0;
        /// <summary>
        /// 回路功率
        /// </summary>
        public double Pe
        {
            get => _pe;
            set => SetProperty(ref _pe, value);
        }

        private string _PDXname;
        /// <summary>
        /// 子配电箱名称
        /// </summary>
        public string PDXName
        {
            get => _PDXname;
            set => SetProperty(ref _PDXname, value);
        }
        private bool _isValid = false;
        /// <summary>
        /// 此回路格式是否正确
        /// </summary>
        public bool IsValid
        {
            get => _isValid;
            set => SetProperty(ref _isValid, value);
        }

        //编号的形式
        //形式0为无效
        //形式1为 箱名+回路+功率
        //形式2为 箱名+回路
        //形式3为 箱名+多回路+功率
        //形式4为 箱名+回路+子配电箱+功率
        private int _mode = 0;
        /// <summary>
        /// 此回路格式是否正确
        /// </summary>
        public int Mode
        {
            get => _mode;
            set => SetProperty(ref _mode, value);
        }
    }

    /// <summary>
    /// 由风机水泵属性块=>提取的class
    /// </summary>
    public class XTTACDto
    {
        private double _pe;
        /// <summary>
        /// 功率
        /// </summary>
        public double Pe
        {
            get { return _pe; }
            set { _pe = value; }
        }
        private string _purpose;
        /// <summary>
        /// 风机功能及名称
        /// </summary>
        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }

        private string _changBeiYong;
        /// <summary>
        /// 用、备
        /// </summary>
        public string ChangBeiYong
        {
            get { return _changBeiYong; }
            set { _changBeiYong = value; }
        }
        private bool _xiaofang;
        /// <summary>
        /// 是否消防
        /// </summary>
        public bool XiaoFang
        {
            get { return _xiaofang; }
            set { _xiaofang = value; }
        }
        private string _name1;
        ///所属配电箱1（常用回路/单回路）编名称
        public string Name1
        {
            get { return _name1; }
            set { _name1 = value; }
        }
        private string _name2;
        /// <summary>
        /// 所属配电箱2（备用回路）名称
        /// </summary>
        public string Name2
        {
            get { return _name2; }
            set { _name2 = value; }
        }
        private string _circuitNumber1;
        /// <summary>
        /// 常用回路/单回路的回路编号
        /// </summary>
        public string CircuitNumber1
        {
            get { return _circuitNumber1; }
            set { _circuitNumber1 = value; }
        }
        private string _circuitNumber2;
        /// <summary>
        /// 备用回路的回路编号
        /// </summary>
        public string CircuitNumber2
        {
            get { return _circuitNumber2; }
            set { _circuitNumber2 = value; }
        }
        private string _strNum1;
        ///回路编号1的内容
        public string StrNum1
        {
            get { return _strNum1; }
            set { _strNum1 = value; }
        }
        private string _strNum2;
        ///回路编号2的内容
        public string StrNum2
        {
            get { return _strNum2; }
            set { _strNum2 = value; }
        }

        private string _acPDXName;
        ///风机控制箱的名称
        public string ACPDXName
        {
            get { return _acPDXName; }
            set { _acPDXName = value; }
        }

        private string _mode;
        /// <summary>
        /// 风机类型
        /// </summary>
        public string Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }
        private int _baMode = 0;
        /// <summary>
        /// BA的控制方式
        /// 0接入、1机电一体化、2接BA
        /// </summary>
        public int BAMode
        {
            get { return _baMode; }
            set { _baMode = value; }
        }







    }


}
