using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository
    {
        public void DeleteCar(int carId) => CarDBContext.Instance.Delete(carId);

        public Car GetCarById(int carID) => CarDBContext.Instance.getCarById(carID);

        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList;

        public void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);

        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);
    }
}
