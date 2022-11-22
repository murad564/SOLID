namespace before
{
    interface IAuto
    {
        float Kilometer { get; set; }
        float Energy { get; set; }
        int WheelCount { get; set; }
    }
    class BMW : IAuto
    {
        public string Name { get; set; }
        public float Kilometer { get; set; }
        public float Energy { get; set; }
        public bool HasGaranty { get; set; } = false;
        public int WheelCount { get; set; }
    }
}

namespace after
{
    interface IAuto
    {
        float Kilometer { get; set; }
        float Energy { get; set; }
    }

    interface IBike : IAuto
    {
        int WheelCount { get; set; }
    }

    class BMW : IAuto
    {
        public string Name { get; set; }
        public float Kilometer { get; set; }
        public float Energy { get; set; }
    }

    class BMX : IBike
    {
        public float Kilometer { get; set; }
        public float Energy { get; set; }
        public int WheelCount { get; set; }
    }
}