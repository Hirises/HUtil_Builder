using Aya.DataBinding;
using UnityEngine;

public class GameManger : MonoBehaviour
{

    [SerializeField] public string MainUIValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var container = DataContainer.GetContainer("MainModule");

        UBind.BindSource<string>("Title", () => MainUIValue);
        UBind.BindTarget<string>("Title", value => MainUIValue = value);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
