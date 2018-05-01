using UnityEngine;
using UnityEngine.UI;

public enum AppType
{
    Client,
    Server
}

public class AppController : MonoBehaviour
{
    [SerializeField]
    private Text _txtAppType;
    [SerializeField]
    private AppType _appType;

    private void Update()
    {
        _txtAppType.text = _appType.ToString();   
    }
}