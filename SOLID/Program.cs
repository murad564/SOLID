namespace before
{
    class BMW
    {
        public string Name { get; set; }
        public float Kilometer { get; set; }
        public float Energy { get; set; }
        public bool HasGaranty { get; set; } = false;

        public void Start()
        {
            if (Energy > 0)
                Energy -= 1;
            if (Kilometer <= 20000)
                HasGaranty = false;
        }
    }
}

namespace after
{
    class BMW
    {
        public string Name { get; set; }
        public float Kilometer { get; set; }
        public float Energy { get; set; }
        public bool HasGaranty { get; set; } = false;

        public void Start()
        {
            if (Energy > 0)
                Energy -= 1;
        }

        public void CheckKilometer()
        {
            if (Kilometer <= 20000)
                HasGaranty = false;
        }
    }
}