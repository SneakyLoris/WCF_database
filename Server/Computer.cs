using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Server
{
    public static class Extensions
    {
        public static string Filter(this string str)
        {
            List<char> charsToRemove = new List<char>() { '"', '_', ',', '.', ';', ':', '\u0027' };

            String chars = "[" + String.Concat(charsToRemove) + "]";
            return Regex.Replace(str, chars, String.Empty);
        }
    }

    [DataContract]
    public class Computer : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string CPU_name;
        private string GPU_name;
        private string motherboard;
        private int power;
        private int memory;
        private bool ssd;
        private bool hdd;
        private bool os;


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [DataMember]
        [DisplayName("ID компьютера")]
        public int ID { get { return id; } set { id = value; OnPropertyChanged(nameof(ID)); } }

        [DataMember]
        [DisplayName("Название")]
        public string Name
        {
            get { return name; }
            set
            {
                string correct = value.Filter();
                if (value.Trim().Length == 0 || value != correct)
                {
                    throw new FaultException<ValueError>(new("Название", value, correct), "Проблемс", new FaultCode("ValueError"));
                }
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        [DataMember]
        [DisplayName("Название процессора")]
        public string CPU
        {
            get { return CPU_name; }
            set
            {
                string correct = value.Filter();
                if (value.Trim().Length == 0 || value != correct)
                {
                    //throw new FaultException<ValueError>(new("Название процессора", value, correct), "Проблемс", new FaultCode("ValueError"));
                }
                CPU_name = value;
                OnPropertyChanged(nameof(CPU));
            }
        }

        [DataMember]
        [DisplayName("Название выдеокарты")]
        public string GPU
        {
            get { return GPU_name; }
            set
            {
                string correct = value.Filter();
                if (value.Trim().Length == 0 || value != correct)
                {
                    //throw new FaultException<ValueError>(new("Название выдеокарты", value, correct), "Проблемс", new FaultCode("ValueError"));
                }
                GPU_name = value;
                OnPropertyChanged(nameof(GPU));
            }
        }

        [DataMember]
        [DisplayName("Название материнской платы")]
        public string Motherboard
        {
            get { return motherboard; }
            set
            {
                string correct = value.Filter();
                if (value.Trim().Length == 0 || value != correct) {
                    //throw new FaultException<ValueError>(new("Название материнской платы", value, correct), "Проблемс", new FaultCode("ValueError"));
                }
                motherboard = value;
                OnPropertyChanged(nameof(Motherboard));
            }
        }
        
        [DataMember]
        [DisplayName("Мощность блока питания")]
        public int Power { get { return power; } set { power = value; OnPropertyChanged(nameof(Power)); } }

        [DataMember]
        [DisplayName("Общая память компьютера")]
        public int Memory { get { return memory; } set { memory = value; OnPropertyChanged(nameof(Memory)); } }

        [DataMember]
        [DisplayName("Наличие SSD")]
        public bool SSD { get { return ssd; } set { ssd = value; OnPropertyChanged(nameof(SSD)); } }

        [DataMember]
        [DisplayName("Наличие HDD")]
        public bool HDD { get { return hdd; } set { hdd = value; OnPropertyChanged(nameof(HDD)); } }



        [DataMember]
        [DisplayName("Наличие операционной системы")]
        public bool OS { 
            get => os; 
            set {
                os = value; OnPropertyChanged(nameof(OS));
            } 
        }

        public Computer(int _id, string _name, string _CPU_name, string _GPU_name, string _motherboard,
            int _power, int _memory, bool _ssd, bool _hdd, bool _os)
        {
            ID = _id;
            Name = _name;
            CPU = _CPU_name;
            GPU = _GPU_name;
            Motherboard = _motherboard;
            Power = _power;
            Memory = _memory;
            SSD = _ssd;
            HDD = _hdd;
            OS = _os;

    }
        public Computer()
        {
            ID = 0;
            Name = "Kingstone";
            CPU = "amdintel";
            GPU = "Radeon nVidea";
            Motherboard = "OKsana";
            Power = 650;
            Memory = 1024;
            SSD = true;
            HDD = false;
            OS = false;
        }
        public Computer Copy() => new Computer(
            ID,
            Name,
            CPU,
            GPU,
            Motherboard,
            Power,
            Memory,
            SSD,
            HDD,
            OS);
    }
    

    [DataContract]
    public class ValueError
    {
        [DataMember]
        public string nameValue {  get; set; }

        [DataMember]
        public string errString { get; set; }

        [DataMember]
        public string haveToBe { get; set; }


        public ValueError()
        {
            nameValue = "Строка";
            errString = "Ytghfdbkmyfz cnhjr";
            haveToBe = "Правильная строка";
        }
        public ValueError(string name, string err, string right)
        {
            nameValue = $"Строка с ошибкой: {name}";
            errString = $"Неправильная строка: {err}";
            haveToBe = $"Возможное исправление: {right}";
        }
    }
}
