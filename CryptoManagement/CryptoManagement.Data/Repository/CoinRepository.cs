using CryptoManagement.Data.Dto;
using CryptoManagement.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CryptoManagement.Data.Repository
{
    public class CoinRepository
    {
        private readonly DataContext _dataContext;

        public CoinRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public CoinDTO GetById(int id)
        {
            return ModelToDto(ById(id));
        }

        public List<CoinDTO> GetAll()
        {
            List<CoinDTO> coinDTOs = new List<CoinDTO>();
            foreach (var item in _dataContext.Coins.ToList())
            {
                coinDTOs.Add(ModelToDto(item));
            }

            return coinDTOs;
        }

        public List<Coin> GetByName(string name)
        {
            return _dataContext.Coins.Where(c => c.Name.Equals(name)).ToList();
        }

        public Object GetUnique()
        {
            return _dataContext.Coins.ToList()
                .GroupBy(c => c.Name)
                .Select(c => new
                {
                    Name = c.Key,
                    Total = c.Sum(s => s.Quantity)
                }).ToList();
        }

        public void Add(CoinDTO coin)
        {
            _dataContext.Coins.Add(DtoToModel(coin));
            _dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            EntityEntry<Coin> temp = _dataContext.Coins.Remove(ById(id));
            _dataContext.SaveChanges();

            if (temp.Entity == null)
            {
                throw new Exception("Falha ao remover a moeda");
            }
        }

        public CoinDTO Edit(CoinDTO coinDto)
        {
            Coin coin = DtoToModel(coinDto);
            coin.DateTime = DateTime.Now;
            _dataContext.Entry(coin).State = EntityState.Modified;
            _dataContext.SaveChanges();

            return coinDto;
        }

        private Coin? ById(int id)
        {
            return _dataContext.Coins.FirstOrDefault(c => c.CoinId == id);
        }

        private CoinDTO ModelToDto(Coin coin)
        {
            CoinDTO coinDTO = new CoinDTO();
            coinDTO.CoinId = coin.CoinId;
            coinDTO.Quantity = coin.Quantity;
            coinDTO.Price = coin.Price;
            coinDTO.Name = coin.Name;
            coinDTO.DateTime = coin.DateTime;

            return coinDTO;
        }

        private Coin DtoToModel(CoinDTO coinDTO)
        {
            Coin coin = new Coin();
            coin.CoinId = coinDTO.CoinId;
            coin.Quantity = coinDTO.Quantity;
            coin.Price = coinDTO.Price;
            coin.Name = coinDTO.Name;
            coin.DateTime = coinDTO.DateTime;

            return coin;
        }
    }
}
