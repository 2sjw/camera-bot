﻿namespace Andead.CameraBot.Server
{
    public class CameraOptions
    {
        public string Name { get; set; }
        public string SnapshotUrl { get; set; }
        public string Url { get; set; }
        public bool IsLocal { get; set; } = false;
    }
}
