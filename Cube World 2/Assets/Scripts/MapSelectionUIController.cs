using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelectionUIController : MonoBehaviour
{
    #region Fields

    [SerializeField] GameObject leftArrow;
    [SerializeField] GameObject rightArrow;
    [SerializeField] GameObject page_One;
    [SerializeField] GameObject page_Two;

    [SerializeField] GameObject Office_Description;
    [SerializeField] GameObject Castle_Description;
    [SerializeField] GameObject School_Description;
    [SerializeField] GameObject Island_Description;
    [SerializeField] GameObject House_Description;
    [SerializeField] GameObject coming_Soon_Description;

    [SerializeField] GameObject unselected_O_Outline;
    [SerializeField] GameObject unselected_C_Outline;
    [SerializeField] GameObject unselected_S_Outline;
    [SerializeField] GameObject unselected_I_Outline;
    [SerializeField] GameObject unselected_H_Outline;
    [SerializeField] GameObject unselectedCSOutline;
    [SerializeField] GameObject unselectedCS1Outline;
    [SerializeField] GameObject unselectedCS2Outline;
    [SerializeField] GameObject unselectedCS3Outline;
    [SerializeField] GameObject unselectedCS4Outline;
    [SerializeField] GameObject unselectedCS5Outline;
    [SerializeField] GameObject unselectedCS6Outline;

    [SerializeField] GameObject glowing_O_Outline;
    [SerializeField] GameObject glowing_C_Outline;
    [SerializeField] GameObject glowing_S_Outline;
    [SerializeField] GameObject glowing_I_Outline;
    [SerializeField] GameObject glowing_H_Outline;
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

        Office_Description.SetActive(true);
        Castle_Description.SetActive(false);
        School_Description.SetActive(false);
        Island_Description.SetActive(false);
        House_Description.SetActive(false);
        coming_Soon_Description.SetActive(false);

        unselected_O_Outline.SetActive(false);
        unselected_C_Outline.SetActive(true);
        unselected_S_Outline.SetActive(true);
        unselected_I_Outline.SetActive(true);
        unselected_H_Outline.SetActive(true);
        unselectedCSOutline.SetActive(true);
        unselectedCS1Outline.SetActive(true);
        unselectedCS2Outline.SetActive(true);
        unselectedCS3Outline.SetActive(true);
        unselectedCS4Outline.SetActive(true);
        unselectedCS5Outline.SetActive(true);
        unselectedCS6Outline.SetActive(true);

        glowing_O_Outline.SetActive(true);
        glowing_C_Outline.SetActive(false);
        glowing_S_Outline.SetActive(false);
        glowing_I_Outline.SetActive(false);
        glowing_H_Outline.SetActive(false);
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

    public void onOfficeButtonClicked()
    {
        if (page_One.activeSelf)
        {
            Office_Description.SetActive(true);
            Castle_Description.SetActive(false);
            School_Description.SetActive(false);
            Island_Description.SetActive(false);
            House_Description.SetActive(false);
            coming_Soon_Description.SetActive(false);

            unselected_O_Outline.SetActive(false);
            unselected_C_Outline.SetActive(true);
            unselected_S_Outline.SetActive(true);
            unselected_I_Outline.SetActive(true);
            unselected_H_Outline.SetActive(true);
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowing_O_Outline.SetActive(true);
            glowing_C_Outline.SetActive(false);
            glowing_S_Outline.SetActive(false);
            glowing_I_Outline.SetActive(false);
            glowing_H_Outline.SetActive(false);
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
            Office_Description.SetActive(false);
            Castle_Description.SetActive(false);
            School_Description.SetActive(false);
            Island_Description.SetActive(false);
            House_Description.SetActive(false);
            coming_Soon_Description.SetActive(true);

            unselected_O_Outline.SetActive(true);
            unselected_C_Outline.SetActive(true);
            unselected_S_Outline.SetActive(true);
            unselected_I_Outline.SetActive(true);
            unselected_H_Outline.SetActive(true);
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(false);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowing_O_Outline.SetActive(false);
            glowing_C_Outline.SetActive(false);
            glowing_S_Outline.SetActive(false);
            glowing_I_Outline.SetActive(false);
            glowing_H_Outline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(true);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
    }

    public void onCastleButtonClicked()
    {
        if (page_One.activeSelf == true)
        {
            Office_Description.SetActive(false);
            Castle_Description.SetActive(true);
            School_Description.SetActive(false);
            Island_Description.SetActive(false);
            House_Description.SetActive(false);
            coming_Soon_Description.SetActive(false);

            unselected_O_Outline.SetActive(true);
            unselected_C_Outline.SetActive(false);
            unselected_S_Outline.SetActive(true);
            unselected_I_Outline.SetActive(true);
            unselected_H_Outline.SetActive(true);
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowing_O_Outline.SetActive(false);
            glowing_C_Outline.SetActive(true);
            glowing_S_Outline.SetActive(false);
            glowing_I_Outline.SetActive(false);
            glowing_H_Outline.SetActive(false);
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
            Office_Description.SetActive(false);
            Castle_Description.SetActive(false);
            School_Description.SetActive(false);
            Island_Description.SetActive(false);
            House_Description.SetActive(false);
            coming_Soon_Description.SetActive(true);

            unselected_O_Outline.SetActive(true);
            unselected_C_Outline.SetActive(true);
            unselected_S_Outline.SetActive(true);
            unselected_I_Outline.SetActive(true);
            unselected_H_Outline.SetActive(true);
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(false);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowing_O_Outline.SetActive(false);
            glowing_C_Outline.SetActive(false);
            glowing_S_Outline.SetActive(false);
            glowing_I_Outline.SetActive(false);
            glowing_H_Outline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(true);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
    }

    public void onSchoolButtonClicked()
    {
        if (page_One.activeSelf)
        {
            Office_Description.SetActive(false);
            Castle_Description.SetActive(false);
            School_Description.SetActive(true);
            Island_Description.SetActive(false);
            House_Description.SetActive(false);
            coming_Soon_Description.SetActive(false);

            unselected_O_Outline.SetActive(true);
            unselected_C_Outline.SetActive(true);
            unselected_S_Outline.SetActive(false);
            unselected_I_Outline.SetActive(true);
            unselected_H_Outline.SetActive(true);
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowing_O_Outline.SetActive(false);
            glowing_C_Outline.SetActive(false);
            glowing_S_Outline.SetActive(true);
            glowing_I_Outline.SetActive(false);
            glowing_H_Outline.SetActive(false);
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
            Office_Description.SetActive(false);
            Castle_Description.SetActive(false);
            School_Description.SetActive(false);
            Island_Description.SetActive(false);
            House_Description.SetActive(false);
            coming_Soon_Description.SetActive(true);

            unselected_O_Outline.SetActive(true);
            unselected_C_Outline.SetActive(true);
            unselected_S_Outline.SetActive(true);
            unselected_I_Outline.SetActive(true);
            unselected_H_Outline.SetActive(true);
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(false);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowing_O_Outline.SetActive(false);
            glowing_C_Outline.SetActive(false);
            glowing_S_Outline.SetActive(false);
            glowing_I_Outline.SetActive(false);
            glowing_H_Outline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(true);
            glowingCS4Outline.SetActive(false);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
    }

    public void onIslandButtonClicked()
    {
        if (page_One.activeSelf)
        {
            Office_Description.SetActive(false);
            Castle_Description.SetActive(false);
            School_Description.SetActive(false);
            Island_Description.SetActive(true);
            House_Description.SetActive(false);
            coming_Soon_Description.SetActive(false);

            unselected_O_Outline.SetActive(true);
            unselected_C_Outline.SetActive(true);
            unselected_S_Outline.SetActive(true);
            unselected_I_Outline.SetActive(false);
            unselected_H_Outline.SetActive(true);
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowing_O_Outline.SetActive(false);
            glowing_C_Outline.SetActive(false);
            glowing_S_Outline.SetActive(false);
            glowing_I_Outline.SetActive(true);
            glowing_H_Outline.SetActive(false);
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
            Office_Description.SetActive(false);
            Castle_Description.SetActive(false);
            School_Description.SetActive(false);
            Island_Description.SetActive(false);
            House_Description.SetActive(false);
            coming_Soon_Description.SetActive(true);

            unselected_O_Outline.SetActive(true);
            unselected_C_Outline.SetActive(true);
            unselected_S_Outline.SetActive(true);
            unselected_I_Outline.SetActive(true);
            unselected_H_Outline.SetActive(true);
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(false);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowing_O_Outline.SetActive(false);
            glowing_C_Outline.SetActive(false);
            glowing_S_Outline.SetActive(false);
            glowing_I_Outline.SetActive(false);
            glowing_H_Outline.SetActive(false);
            glowingCSOutline.SetActive(false);
            glowingCS1Outline.SetActive(false);
            glowingCS2Outline.SetActive(false);
            glowingCS3Outline.SetActive(false);
            glowingCS4Outline.SetActive(true);
            glowingCS5Outline.SetActive(false);
            glowingCS6Outline.SetActive(false);
        }
    }

    public void onHouseButtonClicked()
    {
        if (page_One.activeSelf)
        {
            Office_Description.SetActive(false);
            Castle_Description.SetActive(false);
            School_Description.SetActive(false);
            Island_Description.SetActive(false);
            House_Description.SetActive(true);
            coming_Soon_Description.SetActive(false);

            unselected_O_Outline.SetActive(true);
            unselected_C_Outline.SetActive(true);
            unselected_S_Outline.SetActive(true);
            unselected_I_Outline.SetActive(true);
            unselected_H_Outline.SetActive(false);
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowing_O_Outline.SetActive(false);
            glowing_C_Outline.SetActive(false);
            glowing_S_Outline.SetActive(false);
            glowing_I_Outline.SetActive(false);
            glowing_H_Outline.SetActive(true);
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
            Office_Description.SetActive(false);
            Castle_Description.SetActive(false);
            School_Description.SetActive(false);
            Island_Description.SetActive(false);
            House_Description.SetActive(false);
            coming_Soon_Description.SetActive(true);

            unselected_O_Outline.SetActive(true);
            unselected_C_Outline.SetActive(true);
            unselected_S_Outline.SetActive(true);
            unselected_I_Outline.SetActive(true);
            unselected_H_Outline.SetActive(true);
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(false);
            unselectedCS6Outline.SetActive(true);

            glowing_O_Outline.SetActive(false);
            glowing_C_Outline.SetActive(false);
            glowing_S_Outline.SetActive(false);
            glowing_I_Outline.SetActive(false);
            glowing_H_Outline.SetActive(false);
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
            Office_Description.SetActive(false);
            Castle_Description.SetActive(false);
            School_Description.SetActive(false);
            Island_Description.SetActive(false);
            House_Description.SetActive(false);
            coming_Soon_Description.SetActive(true);

            unselected_O_Outline.SetActive(true);
            unselected_C_Outline.SetActive(true);
            unselected_S_Outline.SetActive(true);
            unselected_I_Outline.SetActive(true);
            unselected_H_Outline.SetActive(true);
            unselectedCSOutline.SetActive(false);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(true);

            glowing_O_Outline.SetActive(false);
            glowing_C_Outline.SetActive(false);
            glowing_S_Outline.SetActive(false);
            glowing_I_Outline.SetActive(false);
            glowing_H_Outline.SetActive(false);
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
            Office_Description.SetActive(false);
            Castle_Description.SetActive(false);
            School_Description.SetActive(false);
            Island_Description.SetActive(false);
            House_Description.SetActive(false);
            coming_Soon_Description.SetActive(true);

            unselected_O_Outline.SetActive(true);
            unselected_C_Outline.SetActive(true);
            unselected_S_Outline.SetActive(true);
            unselected_I_Outline.SetActive(true);
            unselected_H_Outline.SetActive(true);
            unselectedCSOutline.SetActive(true);
            unselectedCS1Outline.SetActive(true);
            unselectedCS2Outline.SetActive(true);
            unselectedCS3Outline.SetActive(true);
            unselectedCS4Outline.SetActive(true);
            unselectedCS5Outline.SetActive(true);
            unselectedCS6Outline.SetActive(false);

            glowing_O_Outline.SetActive(false);
            glowing_C_Outline.SetActive(false);
            glowing_S_Outline.SetActive(false);
            glowing_I_Outline.SetActive(false);
            glowing_H_Outline.SetActive(false);
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
