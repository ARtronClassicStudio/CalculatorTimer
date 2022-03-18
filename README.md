# Calculator Timer
This calculator has only one function, but it is extremely useful, it is intended to extract the amount of time for `System.TimeSpan.FromSeconds`

![](res/priew.gif)


```diff
Warrning! TimeCalculato is deprecated, use instead GetTime()
```

# example:



```C#
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public string textTime;
    private int length;
    [Range(0,23)]
    public int hour;
    [Range(0,59)]
    public int minute;
    [Range(0,59)]
    public int second;
    
    private void Update()
    {
        //length = CalculatorTimer.TimeCalculator(length, hour, minute, second);
        length = CalculatorTimer.GetTime(hour,minute,second);
        textTime = System.TimeSpan.FromSeconds(length).ToString();
    }
}
```
