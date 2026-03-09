using UnityEngine;

using HUtil.UI;
using HUtilBuilder;

public class GameManger : MonoBehaviour
{
    public MainUIValue playerData;
    public UIComponent viewRoot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var subUIValue = new SubUIValue();
        BindingContext.StaticBind(subUIValue);
        playerData = new MainUIValue(subUIValue);
        viewRoot.ManualBind(playerData);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
