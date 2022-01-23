using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinGameUIController : MonoBehaviour
{
    #region Fields

    [SerializeField] GameObject free_For_All_Description;
    [SerializeField] GameObject cube_Fect_Description;
    [SerializeField] GameObject weeping_Cubes_Description;
    [SerializeField] GameObject ready_Set_Cube_Description;
    [SerializeField] GameObject cube_Poker_Description;
    [SerializeField] GameObject coming_Soon_Description;

    [SerializeField] GameObject unselectedFFAOutline;
    [SerializeField] GameObject unselectedCFOutline;
    [SerializeField] GameObject unselectedWCOutline;
    [SerializeField] GameObject unselectedRSCOutline;
    [SerializeField] GameObject unselectedCPOutline;
    [SerializeField] GameObject unselectedCSOutline;

    [SerializeField] GameObject glowingFFAOutline;
    [SerializeField] GameObject glowingCFOutline;
    [SerializeField] GameObject glowingWCOutline;
    [SerializeField] GameObject glowingRSCOutline;
    [SerializeField] GameObject glowingCPOutline;
    [SerializeField] GameObject glowingCSOutline;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        free_For_All_Description.SetActive(true);
        cube_Fect_Description.SetActive(false);
        weeping_Cubes_Description.SetActive(false);
        ready_Set_Cube_Description.SetActive(false);
        cube_Poker_Description.SetActive(false);
        coming_Soon_Description.SetActive(false);

        unselectedFFAOutline.SetActive(false);
        unselectedCFOutline.SetActive(true);
        unselectedWCOutline.SetActive(true);
        unselectedRSCOutline.SetActive(true);
        unselectedCPOutline.SetActive(true);
        unselectedCSOutline.SetActive(true);

        glowingFFAOutline.SetActive(true);
        glowingCFOutline.SetActive(false);
        glowingWCOutline.SetActive(false);
        glowingRSCOutline.SetActive(false);
        glowingCPOutline.SetActive(false);
        glowingCSOutline.SetActive(false);


}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onFreeForAllButtonClicked()
    {
        free_For_All_Description.SetActive(true);
        cube_Fect_Description.SetActive(false);
        weeping_Cubes_Description.SetActive(false);
        ready_Set_Cube_Description.SetActive(false);
        cube_Poker_Description.SetActive(false);
        coming_Soon_Description.SetActive(false);

        unselectedFFAOutline.SetActive(false);
        unselectedCFOutline.SetActive(true);
        unselectedWCOutline.SetActive(true);
        unselectedRSCOutline.SetActive(true);
        unselectedCPOutline.SetActive(true);
        unselectedCSOutline.SetActive(true);

        glowingFFAOutline.SetActive(true);
        glowingCFOutline.SetActive(false);
        glowingWCOutline.SetActive(false);
        glowingRSCOutline.SetActive(false);
        glowingCPOutline.SetActive(false);
        glowingCSOutline.SetActive(false);


    }

    public void onCubeFectButtonClicked()
    {
        free_For_All_Description.SetActive(false);
        cube_Fect_Description.SetActive(true);
        weeping_Cubes_Description.SetActive(false);
        ready_Set_Cube_Description.SetActive(false);
        cube_Poker_Description.SetActive(false);
        coming_Soon_Description.SetActive(false);

        unselectedFFAOutline.SetActive(true);
        unselectedCFOutline.SetActive(false);
        unselectedWCOutline.SetActive(true);
        unselectedRSCOutline.SetActive(true);
        unselectedCPOutline.SetActive(true);
        unselectedCSOutline.SetActive(true);

        glowingFFAOutline.SetActive(false);
        glowingCFOutline.SetActive(true);
        glowingWCOutline.SetActive(false);
        glowingRSCOutline.SetActive(false);
        glowingCPOutline.SetActive(false);
        glowingCSOutline.SetActive(false);
    }

    public void onWeepingCubesButtonClicked()
    {
        free_For_All_Description.SetActive(false);
        cube_Fect_Description.SetActive(false);
        weeping_Cubes_Description.SetActive(true);
        ready_Set_Cube_Description.SetActive(false);
        cube_Poker_Description.SetActive(false);
        coming_Soon_Description.SetActive(false);

        unselectedFFAOutline.SetActive(true);
        unselectedCFOutline.SetActive(true);
        unselectedWCOutline.SetActive(false);
        unselectedRSCOutline.SetActive(true);
        unselectedCPOutline.SetActive(true);
        unselectedCSOutline.SetActive(true);

        glowingFFAOutline.SetActive(false);
        glowingCFOutline.SetActive(false);
        glowingWCOutline.SetActive(true);
        glowingRSCOutline.SetActive(false);
        glowingCPOutline.SetActive(false);
        glowingCSOutline.SetActive(false);
    }

    public void onReadySetCubeButtonClicked()
    {
        free_For_All_Description.SetActive(false);
        cube_Fect_Description.SetActive(false);
        weeping_Cubes_Description.SetActive(false);
        ready_Set_Cube_Description.SetActive(true);
        cube_Poker_Description.SetActive(false);
        coming_Soon_Description.SetActive(false);

        unselectedFFAOutline.SetActive(true);
        unselectedCFOutline.SetActive(true);
        unselectedWCOutline.SetActive(true);
        unselectedRSCOutline.SetActive(false);
        unselectedCPOutline.SetActive(true);
        unselectedCSOutline.SetActive(true);

        glowingFFAOutline.SetActive(false);
        glowingCFOutline.SetActive(false);
        glowingWCOutline.SetActive(false);
        glowingRSCOutline.SetActive(true);
        glowingCPOutline.SetActive(false);
        glowingCSOutline.SetActive(false);
    }
    public void onCubePokerButtonClicked()
    {
        free_For_All_Description.SetActive(false);
        cube_Fect_Description.SetActive(false);
        weeping_Cubes_Description.SetActive(false);
        ready_Set_Cube_Description.SetActive(false);
        cube_Poker_Description.SetActive(true);
        coming_Soon_Description.SetActive(false);

        unselectedFFAOutline.SetActive(true);
        unselectedCFOutline.SetActive(true);
        unselectedWCOutline.SetActive(true);
        unselectedRSCOutline.SetActive(true);
        unselectedCPOutline.SetActive(false);
        unselectedCSOutline.SetActive(true);

        glowingFFAOutline.SetActive(false);
        glowingCFOutline.SetActive(false);
        glowingWCOutline.SetActive(false);
        glowingRSCOutline.SetActive(false);
        glowingCPOutline.SetActive(true);
        glowingCSOutline.SetActive(false);
    }
    public void onComingSoonButtonClicked()
    {
        free_For_All_Description.SetActive(false);
        cube_Fect_Description.SetActive(false);
        weeping_Cubes_Description.SetActive(false);
        ready_Set_Cube_Description.SetActive(false);
        cube_Poker_Description.SetActive(false);
        coming_Soon_Description.SetActive(true);

        unselectedFFAOutline.SetActive(true);
        unselectedCFOutline.SetActive(true);
        unselectedWCOutline.SetActive(true);
        unselectedRSCOutline.SetActive(true);
        unselectedCPOutline.SetActive(true);
        unselectedCSOutline.SetActive(false);

        glowingFFAOutline.SetActive(false);
        glowingCFOutline.SetActive(false);
        glowingWCOutline.SetActive(false);
        glowingRSCOutline.SetActive(false);
        glowingCPOutline.SetActive(false);
        glowingCSOutline.SetActive(true);
    }
}
