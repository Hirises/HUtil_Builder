using HUtil.Runtime.Observable;
using Unity.Properties;
using UnityEngine;
using System;
using HUtil.Runtime.UI;

namespace HUtilBuilder
{
    [GeneratePropertyBag]
    public partial record MainUIValue
    {
        [CreateProperty]
        [ViewModelValue(SyncronizeDirectionFlags.Both)]
        public ObservableProperty<string> title = new("Main Title");
    }
}