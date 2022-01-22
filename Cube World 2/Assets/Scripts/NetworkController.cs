using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


namespace Com.Haptor.Cube_World
{
    public class NetworkController : MonoBehaviourPunCallbacks
    {
        void Awake()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
        }

        public override void OnConnected()
        {
            Debug.Log("We have connected to the internet!");
        }

        public override void OnConnectedToMaster()
        {
            Debug.Log(PhotonNetwork.LocalPlayer.NickName + " is connected to the Photon master server.");
        }

        public override void OnDisconnected(DisconnectCause cause)
        {
            Debug.Log("Player disconnected from the Internet.");
            Debug.LogWarningFormat("PUN Basics Tutorial/Launcher: OnDisconnected() was called by PUN with reason {0}", cause);

        }
    }
}

