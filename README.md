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

[![N|Solid](https://raw.githubusercontent.com/guimaraf/guimaraf.github.io/master/img/paypal.png)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=T6D35D68JGL8E&source=url)