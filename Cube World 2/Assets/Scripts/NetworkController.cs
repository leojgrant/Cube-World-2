using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


namespace Com.Haptor.Cube_World
{
    public class NetworkController : MonoBehaviourPunCallbacks
    {
        #region Fields

        #endregion

        #region Methods

        void Awake()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
        }



        #endregion
    }
}

