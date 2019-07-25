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
    }

    private void SetXp(int xp)
    {
        currentXp += xp;
        if(currentXp >= nextXp)
        {
            nextXp = nextXp * 1.25f;
            currentLevel++;
            currentXp = 0f;
        }
        UpdateUi();
    }

    private void UpdateUi()
    {
        txtCurrentLevel.text = currentLevel.ToString();
        txtCurrentXp.text = currentXp.ToString();
        txtNextXP.text = nextXp.ToString();
    }

    
}
