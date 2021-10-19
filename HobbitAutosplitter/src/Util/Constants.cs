﻿namespace HobbitAutosplitter
{
    public static class Constants
    {
        public const int width = 640;
        public const int height = 480;
        public const string loadingKeyword = "loading";

        public static readonly string[] splitNames =
        {
            "Main Menu",
            "Dream World",
            "An Unexpected Party",
            "Roast Mutton",
            "Troll Hole",
            "Over Hill and Under Hill",
            "Riddles in the Dark",
            "Flies and Spiders",
            "Barrels out of Bond",
            "A Warm Welcome",
            "AWW - Post Thief Split",
            "Inside Information",
            "Gathering of the Clouds",
            "Clouds Burst",
        };

        public static readonly RECT crop = new RECT(160, 120, 480, 360);
    }

    public enum SplitState
    {
        IDLE,
        WAITING,
        LOADING,
        NEWLEVEL,
        STARTUP
    }

    public enum InvokeMode
    {
        SYNC,
        ASYNC
    }
}