using System;
using HUtil.Runtime.Observable;
using HUtil.Runtime.Command;
using HUtil.UI;
using Unity.Properties;
using UnityEngine;

namespace HUtilBuilder
{
    [GeneratePropertyBag]
    public class DeckInfoVM : IViewModel
    {
        [CreateProperty, Bindable]
        public ObservableProperty<string> deckName;

        [CreateProperty, Bindable]
        public ObservableProperty<int> cardCount;

        [CreateProperty, Bindable]
        public ObservableProperty<Sprite> deckIcon;

        public DeckInfoVM(Sprite deckIcon){
            deckName = new ObservableProperty<string>("Deck Name");
            cardCount = new ObservableProperty<int>(0);
            this.deckIcon = new ObservableProperty<Sprite>(deckIcon);
        }
    }
}