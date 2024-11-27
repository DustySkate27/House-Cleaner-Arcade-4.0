using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solvingPotion : MonoBehaviour
{

    public GameObject iImage;
    public GameObject potSolPhAct;
    public GameObject potSolPhInact;

    [SerializeField] private List<GameObject> crateres = new List<GameObject>();
    [SerializeField] private List<GameObject> manchas = new List<GameObject>();

    private DirtScript DirtScript;
    private Dirt2Script Dirt2Script;
    private Dirt3Script Dirt3Script;

    // Start is called before the first frame update
    void Start()
    {
        if (itemManager.Instance.pBuy == true)
        {
            iImage.SetActive(true);
            potSolPhAct.SetActive(true);
        }
        else
        {
            iImage.SetActive(false);
            potSolPhAct.SetActive(false);
        }
        potSolPhInact.SetActive(false);
        DirtScript = GameObject.FindGameObjectWithTag("d1").GetComponent<DirtScript>();
        Dirt2Script = GameObject.FindGameObjectWithTag("d2").GetComponent<Dirt2Script>();
        Dirt3Script = GameObject.FindGameObjectWithTag("d3").GetComponent<Dirt3Script>();
    }

    // Update is called once per frame
    void Update()
    {
        usePotion();
    }

    private void usePotion()
    {
        if(Input.GetKeyDown("i") && itemManager.Instance.pBuy == true)
        {
            foreach (GameObject crater in crateres)
            {
                crater.SetActive(false);
                perfectManager.perfect += 40;
            }
            iImage.SetActive(false);
            potSolPhAct.SetActive(false);
            potSolPhInact.SetActive(true);
            itemManager.Instance.pBuy = false;
        }
    }
}
