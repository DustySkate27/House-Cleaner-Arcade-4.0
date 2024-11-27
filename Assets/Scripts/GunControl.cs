using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunControl : MonoBehaviour
{
    [SerializeField] private GameObject gunUp;
    [SerializeField] private GameObject gunDown;
    [SerializeField] private GameObject gunRight;
    [SerializeField] private GameObject gunLeft;

    private controles broomControl;


    public float WaterTank;

    [SerializeField] private Image waterBar;


    //public bool waterPressure1 = true;
    //public bool waterPressure2 = false;
    //public bool waterPressure3 = false;

    public int waterPressure;

    [SerializeField] private GameObject pressureMenuUI;
    private bool isPressureUIOpen = false;

    public bool isShooting = false;

    // Start is called before the first frame update
    void Start()
    {
        broomControl = GetComponent<controles>();
        waterPressure = 1;
    }

    // Update is called once per frame
    void Update()
    {
        gun();
        waterPressureKey();

        waterBar.fillAmount = WaterTank / 100;

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            isPressureUIOpen = !isPressureUIOpen;
            pressureMenuUI.SetActive(isPressureUIOpen);
        }

    }
    private void gun()
    {
        if (broomControl != null && !broomControl.escAct && !isShooting)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) // Up
            {
                gunUp.SetActive(true);
                gunDown.SetActive(false);
                gunRight.SetActive(false);
                gunLeft.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow)) // Down
            {
                gunUp.SetActive(false);
                gunDown.SetActive(true);
                gunRight.SetActive(false);
                gunLeft.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow)) // Right
            {
                gunUp.SetActive(false);
                gunDown.SetActive(false);
                gunRight.SetActive(true);
                gunLeft.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow)) // Left
            {
                gunUp.SetActive(false);
                gunDown.SetActive(false);
                gunRight.SetActive(false);
                gunLeft.SetActive(true);
            }
        }
        else if (!isShooting)
        {
            deactivateGuns();
        }
    }
    

    private void deactivateGuns()
    {
        gunUp.SetActive(false);
        gunDown.SetActive(false);
        gunRight.SetActive(false);
        gunLeft.SetActive(false);
    }

    private void waterPressureKey()
    {

        if (Input.GetKeyDown("1")){

            waterPressure = 1;
        }

       if (Input.GetKeyDown("2"))
        {
            waterPressure = 2;
        }


        if (Input.GetKeyDown("3"))
        {
            waterPressure = 3;
        }

    }

}
 
