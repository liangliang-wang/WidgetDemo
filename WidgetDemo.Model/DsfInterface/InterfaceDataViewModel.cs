using System.Collections.Generic;

namespace TC.Vacations.Entity.DsfInterface
{
    public class InterfaceDataViewModel
    {
        public InterfaceDataViewModel()
        {
            Methods = new List<MethodDataViewMode>();
        }

        public string ServiceName { set; get; }

        public string UriName { set; get; }

        public List<MethodDataViewMode> Methods { set; get; }
    }
}
