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

        [CreateProperty, Bindable(BindingDirectionFlags.ToData)]
        public ObservableProperty<string> description;

        [CreateProperty, Bindable(BindingDirectionFlags.ToUI)]
        public ObservableProperty<int> intValue;

        [CreateProperty, Bindable(BindingDirectionFlags.Both)]
        public ObservableProperty<GameObject> GO;

        [CreateProperty, Bindable]
        public RelayCommand awesomeInternalLogic;

        [CreateProperty, Bindable(BindingDirectionFlags.Both)]
        public ObservableList<IViewModel> ViewModel;

        [CreateProperty, Bindable]
        public ObservableProperty<bool> onoff;

        public MainUIValue(SubUIValue subUIValue){
            title = new ObservableProperty<string>("Main Title");
            description = new ObservableProperty<string>("Main Description");
            intValue = new ObservableProperty<int>(100);
            GO = new ObservableProperty<GameObject>(null);
            ViewModel = new ObservableList<IViewModel>();
            ViewModel.Add(subUIValue);
            awesomeInternalLogic = new RelayCommand(AwesomeInternalLogic);
            onoff = new ObservableProperty<bool>(false);
        }

        private void AwesomeInternalLogic(){
            Debug.Log("AwesomeInternalLogic");
            title.Value = "AwesomeInternalLogic";;
            ViewModel.Add(new SubUIValue());
            onoff.Value = !onoff.Value;
        }
    }
}