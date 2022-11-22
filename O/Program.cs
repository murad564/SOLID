namespace before
{
    class Auto
    {
        public DateTime Created { get; set; }
        public string FuelType { get; set; }
    }
}

namespace after
{
    interface ICar
    {
        public void Start();

        public void CheckKilometer();
    }

    class BMW : ICar
    {
        public string Model { get; set; }
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

    class Volkswagen : ICar
    {
        public string Model { get; set; }
        public float Kilometer { get; set; }
        public float Energy { get; set; }
        public bool HasGaranty { get; set; } = false;

        public void Start()
        {
            if (Energy > 0)
                Energy -= 5;
        }

        public void CheckKilometer()
        {
            if (Kilometer <= 25000)
                HasGaranty = false;
        }
    }

    class Auto
    {
        public DateTime Created { get; set; }
        public string FuelType { get; set; }

        public ICar Car { get; set; }
    }
}