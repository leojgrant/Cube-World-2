using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;


namespace Com.Haptor.Cube_World
{
    public class LoginController : MonoBehaviourPunCallbacks
    {
        #region Fields

        [SerializeField] InputField playerNameInput;

        #endregion

        #region Methods

        void Awake()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
        }

        public void OnLoginButtonClicked()
        {
            string playerName = playerNameInput.text;

            if (!string.IsNullOrEmpty(playerName))
            {
                if (!PhotonNetwork.IsConnected)
                {
                    PhotonNetwork.LocalPlayer.NickName = playerName;
                    PhotonNetwork.ConnectUsingSettings();
                }
            } else
            {
                Debug.Log("Player name is invalid.");
            }
        }

        #endregion
    }
}

