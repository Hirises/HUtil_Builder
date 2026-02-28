using HUtil.Runtime.Observable;
using Unity.Properties;
using UnityEngine;
using System;

namespace HUtilBuilder
{
    [GeneratePropertyBag, Serializable]
    public partial record MainUIValue
    {
        [CreateProperty, SerializeField]
        public ObservableProperty<string> title = new("Main Title");
    }
}