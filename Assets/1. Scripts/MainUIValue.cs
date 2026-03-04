using HUtil.Runtime.Observable;
using Unity.Properties;
using UnityEngine;
using System;
using HUtil.Runtime.UI;

namespace HUtilBuilder
{
    [GeneratePropertyBag, Serializable]
    public partial record MainUIValue
    {
        [CreateProperty, SerializeField]
        [ViewModelValue(SyncronizeDirectionFlags.Both)]
        public ObservableProperty<string> title = new("Main Title");
    }
}