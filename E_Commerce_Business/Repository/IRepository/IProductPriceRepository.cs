using E_Commerce_Models;

namespace E_Commerce_Business.Repository.IRepository
{
    public interface IProductPriceRepository
    {
        public Task<ProductPriceDTO> Create(ProductPriceDTO objDTO);
        public Task<ProductPriceDTO> Update(ProductPriceDTO objDTO);
        public Task<int> Delete(int id);
        public Task<ProductPriceDTO> GetById(int id);
        public Task<IEnumerable<ProductPriceDTO>> GetAll(int? id = null);
    }
}
