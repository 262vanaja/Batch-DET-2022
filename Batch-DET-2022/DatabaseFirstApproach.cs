using Batch_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Batch_DET_2022
{
    internal class DatabaseFirstApproach
    {
        static void Main()
        {


            // Updateemployee();
            //GetAllEmpDetails();
            //Console.ReadLine();
            //GetDetailsById();
            //AddNewEmployee();
            // RemoveNewEmployee();
            CallStoredProcwithSQLParamater_insert();

        }
        // private static void GetAllEmpDetails()
        //private static void GetDetailsById()
        //private static void AddNewEmployee()
        // private static void RemoveNewEmployee()
        // private static void Updateemployee()

        //{
        //var ctx = new TrainingContext();
        //var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //Console.WriteLine(emp.Ename + " "+emp.Sal + " " + emp.Job);

        //foreach (var emp in emps)
        //{
        //    Console.WriteLine(emp.Ename + " " + emp.Sal);
        //

        //try
        //{ 
        //   Batch_DET_2022.Models.Emp employee = new Models.Emp();


        //    employee.Empno = 2979;
        //    employee.Ename = "Sheela";
        //    employee.Sal = 1000;
        //    employee.Deptno = 30;
        //    employee.Job = "Trainer";
        //    ctx.Add(employee);
        //    ctx.SaveChanges();
        //    Console.WriteLine("New employee added");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.InnerException.Message);




        //var ctx = new TrainingContext();

        //try
        //{
        //    Emp employee = new Emp();
        //    employee.Empno = 2979;
        //    employee.Ename = "Sheela";
        //    employee.Sal = 1000;
        //    employee.Deptno = 30;
        //    employee.Job = "Trainer";
        //    ctx.Remove(employee);
        //    ctx.SaveChanges();
        //    Console.WriteLine(" employee remove");
        //}
        //    catch (Exception ex)
        //{
        //    Console.WriteLine(ex.InnerException.Message);
        //}





        //    var ctx = new TrainingContext();

        //    try
        //    {
        //        Batch_DET_2022.Models.Emp employee = new Models.Emp();

        //        employee.Empno = 7521;
        //        employee.Ename = "vanu";
        //        employee.Sal = 1500;
        //        employee.Deptno = 10;
        //        employee.Job = "manager";
        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" employee update");
        //    }
        //     catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //        throw;
        // }
        //}
        //private static void GetEmployeeSP()
        //{
        //    var ctx = new TrainingContext();
        //    var emp = ctx.Emps.FromSqlRaw("getAllempsdetails1").ToList();
        //    foreach (var Emp in emp)
        //    {
        //        Console.WriteLine(Emp.Ename);
        //    }
        //}

        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new TrainingContext();
            var param = new SqlParameter[]
            {
            new SqlParameter()
       {
                  ParameterName = "@empno",
                  SqlDbType = System.Data.SqlDbType.Int,
                 Size = 100,
                  Direction = System.Data.
                  ParameterDirection.Input,
                   Value = 7521
            },

                  new SqlParameter()
                  {
                    ParameterName = "@newname",
                      SqlDbType = System.Data.
                      SqlDbType.VarChar,
                      Size = 100,
                       Direction = System.Data.
                       ParameterDirection.Input,
                       Value = "vanaja"
                  },

    };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("updatenames @empno, @newname ", param);
                Console.WriteLine("Added");
            }
            catch (Exception ex)
            {


                throw;
            }

            Console.WriteLine("update successful");


        }
    }
}
