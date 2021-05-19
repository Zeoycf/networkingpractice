using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLobby : MonoBehaviour
{
    [SerializeField] private GameObject buttons = null;
    public void HostLobby()
    {
        buttons.SetActive(false);

        SteamMatchMaking.CreatLobby(ELobby.Type);
    }
}
