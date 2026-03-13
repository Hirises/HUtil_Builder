using UnityEngine;

using HUtil.UI;
using HUtilBuilder;

public class GameManger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Sprite _deckIcon;
    void Start()
    {
        var mainUIValue = new MainUIValue();
        mainUIValue.title.Value = "Deck List";
        var deckInfoVM = new DeckInfoVM(_deckIcon);
        deckInfoVM.deckName.Value = "deck 1";
        deckInfoVM.cardCount.Value = 10;
        mainUIValue.deckList.Add(deckInfoVM);
        deckInfoVM = new DeckInfoVM(_deckIcon);
        deckInfoVM.deckName.Value = "deck 2";
        deckInfoVM.cardCount.Value = 20;
        mainUIValue.deckList.Add(deckInfoVM);
        deckInfoVM = new DeckInfoVM(_deckIcon);
        deckInfoVM.deckName.Value = "deck 3";
        deckInfoVM.cardCount.Value = 30;
        mainUIValue.deckList.Add(deckInfoVM);
        BindingContext.StaticBind(mainUIValue);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
