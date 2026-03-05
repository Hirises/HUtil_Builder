using HUtil.Runtime.Observable;
using Unity.Properties;
using UnityEngine;
using System;
using HUtil.UI;
using HUtil.Runtime.Command;

namespace HUtilBuilder
{
    [GeneratePropertyBag]
    public partial record MainUIValue : IViewModel
    {
        [CreateProperty, Bindable]
        public ObservableProperty<string> title;

        [CreateProperty, Bindable(BindDirectionFlags.ToData)]
        public ObservableProperty<string> descriptoin;

        [CreateProperty, Bindable(BindDirectionFlags.ToUI)]
        public ObservableProperty<int> intValue;

        [CreateProperty, Bindable(BindDirectionFlags.Both)]
        public ObservableProperty<GameObject> GO;

        [CreateProperty, Bindable]
        public RelayCommand awesomeInternalLogic;

        public MainUIValue(){
            title = new ObservableProperty<string>("Main Title");
            descriptoin = new ObservableProperty<string>("Main Description");
            intValue = new ObservableProperty<int>(100);
            GO = new ObservableProperty<GameObject>(null);
            awesomeInternalLogic = new RelayCommand(AwesomeInternalLogic);
        }

        private void AwesomeInternalLogic(){
            Debug.Log("AwesomeInternalLogic");
            title.Value = "AwesomeInternalLogic";
        }
    }
}