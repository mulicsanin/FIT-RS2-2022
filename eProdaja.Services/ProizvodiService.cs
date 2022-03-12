using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : IProizvodiService
    {
        public IEnumerable<Proizvodi> Get()
        {
            return new List<Proizvodi>() { new Proizvodi() { Id = 1, Name = "Laptop"}, new Proizvodi() { Id=2, Name="Mis" } };
        }
    }
}
