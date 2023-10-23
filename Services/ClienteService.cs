using ClienteAPI.DAL;
using ClienteAPI.Models;

namespace ClienteAPI.Services
{
    public class ClienteService
    {
        private readonly Contexto _context;

        public ClienteService(Contexto context)
        {
            _context = context;
        }

        public async Task<bool> Guardar(Clientes cliente)
        {
            if (!ClientesExists(cliente.ClienteId))
                _context.Clientes.Add(cliente);
            else
                _context.Clientes.Update(cliente);

            var cantidad = await _context.SaveChangesAsync();
            return cantidad > 0;
        }

        private bool ClientesExists(int id)
        {
            return (_context.Clientes?.Any(e => e.ClienteId == id)).GetValueOrDefault();
        }
    }
}