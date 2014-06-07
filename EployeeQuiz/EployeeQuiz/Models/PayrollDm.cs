using System;
using System.Collections.Generic;
using System.Linq;
//exportando espacio de nombre
using System.IO;
using System.Web;

namespace EployeeQuiz.Models
{
    public class PayrollDm
    {
        //Lista de empleados
        List<Employee> empList;

        //Constructor del modelo
        public PayrollDm(string dbPath)
        {
            //Creando de la lista empleados
            empList = new List<Employee>();

            //Leer el archivo
            var reader = new StreamReader(
                File.OpenRead(dbPath));

            //Leer parsear
            while (!reader.EndOfStream)
            {
                
                //Leo una linea
                var line = reader.ReadLine();
 
                // parsear 
                // separar  los valores y guardar en un objeto
                var valores = line.Split(',');
                empList.Add(
                    new Employee
                    {
                        Id = valores[0],
                        Name = valores[3],
                        Position = valores[4], //num7
                        FirstLastName = valores[1],
                        SecondLastName = valores[2],
                        Sex = char.Parse(valores[6]),
                        PhotoPath = valores[7],
                        Wage = double.Parse(valores[5]),
                    }
                    );
            }
        }
        //Accesar
        public Employee GuetEmployeeById(string Id)
        {
            //FORMA TRADICIONAL
            //Employee emp = null;
            //foreach (var empleadin in empList)
            //{
                //if (Id == empleadin.Id)
                //{
                    //emp = empleadin;
                //}
            //}
            //return emp;

            // Forma landen Expresion
            var emp = empList.Find(e => e.Id == Id);
            return emp;
        }
    }
}