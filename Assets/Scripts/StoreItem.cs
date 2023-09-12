using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    ClickEnergy, PerSecondIncrease, BuyPlanet
}

public class StoreItem : MonoBehaviour
{
    public GameObject planetBuyEffect;
    public StoreItem storeItem;
    public int cost;
    public int arrayNum;
    public ItemType itemType;
    //enum에 있는 변수들을 사용함

    public int increaseAmount;
    public int qty;

    public Text costText;
    public Text qtyText;

    private GameController controller;
    //GameController의 스크립트를 받아옴
    private Button button;

    public GameObject[] ArrayPlanet = new GameObject[8];
    //게임오브젝트를 받아옴
    public GameObject solar;

    public float distance = 6f;
    public float newDistance;
    //public MovePlanet movePlanet;

    
    // Start is called before the first frame update
    void Start()
    {
        arrayNum = 0;
        qty = 1;
        qtyText.text = qty.ToString();
        costText.text = cost.ToString();

        button = transform.GetComponent<Button>();

        button.onClick.AddListener(this.ButtonClicked);

        controller = GameObject.FindObjectOfType<GameController>();

        storeItem = GameObject.FindWithTag("SolarUp").GetComponent<StoreItem>();

        //object[] prefabs = Resources.LoadAll("Prefabs");
        /*
        for (int i = 0; i < prefabs.Length; i++)
        {
            ArrayPlanet[i] = prefabs[i] as GameObject;
        }
        */
        ArrayPlanet[0] = Resources.Load("Prefabs/Planet1") as GameObject;
        ArrayPlanet[1] = Resources.Load("Prefabs/Planet2") as GameObject;
        ArrayPlanet[2] = Resources.Load("Prefabs/Planet3") as GameObject;
        ArrayPlanet[3] = Resources.Load("Prefabs/Planet4") as GameObject;
        ArrayPlanet[4] = Resources.Load("Prefabs/Planet5") as GameObject;
        ArrayPlanet[5] = Resources.Load("Prefabs/Planet6") as GameObject;
        ArrayPlanet[6] = Resources.Load("Prefabs/Planet7") as GameObject;

    }

    // Update is called once per frame
    void Update()
    {
        button.interactable = (controller.Energy >= cost);
    }

    public void ButtonClicked() 
    {
        controller.Energy -= cost;
        switch (itemType)
        {
            case ItemType.ClickEnergy:
                controller.energyPerClick += increaseAmount;
                //구매시 증가수(increaseAmount)만큼 수치(energyPerClick) 증가
                cost = cost * 2;
                //구매마다 코스트 증가
                costText.text = cost.ToString();
                break;
            case ItemType.PerSecondIncrease:
                controller.EnergyPersecond += increaseAmount;
                controller.PlanetScaleUp();
                cost = cost * 1;
                costText.text = cost.ToString();
                break;
            case ItemType.BuyPlanet:
                BuyPlanet();
                controller.EnergyPersecond += increaseAmount;
                cost = cost * 1;
                costText.text = cost.ToString();
                DestroyButton();
                //버튼없앰
                break;
        }

        qty++;
        //구매시 구매횟수증가
        qtyText.text = qty.ToString();
    }
    
    public void BuyPlanet()
    {
        if(storeItem.qty > 1)
        {
            newDistance = (storeItem.qty + 1) * 0.05f + distance;
            
        } else {
            newDistance = distance;
        }
        GameObject Planet = Instantiate(ArrayPlanet[arrayNum], new Vector3(newDistance, 0, -0.5f), transform.rotation);
        float x = Planet.transform.position.x;
        float y = Planet.transform.position.y;
        Instantiate(planetBuyEffect, new Vector3(x, y, -10f), Quaternion.identity);
        distance = 3f * (qty + 1);
        //행성 구매마다 행성이 생성되는 거리증가
        arrayNum++;

    }

    void DestroyButton()
    {
        if(qty == 6)
        {
            Destroy(gameObject);
        }
        //구매횟수 7이되면 버튼을 없애겠다
    }
}
