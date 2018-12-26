using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HTCMobile.Cars.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HTCMobile.Cars
{
    public interface ICarAppService: IAsyncCrudAppService<CarDto, long, PagedResultRequestDto, CreateCarDto, CarDto>
    {
        /// <summary>
        /// custom method
        /// </summary>
        /// <returns></returns>
        
    }
}
