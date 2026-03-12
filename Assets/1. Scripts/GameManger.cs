using UnityEngine;

using HUtil.UI;
using HUtilBuilder;
using HUtil.Runtime.L10N;

public class GameManger : MonoBehaviour
{
    public MainUIValue playerData;
    public MonoResolver viewRoot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        L10NConverter.SetLocale("ko_KR");
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
