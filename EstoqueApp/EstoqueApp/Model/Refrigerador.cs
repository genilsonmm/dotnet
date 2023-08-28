using EstoqueApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Model
{
    public class Refrigerador : IMaquina
    {
        private List<Insumo> insumos;

        public Refrigerador()
        {
            this.insumos = new List<Insumo>();
        }

        public void CheckIn(Insumo insumo)
        {
            this.insumos.Add(insumo);
        }

        public void CheckOut(Guid id)
        {
            Insumo insumo = this.insumos
                .Where(item => item.GetId() == id).FirstOrDefault();

            if (insumo == null)
            {
                throw new Exception("Insumo não encontrado");
            }

            this.insumos.Remove(insumo);
        }
    }
}
