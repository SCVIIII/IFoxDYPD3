using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFoxDYPD3.PUB
{



    public static class PUBCreateDatas
    {

        /// <summary>
        /// 断路器品牌
        /// </summary>
        /// <returns></returns>
        public static List<string> Cre_CircuitBreaker_Brand()
        {
            var list = new List<string> { "施耐德", "国标", "ABB", "良信", "正泰", "常熟"};
            return list;
        }

        /// <summary>
        /// 创建回路类型
        /// 服务对象：XTTViewModel及Dto
        /// 序列：照明m、插座c、智能照明mk、空调插座k、A型应急照明ek、子配电箱N、风机控制箱N/D、风机回路d
        /// </summary>
        /// <returns></returns>
        public static List<string> Cre_Huilu_Purpose()
        {
            var list = new List<string> { "照明", "插座", "智能照明", "空调插座", "子配电箱", "A型应急照明", "风机控制箱", "风机回路" };
            return list;
        }


        /// <summary>
        /// 创建保护套管类型
        /// 服务对象：XTTViewModel
        /// </summary>
        /// <returns></returns>
        public static List<string> Cre_Taoguan_Type()
        {
            var list = new List<string> { "JDG", "SC" };
            return list;
        }

        /// <summary>
        /// 所有的导体类型
        /// 服务对象：XTTViewModel
        /// </summary>
        /// <returns></returns>
        public static List<string> Cre_CableType_Dianxian_And_Dianlan()
        {
            var list = new List<string> { "WDZ-BYJ", "WDZ-YJY", "WDZN-BYJ", "BTLY", "WDZN-YJY", "WDZN-KYJY", "WDZN-RYJS" };
            return list;
        }

        /// <summary>
        /// 以下类型的导体为电线
        /// 服务对象：Dto
        /// </summary>
        /// <returns></returns>
        public static List<string> CreateListCableType_Dianxian()
        {
            List<string> list = new List<string> { "WDZ-BYJ", "WDZN-BYJ", "WDZN-RYJS" };
            return list;
        }

        /// <summary>
        /// 以下类型的导体为电缆
        /// </summary>
        /// <returns></returns>
        public static List<string> CreateListCableType_Dianlan()
        {
            List<string> list = new List<string> { "WDZ-YJY", "BTLY", "WDZN-YJY", "WDZN-KYJY" };
            return list;
        }

        //ircuitBreaker_Type
        public static List<string> Cre_CircuitBreaker_Type()
        {
            //所有的断路器类型
            //"微断C/1P"
            //"RCB0-4P"
            var list = new List<string>
            {
                "微断1P","微断2P","微断3P",
                "RCB0-2P", "RCB0-4P",
                "塑壳3P" ,"塑壳3P/MA","塑壳3P/MX+OF"
            };
            return list;
        }

        /// <summary>
        /// 全部开关类型对应的相位
        /// 服务对象：XTTViewModel
        /// </summary>
        /// <returns></returns>
        public static List<string> Cre_CableType_Danxiang_And_Sanxiang()
        {
            var list = new List<string> { "1P", "2P", "RCB0-2P", "3P", "4P", "RCB0-4P", "iC65/C/1P", "iC65/C/2P", "iC65/D/1P", "iC65/D/2P", "NSX", "NSX/Fas", "NSX/MA" };
            return list;
        }

        /// <summary>
        /// 以下类型的相位为单相
        /// </summary>
        /// <returns></returns>
        public static List<string> Cre_CircuitBreaker_Type_220()
        {
            List<string> list = new List<string> { "微断1P", "微断2P", "RCB0-2P" };
            return list;
        }

        /// <summary>
        /// 以下类型的相位为三相
        /// </summary>
        /// <returns></returns>
        public static List<string> Cre_CircuitBreaker_Type_380()
        {
            List<string> list = new List<string> { "微断3P", "RCB0-4P", "塑壳3P", "塑壳3P/MA", "塑壳3P/MX+OF" };
            return list;
        }



    }
}
