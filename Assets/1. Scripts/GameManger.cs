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
        playerData = new MainUIValue();
        viewRoot.Bind(playerData);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
