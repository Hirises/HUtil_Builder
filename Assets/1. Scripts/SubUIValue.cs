using System;
using HUtil.Runtime.Observable;
using HUtil.UI;
using Unity.Properties;

namespace HUtilBuilder
{
    [GeneratePropertyBag]
    public partial record SubUIValue : IViewModel
    {
        [CreateProperty, Bindable(BindDirectionFlags.ToUI)]
        public ObservableProperty<string> timeStamp;

        [CreateProperty, Bindable]
        public ObservableProperty<string> name;

        public SubUIValue(){
            timeStamp = new ObservableProperty<string>("2026-03-09 10:00:00");
            name = new ObservableProperty<string>("Hirises");
        }
    }
}