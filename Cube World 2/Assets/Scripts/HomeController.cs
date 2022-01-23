using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;


namespace Com.Haptor.Cube_World
{
    public class HomeController : MonoBehaviourPunCallbacks
    {
        #region Fields

        [SerializeField] Text player_Name;
        [SerializeField] GameObject join_Game_UI;
        [SerializeField] GameObject create_Game_UI;
        [SerializeField] GameObject edit_Cube_UI;

        #endregion

        #region Methods

        void Start()
        {
            Debug.Log(PhotonNetwork.LocalPlayer.NickName + " has entered the home screen.");
            player_Name.text = PhotonNetwork.LocalPlayer.NickName;
            join_Game_UI.SetActive(true);
            create_Game_UI.SetActive(false);
            edit_Cube_UI.SetActive(false);
        }

        public void onChangeNameButtonClicked()
        {
            SceneManager.LoadScene("Login");
        }

        public void onJoinGameButtonClicked()
        {
            join_Game_UI.SetActive(true);
            create_Game_UI.SetActive(false);
            edit_Cube_UI.SetActive(false);
        }

        public void onCreateGameButtonClicked()
        {
            join_Game_UI.SetActive(false);
            create_Game_UI.SetActive(true);
            edit_Cube_UI.SetActive(false);
        }

        public void onEditCubeButtonClicked()
        {
            join_Game_UI.SetActive(false);
            create_Game_UI.SetActive(false);
            edit_Cube_UI.SetActive(true);
        }

        #endregion

        #region Photon Callback Methods

        public override void OnDisconnected(DisconnectCause cause)
        {
            SceneManager.LoadScene("Login");
            Debug.Log("Player disconnected from the Internet.");
            Debug.LogWarningFormat("PUN Basics Tutorial/Launcher: OnDisconnected() was called by PUN with reason {0}", cause);
        }

        #endregion
    }
}

