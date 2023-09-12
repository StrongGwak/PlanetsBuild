using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private float energy;
    public float Energy
    {
        get
        {
            return energy;
        }
        set
        {
            energy = value;
            setEnergyText();
        }
    }

    private float energyPersecond;
    public float EnergyPersecond
    {
        get
        {
            return energyPersecond;
        }
        set
        {
            energyPersecond = value;
        }
    }
    public Text EnergyText;
    public Text ClickNumText;
    public Text FiverTimeText;

    public GameObject clickEffect;
    public GameObject fiverEffect;
    public GameObject scaleUpEffect;
    public GameObject GetTextPrefab;

    public float energyPerClick = 10f;
    public float clickNum = 0f;
    public float fiverTime = 0f;
    public bool fiver;
    public bool pianomode;

    public Image fiverBar;

    public AudioSource effectSource;
    public AudioClip effectMusic;
    public AudioClip fiverSound;
    public AudioClip C1;
    public AudioClip D2;
    public AudioClip E2;
    public AudioClip F2;
    public AudioClip G2;
    public AudioClip A2;
    public AudioClip B2;
    public AudioClip C2;
    public AudioClip D3;
    public AudioClip E3;
    public AudioClip F3;
    public AudioClip G3;
    public AudioClip A3;
    public AudioClip B3;
    public AudioClip C3;

    void Start()
    {
        if(PlayerPrefs.HasKey("Energy")){
            Energy = PlayerPrefs.GetFloat("Energy");
        }
        else if(!PlayerPrefs.HasKey("Energy")){
            Energy = 0f;
        }

        //시작시 에너지
        energyPersecond = 1f;
        //초당 오를 에너지
        setFiverText();


    }

    // Update is called once per frame
    void Update()
    {
        Energy += energyPersecond * Time.deltaTime;
        //에너지가 초당 EnergyPersecond만큼 오름
        setClickNumText();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = C1;
                effectSource.Play();
            }
            if(!pianomode)
            {
                Click();
            }
            
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = D2;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = E2;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = F2;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = G2;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = A2;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = B2;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = C2;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.X))
        { 
            Click();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = D3;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = E3;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = F3;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = G3;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        { 
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = A3;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.Period))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = B3;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            if (pianomode)
            {
                pianoClick();
                effectSource.clip = C3;
                effectSource.Play();
            }
            if (!pianomode)
            {
                Click();
            }
        }
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.Quote))
        { 
            Click();
        }
        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            Click();
        }
        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            Click();
        }
        if (Input.GetMouseButtonDown(0))
        {  
            Click();
        }
        if (clickNum == 1000f)
        {
            fiverTime = 10f;
            //피버시간

            energyPerClick = energyPerClick * 2f;
            //피버시 클릭 점수 2배

            clickNum = 0f;
            //클릭횟수 초기화

            fiver = true;
            //피버타임 실행 여부
        }
        if(fiverTime > 0f)
        {
            fiverBar.fillAmount -= 1.0f / 10f * Time.deltaTime;
            //피버바 감소
            fiverTime -= 1.0f * Time.deltaTime;
            //피버시간 감소
            if(fiverTime < 0f)
            {
                fiverTime = 0f;
            }
            setFiverText();
        }
        if (fiver == true && fiverTime == 0f)
        {
            energyPerClick = energyPerClick / 2f;
            fiver = false;
            //피버시간 소진시 피버 종료
        }


    }


    void setEnergyText()
    {
        EnergyText.text = "Energy : " + Energy.ToString("0");
    }
    void setClickNumText()
    {
        ClickNumText.text = "Click : " + clickNum.ToString("0");
    }
    void setFiverText()
    {
        FiverTimeText.text = "FiverTime : " + fiverTime.ToString("0");
    }

    void Click()
    {
        ShowFloatingText();
        Energy += energyPerClick;
        if(fiver == true)
        {
            Instantiate(fiverEffect, transform.position, Quaternion.identity);
            effectSource.clip = fiverSound;
        }
        if(fiver == false)
        {
            Instantiate(clickEffect, transform.position, Quaternion.identity);
            clickNum += 10f;
            fiverBar.fillAmount += 1f / 100f;
            effectSource.clip = effectMusic;
            
        }
        effectSource.Play();
        Save();
    }

    void pianoClick()
    {
        ShowFloatingText();
        Energy += energyPerClick;

        if (fiver == true)
        {
            Instantiate(fiverEffect, transform.position, Quaternion.identity);
        }
        if (fiver == false)
        {
            Instantiate(clickEffect, transform.position, Quaternion.identity);
            clickNum += 10f;
            fiverBar.fillAmount += 1f / 100f;

        }
        Save();
    }

    public void PlanetScaleUp()
    {
        transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        //솔라의 크기가 0.01f 만큼 증가
        Instantiate(scaleUpEffect, transform.position, Quaternion.identity);
        //솔라 크기 증가시 이펙트
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("Energy", Energy);
        PlayerPrefs.Save();
    }

    public void ShowFloatingText()
    {
        var go = Instantiate(GetTextPrefab, new Vector3(transform.position.x, transform.position.y, -5.0f), Quaternion.identity);
        go.GetComponent<TextMesh>().text = energyPerClick.ToString();
    }
    

}
