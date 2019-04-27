using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComputerStore.Models.DbProduct.Properties
{
    /// <summary>
    /// Свойства монитора
    /// </summary>

    class Monitor
    {

        public int Size { get; set; } // Размер диагонали монитора
        public string Color { get; set; } // Цвет монитора
        public string ConnectionType { get; set; } // Тип подключения монитора
        public string Resolution { get; set; } // Разрешение экрана


        public Monitor(int Size, string Color, string ConnectionType, string Resolution)
        {
            this.Size = Size;
            this.Color = Color;
            this.ConnectionType = ConnectionType;
            this.Resolution = Resolution;
        }
    }
}
