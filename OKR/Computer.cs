namespace OKR
{
    public class Computer
    {
        private int _cpuFrequency;
        private int _numberCores;
        private int _ram;
        private int _hardDiskSpace;

        public int CpuFrequency
        {
            get => _cpuFrequency;
            set => _cpuFrequency = value;
        }

        public int NumberCores
        {
            get => _numberCores;
            set => _numberCores = value;
        }

        public int Ram
        {
            get => _ram;
            set => _ram = value;
        }

        public int HardDiskSpace
        {
            get => _hardDiskSpace;
            set => _hardDiskSpace = value;
        }

        public Computer(int cpuFrequency, int numberCores, int ram, int hardDiskSpace)
        {
            _cpuFrequency = cpuFrequency;
            _numberCores = numberCores;
            _ram = ram;
            _hardDiskSpace = hardDiskSpace;
        }

        public virtual double Cost()
        {
            return _cpuFrequency * (_numberCores / 100) + (_ram / 80) + (_hardDiskSpace / 20);
        }

        public virtual bool Suitability()
        {
            if (_cpuFrequency > 2000 && _numberCores > 2 && _ram > 2048 && _hardDiskSpace > 320)
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
            return $"Частота в процессора - {_cpuFrequency}МГц, Количество ядер - {_numberCores}, Объём оперативной памяти - {_ram}МБ, Объём жествого диска - {_hardDiskSpace}ГБ" +
                   $" Стоимость - {Cost()}, Пригодность - {Suitability()}";
        }
    }
}