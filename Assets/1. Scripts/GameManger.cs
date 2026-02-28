using UnityEngine;

using HUtil.Runtime.UI;
using HUtilBuilder;

public class GameManger : MonoBehaviour
{
    public MainUIValue playerData;
    public ViewRoot viewRoot;

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
