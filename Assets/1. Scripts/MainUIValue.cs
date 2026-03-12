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

        [CreateProperty, Bindable]
        public ObservableList<IViewModel> deckList = new ObservableList<IViewModel>();

        [CreateProperty, Bindable]
        public CommandBase addDeckCommand;

        public MainUIValue(){
            title = new ObservableProperty<string>("Main Title");
            addDeckCommand = new RelayCommand(AddDeck);
        }

        private void AddDeck(){
            var deckInfoVM = new DeckInfoVM(Resources.Load<Sprite>("DeckIcon"));
            deckInfoVM.deckName.Value = "덱 " + (deckList.Count + 1);
            deckInfoVM.cardCount.Value = deckList.Count;
            deckList.Add(deckInfoVM);
        }
    }
}