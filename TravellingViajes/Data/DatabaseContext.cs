using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TravellingViajes.Models;

namespace TravellingViajes.Data
{
    public class DatabaseContext
    {
        public SQLiteAsyncConnection cn { get; set; }
        public DatabaseContext(string path)
        {
            cn = new SQLiteAsyncConnection(path);
            cn.CreateTableAsync<User>().Wait();
            cn.CreateTableAsync<Reserva>().Wait();
        }
        public async Task<int> RegisterUserAsync(User user)
        {
            return await cn.InsertAsync(user);
        }
        public async Task<User> ObtenerUsuarioAsync(string nombreUsuario, string password)
        {
            return await cn.Table<User>()
                            .Where(x => x.Nombre == nombreUsuario && x.Password == password)
                            .FirstOrDefaultAsync();
        }
        public async Task<int> RegisterRservationAsync(Reserva reserva)
        {
            return await cn.InsertAsync(reserva);
        }
        public async Task<List<Reserva>> GetAllReservationsAsync()
        {
            return await cn.Table<Reserva>().ToListAsync();
        }
        public async Task<int> DeleteReservationAsync(Reserva reserva)
        {
            return await cn.DeleteAsync(reserva);
        }
    }
}
