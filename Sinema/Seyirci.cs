using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema
{
    public class Seyirci
    {
        public string adSoyad { get; set; }
        private string _tcNo;
        public string TcNo
        {
            get { return _tcNo; }
            set
            {
                if (value.Length!=11)
                {
                    throw new Exception();
                }
                _tcNo = value;
            }
        }
        public bool cinsiyet { get; set; }
    }
}
