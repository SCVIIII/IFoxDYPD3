using CommunityToolkit.Mvvm.ComponentModel;
using IFoxDYPD3.Dtos;
namespace IFoxDYPD3.WPF
{
    public partial class XTTViewModel2 : ObservableObject
    {

        [ObservableProperty]
        private List<string> _items_Huilu_Purpose;

        public XTTViewModel2(List<XTTHuiluDto> XTTHuilus, List<XTTACDto> XTTACHuilus)
        {
            var num1 = XTTHuilus.Count();
            var num2 = XTTACHuilus.Count();
        }
    }
}
