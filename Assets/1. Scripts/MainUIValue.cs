using HUtil.Observable;
using UnityEngine;

namespace HUtilBuilder
{
    public record MainUIValue
    {
        public ObservableProperty<string> title = new("Main Title");
    }
}