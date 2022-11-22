namespace before
{
    class Car
    {
        public string Name { get; set; }
        public float Kilometer { get; set; }
        public bool HasGaranty { get; set; } = false;

        public void Start()
        {
            if (Kilometer <= 20000)
                HasGaranty = false;
        }
    }
}

namespace after
{
    abstract class Car
    {
        public string Name { get; set; }
        public float Kilometer { get; set; }
        public bool HasGaranty { get; set; } = false;

        public abstract void Start();
        public abstract void CheckKilometer();

    }

    class BMW : Car
    {
        public string Name { get; set; }
        public float Kilometer { get; set; }
        public float Energy { get; set; }
        public bool HasGaranty { get; set; } = false;

        public override void Start()
        {
            if (Energy > 0)
                Energy -= 1;
        }

        public override void CheckKilometer()
        {
            if (Kilometer <= 20000)
                HasGaranty = false;
        }
    }
    class KIA : Car
    {
        public string Name { get; set; }
        public float Kilometer { get; set; }
        public float Energy { get; set; }
        public bool HasGaranty { get; set; } = false;

        public override void Start()
        {
            if (Energy > 0)
                Energy -= 1;
        }

        public override void CheckKilometer()
        {
            if (Kilometer <= 20000)
                HasGaranty = false;
        }
    }
}