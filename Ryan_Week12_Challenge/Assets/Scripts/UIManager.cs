using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject[] inventorySlots;
    public GameObject inventoryManagement;
    public GameObject cauldronScreen;
    public GameObject itemPrefab;
    public GameObject InfoScreen;

    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CauldronInteract()
    {
        cauldronScreen.SetActive(true);
        InfoScreen.SetActive(false);
        int i = 0;
        foreach (int item in InventoryManager.Instance.playerInventory)
        {
            GameObject prefab = Instantiate(itemPrefab, inventorySlots[i].transform.position, itemPrefab.transform.rotation,inventoryManagement.transform);
            prefab.GetComponent<Image>().sprite = InventoryManager.Instance.itemInfo[item].itemImage;
            i++;
        }
    }
}
