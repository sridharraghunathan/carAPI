using System.Collections.Generic;
using System.Threading.Tasks;
using core.Dtos;
using Infrastructure.CarModels;
using Infrastructure.interfaces;
using Infrastructure.ModelsWrapper;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    public class CarController : BaseApiController
    {

       private readonly ICarRepository _carRepository;
        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        // Task<List<Car>> GetCarDataAsync();
          [HttpGet("carinfo")]
        public async Task<List<Car>> GetCarDataAsync()
        {
            return await _carRepository.GetCarDataAsync();
        }

        // Task<Car> GetCarDataByIdAsync(int carId);
        [HttpGet("carinfo/{carId}")]
        public async Task<Car> GetCarDataByIdAsync( int carId)
        {
           return await _carRepository.GetCarDataByIdAsync(carId);  
        }

        // Task<Dictionary<string, bool>> CreateCarDataAsync(Car car);
        [HttpPost("carinfo")]
        public async Task<Dictionary<string, bool>> CreateCarDataAsync([FromBody] Car car)
        {
           return await _carRepository.CreateCarDataAsync(car);
        }

        // Task<Dictionary<string, bool>> UpdateCarDataAsync(int carId, Car carData);
        [HttpPut("carinfo/{carId}")]
        public async Task<Dictionary<string, bool>> UpdateCarDataAsync(int carId, [FromBody] Car carData)
        {
           return  await _carRepository.UpdateCarDataAsync( carId,carData);
        }

        // Task<Dictionary<string, bool>> RemoveCarDataAsync(int carId);
        [HttpDelete("carinfo/{carId}")]
        public async Task<Dictionary<string, bool>> RemoveCarDataAsync(int carId)
        {
           return await _carRepository.RemoveCarDataAsync(carId);
        }

        // Task<List<Car>> GetCarDataPaginationAsync(int pageSize, int pageNumber);
        [HttpGet("carinfo/pagination")]
        public async Task<List<Car>> GetCarDataPaginationAsync([FromQuery]int pageSize, [FromQuery] int pageNumber)
        {
           return await _carRepository.GetCarDataPaginationAsync(pageSize,   pageNumber);  
        }


        // Task<Dictionary<string, bool>> CreateUserGeneralEnquiryMessageAsync(UserGeneralEnquiryMessageDTO enquiry );
        [HttpPost("generalenquiry")]
        public async Task<Dictionary<string, bool>>  CreateUserGeneralEnquiryMessageAsync([FromBody] UserGeneralEnquiryMessageDTO enquiry )
        {
         return await _carRepository.CreateUserGeneralEnquiryMessageAsync(enquiry);  
        }
        // Task<Dictionary<string, bool>> CreateUserSpecificCarEnquiryMessageAsync();
         [HttpPost("specificcarenquiry")]
        public async Task<Dictionary<string, bool>> CreateUserSpecificCarEnquiryMessageAsync()
        {
          return await _carRepository.CreateUserSpecificCarEnquiryMessageAsync();    
        }
        // Task<List<Car>> GetCarFilterAsync(SearchRequest search);
        [HttpGet("carinfo/search")]
        public async Task<List<Car>> GetCarFilterAsync([FromQuery] SearchRequest search)
        {
           return await _carRepository.GetCarFilterAsync(search);
        }
        

    }
}