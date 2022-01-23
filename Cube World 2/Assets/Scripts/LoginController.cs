using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;


namespace Com.Haptor.Cube_World
{
    public class LoginController : MonoBehaviourPunCallbacks
    {
        #region Fields

        [SerializeField] InputField playerNameInput;
        [SerializeField] GameObject loginButton;
        [SerializeField] GameObject loadingIcon;
        bool isLoggingIn;
        public float loadingIconRotationSpeed = 100f;
        const string playerNamePrefKey = "PlayerName";

        #endregion

        #region Methods

        void Awake()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
        }

        void Start()
        {
            loginButton.SetActive(true);
            loadingIcon.SetActive(false);
            isLoggingIn = false;
            if (PlayerPrefs.HasKey(playerNamePrefKey))
            {
                playerNameInput.text = PlayerPrefs.GetString(playerNamePrefKey);
            }
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("Enter key pressed.");
                OnLoginButtonClicked();
            }
            if (isLoggingIn)
            {
                loadingIcon.transform.Rotate(Vector3.back * (loadingIconRotationSpeed * Time.deltaTime));
            }
        }

        public void OnLoginButtonClicked()
        {
            string playerName = playerNameInput.text;

            if (!string.IsNullOrEmpty(playerName))
            {
                if (!PhotonNetwork.IsConnected)
                {
                    loginButton.SetActive(false);
                    loadingIcon.SetActive(true);
                    isLoggingIn = true;
                    PlayerPrefs.SetString(playerNamePrefKey, playerName);
                    PhotonNetwork.LocalPlayer.NickName = playerName;
                    PhotonNetwork.ConnectUsingSettings();
                } else
                {
                    PlayerPrefs.SetString(playerNamePrefKey, playerName);
                    PhotonNetwork.LocalPlayer.NickName = playerName;
                    SceneManager.LoadScene("Home");
                }
            } else
            {
                Debug.Log("Player name is invalid.");
            }
        }

        #endregion

        #region Photon Callback Methods

        public override void OnDisconnected(DisconnectCause cause)
        {
            SceneManager.LoadScene("Login");
            Debug.Log("Player disconnected from the Internet.");
            Debug.LogWarningFormat("PUN Basics Tutorial/Launcher: OnDisconnected() was called by PUN with reason {0}", cause);
            loginButton.SetActive(true);
            loadingIcon.SetActive(false);
            isLoggingIn = false;
            loadingIcon.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }

        public override void OnConnected()
        {
            Debug.Log("We have connected to the internet!");
        }

        public override void OnConnectedToMaster()
        {
            Debug.Log(PhotonNetwork.LocalPlayer.NickName + " is connected to the Photon master server.");
            SceneManager.LoadScene("Home");
        }

        #endregion
    }
}

