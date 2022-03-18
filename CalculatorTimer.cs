public struct CalculatorTimer
{
    private static int Hour { set; get; }
    private static int Minute { set; get; }

    [System.Obsolete("use instead GetTime()")]
    public static int TimeCalculator(int value, int hour = 32, int minute = 59, int second = 59)
    {

        switch (hour)
        {
            case 0:
                Hour = 0;
                break;
            case 1:
                Hour = 3600;
                break;
            case 2:
                Hour = 7200;
                break;
            case 3:
                Hour = 10800;
                break;
            case 4:
                Hour = 14400;
                break;
            case 5:
                Hour = 18000;
                break;
            case 6:
                Hour = 21600;
                break;
            case 7:
                Hour = 25200;
                break;
            case 8:
                Hour = 28800;
                break;
            case 9:
                Hour = 32400;
                break;
            case 10:
                Hour = 36000;
                break;
            case 11:
                Hour = 39600;
                break;
            case 12:
                Hour = 43200;
                break;
            case 13:
                Hour = 46800;
                break;
            case 14:
                Hour = 50400;
                break;
            case 15:
                Hour = 54000;
                break;
            case 16:
                Hour = 57600;
                break;
            case 17:
                Hour = 61200;
                break;
            case 18:
                Hour = 64800;
                break;
            case 19:
                Hour = 68400;
                break;
            case 20:
                Hour = 72000;
                break;
            case 21:
                Hour = 75600;
                break;
            case 22:
                Hour = 79200;
                break;
            case 23:
                Hour = 82800;
                break;
        }
        switch (minute)
        {
            case 0:
                Minute = 0;
                break;
            case 1:
                Minute = 60;
                break;
            case 2:
                Minute = 120;
                break;
            case 3:
                Minute = 180;
                break;
            case 4:
                Minute = 240;
                break;
            case 5:
                Minute = 300;
                break;
            case 6:
                Minute = 360;
                break;
            case 7:
                Minute = 420;
                break;
            case 8:
                Minute = 480;
                break;
            case 9:
                Minute = 540;
                break;
            case 10:
                Minute = 600;
                break;
            case 11:
                Minute = 660;
                break;
            case 12:
                Minute = 720;
                break;
            case 13:
                Minute = 780;
                break;
            case 14:
                Minute = 840;
                break;
            case 15:
                Minute = 900;
                break;
            case 16:
                Minute = 960;
                break;
            case 17:
                Minute = 1020;
                break;
            case 18:
                Minute = 1080;
                break;
            case 19:
                Minute = 1140;
                break;
            case 20:
                Minute = 1200;
                break;
            case 21:
                Minute = 1260;
                break;
            case 22:
                Minute = 1320;
                break;
            case 23:
                Minute = 1380;
                break;
            case 24:
                Minute = 1440;
                break;
            case 25:
                Minute = 1500;
                break;
            case 26:
                Minute = 1560;
                break;
            case 27:
                Minute = 1620;
                break;
            case 28:
                Minute = 1680;
                break;
            case 29:
                Minute = 1740;
                break;
            case 30:
                Minute = 1800;
                break;
            case 31:
                Minute = 1860;
                break;
            case 32:
                Minute = 1920;
                break;
            case 33:
                Minute = 1980;
                break;
            case 34:
                Minute = 2040;
                break;
            case 35:
                Minute = 2100;
                break;
            case 36:
                Minute = 2160;
                break;
            case 37:
                Minute = 2220;
                break;
            case 38:
                Minute = 2280;
                break;
            case 39:
                Minute = 2340;
                break;
            case 40:
                Minute = 2400;
                break;
            case 41:
                Minute = 2460;
                break;
            case 42:
                Minute = 2520;
                break;
            case 43:
                Minute = 2580;
                break;
            case 44:
                Minute = 2640;
                break;
            case 45:
                Minute = 2700;
                break;
            case 46:
                Minute = 2760;
                break;
            case 47:
                Minute = 2820;
                break;
            case 48:
                Minute = 2880;
                break;
            case 49:
                Minute = 2940;
                break;
            case 50:
                Minute = 3000;
                break;
            case 51:
                Minute = 3060;
                break;
            case 52:
                Minute = 3120;
                break;
            case 53:
                Minute = 3180;
                break;
            case 54:
                Minute = 3240;
                break;
            case 55:
                Minute = 3300;
                break;
            case 56:
                Minute = 3360;
                break;
            case 57:
                Minute = 3420;
                break;
            case 58:
                Minute = 3480;
                break;
            case 59:
                Minute = 3540;
                break;
        }

        return value = Hour + Minute + second;
    }
    public static int GetTime(int hour = 32, int minute = 59, int second = 59) => hour * 3600 + minute * 60 + second;
}
