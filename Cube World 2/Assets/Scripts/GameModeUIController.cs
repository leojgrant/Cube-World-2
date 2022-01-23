using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeUIController : MonoBehaviour
{
    #region Fields

    [SerializeField] GameObject leftArrow;
    [SerializeField] GameObject rightArrow;
    [SerializeField] GameObject page_One;
    [SerializeField] GameObject page_Two;

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
    [SerializeField] GameObject unselectedCS1Outline;
    [SerializeField] GameObject unselectedCS2Outline;
    [SerializeField] GameObject unselectedCS3Outline;
    [SerializeField] GameObject unselectedCS4Outline;
    [SerializeField] GameObject unselectedCS5Outline;
    [SerializeField] GameObject unselectedCS6Outline;

    [SerializeField] GameObject glowingFFAOutline;
    [SerializeField] GameObject glowingCFOutline;
    [SerializeField] GameObject glowingWCOutline;
    [SerializeField] GameObject glowingRSCOutline;
    [SerializeField] GameObject glowingCPOutline;
    [SerializeField] GameObject glowingCSOutline;
    [SerializeField] GameObject glowingCS1Outline;
    [SerializeField] GameObject glowingCS2Outline;
    [SerializeField] GameObject glowingCS3Outline;
    [SerializeField] GameObject glowingCS4Outline;
    [SerializeField] GameObject glowingCS5Outline;
    [SerializeField] GameObject glowingCS6Outline;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        rightArrow.SetActive(true);
        leftArrow.SetActive(false);
        page_One.SetActive(true);
        page_Two.SetActive(false);

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
        unselectedCS1Outline.SetActive(true);
        unselectedCS2Outline.SetActive(true);
        unselectedCS3Outline.SetActive(true);
        unselectedCS4Outline.SetActive(true);
        unselectedCS5Outline.SetActive(true);
        unselectedCS6Outline.SetActive(true);

        glowingFFAOutline.SetActive(true);
        glowingCFOutline.SetActive(false);
        glowingWCOutline.SetActive(false);
        glowingRSCOutline.SetActive(false);
        glowingCPOutline.SetActive(false);
        glowingCSOutline.SetActive(false);
        glowingCS1Outline.SetActive(false);
        glowingCS2Outline.SetActive(false);
        glowingCS3Outline.SetActive(false);
        glowingCS4Outline.SetActive(false);
        glowingCS5Outline.SetActive(false);
        glowingCS6Outline.SetActive(false);
    }

    public void onRightArrowClicked()
    {
        leftArrow.SetActive(true);
        rightArrow.SetActive(false);
        page_One.SetActive(false);
        page_Two.SetActive(true);
    }

    public void onLeftArrowClicked()
    { 
        leftArrow.SetActive(false);
        rightArrow.SetActive(true);
        page_One.SetActive(true);
        page_Two.SetActive(false);
    }

    public void onFreeForAllButtonClicked()
    {
        if (page_One.activeSelf)
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
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowingFFAOutline.SetActive(true);
            glowingCFOutline.SetActive(false);
            glowingWCOutline.SetActive(false);
            glowingRSCOutline.SetActive(false);
            glowingCPOutline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
        else
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
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(false);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowingFFAOutline.SetActive(false);
            glowingCFOutline.SetActive(false);
            glowingWCOutline.SetActive(false);
            glowingRSCOutline.SetActive(false);
            glowingCPOutline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(true);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
    }

    public void onCubeFectButtonClicked()
    {
        if (page_One.activeSelf == true)
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
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowingFFAOutline.SetActive(false);
            glowingCFOutline.SetActive(true);
            glowingWCOutline.SetActive(false);
            glowingRSCOutline.SetActive(false);
            glowingCPOutline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
        else
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
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(false);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowingFFAOutline.SetActive(false);
            glowingCFOutline.SetActive(false);
            glowingWCOutline.SetActive(false);
            glowingRSCOutline.SetActive(false);
            glowingCPOutline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(true);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
    }

    public void onWeepingCubesButtonClicked()
    {
        if (page_One.activeSelf)
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
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowingFFAOutline.SetActive(false);
            glowingCFOutline.SetActive(false);
            glowingWCOutline.SetActive(true);
            glowingRSCOutline.SetActive(false);
            glowingCPOutline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
        else
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
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(false);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowingFFAOutline.SetActive(false);
            glowingCFOutline.SetActive(false);
            glowingWCOutline.SetActive(false);
            glowingRSCOutline.SetActive(false);
            glowingCPOutline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(true);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
    }

    public void onReadySetCubeButtonClicked()
    {
        if (page_One.activeSelf)
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
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowingFFAOutline.SetActive(false);
            glowingCFOutline.SetActive(false);
            glowingWCOutline.SetActive(false);
            glowingRSCOutline.SetActive(true);
            glowingCPOutline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
        else
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
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(false);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowingFFAOutline.SetActive(false);
            glowingCFOutline.SetActive(false);
            glowingWCOutline.SetActive(false);
            glowingRSCOutline.SetActive(false);
            glowingCPOutline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(true);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
    }

    public void onCubePokerButtonClicked()
    {
        if (page_One.activeSelf)
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
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowingFFAOutline.SetActive(false);
            glowingCFOutline.SetActive(false);
            glowingWCOutline.SetActive(false);
            glowingRSCOutline.SetActive(false);
            glowingCPOutline.SetActive(true);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
        else
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
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(false);
            unselectedCS6Outline.SetActive(true);

            glowingFFAOutline.SetActive(false);
            glowingCFOutline.SetActive(false);
            glowingWCOutline.SetActive(false);
            glowingRSCOutline.SetActive(false);
            glowingCPOutline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(true);
            glowingCS6Outline.SetActive(false);
        }
    }

    public void onComingSoonButtonClicked()
    {
        if (page_One.activeSelf)
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
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowingFFAOutline.SetActive(false);
            glowingCFOutline.SetActive(false);
            glowingWCOutline.SetActive(false);
            glowingRSCOutline.SetActive(false);
            glowingCPOutline.SetActive(false);
            glowingCSOutline.SetActive(true);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
        else
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
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(false);

            glowingFFAOutline.SetActive(false);
            glowingCFOutline.SetActive(false);
            glowingWCOutline.SetActive(false);
            glowingRSCOutline.SetActive(false);
            glowingCPOutline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(true);
        }
    }
}
