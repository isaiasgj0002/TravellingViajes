using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TravellingViajes.Models
{
    public class Reserva
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string LugarOrigen { get; set; }
        public string LugarDestino { get; set; }
        public string FechaIda { get; set; }
        public string FechaVuelta { get; set; }
    }
}
