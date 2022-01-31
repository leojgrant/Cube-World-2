using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGameUIController : MonoBehaviour
{
    #region Fields

    [SerializeField] GameObject game_Mode_UI;
    [SerializeField] GameObject map_Selection_UI;

    #endregion

    #region Methods

    public void onNextButtonClicked()
    {
        if (game_Mode_UI.activeSelf)
        {
            game_Mode_UI.SetActive(false);
            map_Selection_UI.SetActive(true);
        }
    }

    //public void resetCreateGameUI()
    //{
    //    game_Mode_UI.SetActive(true);
    //    map_Selection_UI.SetActive(false);
    //}

    #endregion
}
