using HUtil.Runtime.Observable;
using Unity.Properties;
using UnityEngine;
using System;
using HUtil.Runtime.UI;
using HUtil.Runtime.Command;

namespace HUtilBuilder
{
    [GeneratePropertyBag, Serializable]
    public partial record MainUIValue : IViewModel
    {
        [CreateProperty, SerializeField]
        [ViewModelValue(SyncronizeDirectionFlags.Both)]
        public ObservableProperty<string> title;

        [CreateProperty, SerializeField]
        [ViewModelValue(SyncronizeDirectionFlags.ToData)]
        public ObservableProperty<string> descriptoin;

        [CreateProperty, SerializeField]
        [ViewModelValue(SyncronizeDirectionFlags.ToUI)]
        public ObservableProperty<int> intValue;

        [CreateProperty, SerializeField]
        [ViewModelValue(SyncronizeDirectionFlags.Both)]
        public ObservableProperty<GameObject> GO;

        [CreateProperty, SerializeField]
        public CommandBase awesomeInternalLogic;

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