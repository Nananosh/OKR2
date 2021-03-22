namespace OKR
{
    public class Notebook:Computer
    {
        private int _batteryLife;

        public int BatteryLife
        {
            get => _batteryLife;
            set => _batteryLife = value;
        }

        public Notebook(int cpuFrequency, int numberCores, int ram, int hardDiskSpace, int batteryLife) : base(cpuFrequency, numberCores, ram, hardDiskSpace)
        {
            _batteryLife = batteryLife;
        }

        public override double Cost()
        {
            return CpuFrequency * (NumberCores / 100) + (Ram / 80) + (HardDiskSpace / 20) + (_batteryLife / 10);
        }

        public override bool Suitability()
        {
            if (CpuFrequency > 2000 && NumberCores > 2 && Ram > 2048 && HardDiskSpace > 320 && _batteryLife>60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"Частота в процессора - {CpuFrequency}МГц, Количество ядер - {NumberCores}, Объём оперативной памяти - {Ram}МБ, Объём жествого диска - {HardDiskSpace}ГБ, Продолжительность работы - {_batteryLife}мин" +
                   $" Стоимость - {Cost()}, Пригодность - {Suitability()}";
        }
    }
}