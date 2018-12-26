using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HTCMobile.Cars.Dto;
using HTCMobile.EntityFrameworkCore;
using HTCMobile.Model;
using System.Threading.Tasks;

namespace HTCMobile.Cars
{
    public class CarAppService : HTCMobileAppServiceBase, ICarAppService
    {
        private readonly IRepository<HtcCar, long> _carRepository;

        public CarAppService(IRepository<HtcCar, long> carRepository)
        {
            _carRepository = carRepository;
        }

        public Task<CarDto> Create(CreateCarDto input)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(EntityDto<long> input)
        {
            throw new System.NotImplementedException();
        }

        public async Task<CarDto> Get(EntityDto<long> input)
        {
            try
            {
                var carEntity = await  _carRepository.GetAsync(input.Id);
                return ObjectMapper.Map<CarDto>(carEntity);
            }
            catch (System.Exception)
            {

                return null;
            }
        }

        public Task<PagedResultDto<CarDto>> GetAll(PagedResultRequestDto input)
        {
            throw new System.NotImplementedException();
        }


        public Task<CarDto> Update(CarDto input)
        {
            throw new System.NotImplementedException();
        }
    }
}
