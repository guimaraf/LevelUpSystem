# LevelUpSystem
LevelUpSystem


![Alt text](/img/xp.png?raw=true "")

Method 1
```c#
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
```

Method 2

```c#
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
```