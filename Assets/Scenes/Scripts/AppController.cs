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

    private void Start()
    {
#if CLIENT_BUILD
        _appType = AppType.Client;
#elif SERVER_BUILD
        _appType = AppType.Server;
#endif
    }

    private void Update()
    {
        _txtAppType.text = _appType.ToString();   
    }
}