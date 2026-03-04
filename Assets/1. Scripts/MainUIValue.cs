using HUtil.Runtime.Observable;
using Unity.Properties;
using UnityEngine;
using System;
using HUtil.Runtime.UI;
using HUtil.Runtime.Command;

namespace HUtilBuilder
{
    [GeneratePropertyBag, Serializable]
    public partial record MainUIValue
    {
        [CreateProperty, SerializeField]
        [ViewModelValue(SyncronizeDirectionFlags.Both)]
        public ObservableProperty<string> title;

        [CreateProperty, SerializeField]
        public CommandBase awesomeInternalLogic;

        public MainUIValue(){
            title = new ObservableProperty<string>("Main Title");
            awesomeInternalLogic = new RelayCommand(AwesomeInternalLogic);
        }

        private void AwesomeInternalLogic(){
            Debug.Log("AwesomeInternalLogic");
            title.Value = "AwesomeInternalLogic";
        }
    }
}