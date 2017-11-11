using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Common;
using CRM.Entity;
using System.Data.SqlClient;

namespace CRM.Dal
{
    public class CustomerDAL
    {

        Result result = new Result();
        int returnValue = 0;



        //list methodu
        public Result<List<Customers>> ListOfCustomer()
        {
            Result<List<Customers>> rLc = new Result<List<Customers>>();
            SqlProvider sqlProvider = new SqlProvider("Select * from Customers", false);

            SqlDataReader reader = sqlProvider.ExecuteReader();

            rLc.IsSucceedded = rLc != null;

            List<Customers> allCustomers = new List<Customers>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Customers c = new Customers();
                    c.Id = Convert.ToInt32(reader["Id"]);
                    c.Name = reader["Name"].ToString();
                    c.SurName = reader["SurName"].ToString();
                    c.Address = reader["Address"].ToString();
                    c.Phone = reader["Phone"].ToString();
                    c.Mail = reader["Mail"].ToString();
                    c.City = reader["City"].ToString();
                    c.Country = reader["Country"].ToString();
                    c.Gender = Convert.ToBoolean(reader["Gender"]);
                    c.PhotoPath = reader["PhotoPath"].ToString();
                    c.CreateDate = Convert.ToDateTime(reader["CreateDate"]);

                    allCustomers.Add(c);

                }
            }

            reader.Close();

            rLc.TransactionResult = allCustomers;

            return rLc;
        }


        // 8 sqlproviderdan geldim. dml yapı metotlar halinde tanımlanacak:

        public Result Save(Customers instance)
        {
            Result result = new Result();
            int returnValue = 0;

            SqlProvider sqlProvider = new SqlProvider("Insert into Customers (Name,SurName,Address,Phone,Mail,City,Country,Gender,PhotoPath,CreateDate) Values (@Name,@SurName,@Address,@Phone,@Mail,@City,@Country,@Gender,@PhotoPath,@CreateDate)", false);
//            sqlProvider.AddParameter("@Id", instance.Id);
            sqlProvider.AddParameter("@Name", instance.Name);
            sqlProvider.AddParameter("@SurName", instance.SurName);
            sqlProvider.AddParameter("@Address", instance.Address);
            sqlProvider.AddParameter("@Phone", instance.Phone);
            sqlProvider.AddParameter("@Mail", instance.Mail);
            sqlProvider.AddParameter("@City", instance.City);
            sqlProvider.AddParameter("@Country", instance.Country);
            sqlProvider.AddParameter("@Gender", instance.Gender);
            sqlProvider.AddParameter("@PhotoPath", instance.PhotoPath);
            sqlProvider.AddParameter("@CreateDate", instance.CreateDate);

            returnValue = sqlProvider.ExecuteNonQuery();

            //if (returnValue == -1)
            //{
            //    result.IsSucceedded = false;
            //}
            //else
            //{
            //    result.IsSucceedded = true;
            //}


            // 2. yol:

            result.IsSucceedded = returnValue != -1;

            return result;

        }

        public Result Update(Customers newInstance)
        {
            Result result = new Result();
            int returnValue = 0;

            SqlProvider sqlProvider = new SqlProvider("pr_UpdateCustomers", true);

            #region pr_UpdateCustomers procedure:
            //create procedure pr_UpdateCustomers
            //(
            //@Id int,
            //@Name nvarchar(50),
            //@SurName nvarchar(50),
            //@Address nvarchar(50),
            //@Phone nvarchar(50),
            //@Mail nvarchar(50),
            //@City nvarchar(50),
            //@Country nvarchar(50),
            //@Gender bit,
            //@PhotoPath nvarchar(255),
            //@CreateDate datetime

            //) as
            //UPDATE Customers
            //SET Name = @Name,SurName = @SurName,Address = @Address,Phone = @Phone,Mail = @Mail,City = @City,Country = @Country,Gender = @Gender,PhotoPath = @PhotoPath,CreateDate = @CreateDate
            //WHERE Id = @Id 
            #endregion procedure


            sqlProvider.AddParameter("@Id", newInstance.Id);
            sqlProvider.AddParameter("@Name", newInstance.Name);
            sqlProvider.AddParameter("@SurName", newInstance.SurName);
            sqlProvider.AddParameter("@Address", newInstance.Address);
            sqlProvider.AddParameter("@Phone", newInstance.Phone);
            sqlProvider.AddParameter("@Mail", newInstance.Mail);
            sqlProvider.AddParameter("@City", newInstance.City);
            sqlProvider.AddParameter("@Country", newInstance.Country);
            sqlProvider.AddParameter("@Gender", newInstance.Gender);
            sqlProvider.AddParameter("@PhotoPath", newInstance.PhotoPath);
            sqlProvider.AddParameter("@CreateDate", newInstance.CreateDate);

            returnValue = sqlProvider.ExecuteNonQuery();
            result.IsSucceedded = returnValue != -1;

            return result;
        }

        public Customers getCustomer(int Id)
        {
            Customers c = new Customers();
            SqlProvider sqlProvider = new SqlProvider("Select * from Customers Where Id = @Id", false);

            sqlProvider.AddParameter("@Id", Id);
            SqlDataReader reader = sqlProvider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    c.Id = Convert.ToInt32(reader["Id"]);
                    c.Name = reader["Name"].ToString();
                    c.SurName = reader["SurName"].ToString();
                    c.Address = reader["Address"].ToString();
                    c.Phone = reader["Phone"].ToString();
                    c.Mail = reader["Mail"].ToString();
                    c.City = reader["City"].ToString();
                    c.Country = reader["Country"].ToString();
                    c.Gender = Convert.ToBoolean(reader["Gender"]);
                    c.PhotoPath = reader["PhotoPath"].ToString();
                    c.CreateDate = Convert.ToDateTime(reader["CreateDate"]);
                }
            }


            return c;
        }

        public Result Delete(object InstanceId)
        {
            Result result = new Result();
            int returnValue = 0;

            SqlProvider sqlProvider = new SqlProvider("Delete from Customers Where Id = @Id", false);

            sqlProvider.AddParameter("@Id", InstanceId);
            returnValue = sqlProvider.ExecuteNonQuery();

            result.IsSucceedded = returnValue != -1;


            return result;
        }
    }
}
