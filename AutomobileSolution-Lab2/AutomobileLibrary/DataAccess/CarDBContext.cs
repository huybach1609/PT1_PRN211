using AutomobileLibrary.BussinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext : BaseDAL
    {
        // using singleton
        private static CarDBContext instance;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }

        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        public void hello()
        {
            Console.WriteLine("create");
        }
        public IEnumerable<Car> GetCarList()
        {
            List<Car> cars = new List<Car>();
            String sql = "select * from Cars";
            try
            {
                DataTable dt = dataProvider.GetDataBySql(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    cars.Add(new Car(dr));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return cars;
        }
        public void AddNew(Car car)
        {
            string sql = "insert into Cars values (@carId, @name, @manufacture, @price, @release)";
            SqlParameter[] pas = new SqlParameter[5];
            pas[0] = new SqlParameter("@carId", SqlDbType.Int);
            pas[1] = new SqlParameter("@name", SqlDbType.VarChar);
            pas[2] = new SqlParameter("@manufacture", SqlDbType.VarChar);
            pas[3] = new SqlParameter("@price", SqlDbType.Money);
            pas[4] = new SqlParameter("@release", SqlDbType.Int);
            pas[0].Value = car.CarID;
            pas[1].Value = car.CarName;
            pas[2].Value = car.Manufacturer;
            pas[3].Value = car.Price;
            pas[4].Value = car.ReleaseYear;
            try
            {
                dataProvider.GetDataBySql(sql, pas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public Car getCarById(int id)
        {
            string sql = "select * from Cars where CarID = @carID";
            SqlParameter[] pas = new SqlParameter[1];
            pas[0] = new SqlParameter("@carId", SqlDbType.Int);
            pas[0].Value = id;
            Car c = new Car();
            try
            {
                DataTable dt = dataProvider.GetDataBySql(sql, pas);
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        c = new Car(dr);
                    }
                    return c;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return null;
        }
        public void Update(Car car)
        {
            String sql = "update Cars set CarID = @carId, CarName = @name, Manufacturer =@manufacture, Price = @price, ReleasedYear = @release where CarID = @carId";
            SqlParameter[] pas = new SqlParameter[5];
            pas[0] = new SqlParameter("@carId", SqlDbType.Int);
            pas[1] = new SqlParameter("@name", SqlDbType.VarChar);
            pas[2] = new SqlParameter("@manufacture", SqlDbType.VarChar);
            pas[3] = new SqlParameter("@price", SqlDbType.Money);
            pas[4] = new SqlParameter("@release", SqlDbType.Int);
            pas[0].Value = car.CarID;
            pas[1].Value = car.CarName;
            pas[2].Value = car.Manufacturer;
            pas[3].Value = car.Price;
            pas[4].Value = car.ReleaseYear;
            try
            {
                Car c1 = getCarById(car.CarID);
                if (c1 != null)
                {
                    dataProvider.GetDataBySql(sql, pas);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }
        public void Delete(int id ) {
            string sql = "delete Cars where CarID =@carId";
            SqlParameter[] pas = new SqlParameter[1];
            pas[0] = new SqlParameter("@carId", SqlDbType.Int);
            pas[0].Value = id;
            try
            {
                dataProvider.GetDataBySql(sql, pas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }
    }
}
