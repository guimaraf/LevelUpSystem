using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] private Text txtCurrentLevel = default, txtCurrentXp = default, txtNextXP = default;
    [SerializeField] private int currentLevel = 1; 
    [SerializeField] private float currentXp = 0, nextXp = 50;

    private void Start()
    {
        UpdateUi();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetXp(10);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            SetXpFixed(15);
        }
    }

    private void SetXp(int xp)
    {
        currentXp += xp;
        if(currentXp >= nextXp)
        {
            currentXp -= nextXp;
            nextXp *= 1.25f;
            nextXp = Mathf.Round(nextXp);
            currentLevel++;
        }
        UpdateUi();
    }

    private void SetXpFixed(int xp)
    {
        float[] nextXp = new float[10] { 50, 80, 130, 160, 200, 250, 300, 350, 400, 450};

        currentXp += xp;

        if (currentXp >= nextXp[currentLevel - 1])
        {
            currentXp-= nextXp[currentLevel - 1];
            currentLevel++;
        }
        UpdateUiFixed(nextXp[currentLevel - 1]);
    }

    private void UpdateUi()
    {
        txtCurrentLevel.text = currentLevel.ToString();
        txtCurrentXp.text = currentXp.ToString();
        txtNextXP.text = nextXp.ToString();
    }

    private void UpdateUiFixed(float nextXp)
    {
        txtCurrentLevel.text = currentLevel.ToString();
        txtCurrentXp.text = currentXp.ToString();
        txtNextXP.text = nextXp.ToString();
    }

    
}
