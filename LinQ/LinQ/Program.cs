namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = Enumerable.Range(1,100).ToArray();
            //var numerospares = numeros.Where(x => x%2 == 0).ToList();

            //var numerospares2 = (from n in numeros where n%2 ==0 select n).ToList();

            //var personas = new List<Persona>() {
            //    new Persona{ Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021,1,2), Soltero = true },
            //    new Persona{ Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015,11,22), Soltero = true },
            //    new Persona{ Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020,4,12), Soltero = false },
            //    new Persona{ Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021,4,8), Soltero = false },
            //    new Persona{ Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false }
            //};


            //var persMenor25 = new List<Persona>();
            //persMenor25 = personas.Where(x => x.Edad<=25).ToList();

            //var persMenorsoltera25 = new List<Persona>();
            //persMenorsoltera25 = personas.Where(x => x.Edad <= 25 && x.Soltero==true).ToList();

            //var persPocoTiempo = personas.Where(x => x.FechaIngresoALaEmpresa >= DateTime.Now.AddMonths(-3)).ToList();

            //var nombresYEdades = personas.Select(p => new { Nombre = p.Nombre, Edad = p.Edad}).ToList();    
            //var nombresYEdades_2 = from p in personas select new { Nombre = p.Nombre, Edad = p.Edad };

            //var personasConIndice = personas.Select((p, indice) => new { Persona = p, Indice = indice +1}).ToList();
            //foreach (var item in personasConIndice) { 
            //    Console.WriteLine($"{item.Indice}){item.Persona.Nombre}");
            //}

            //var personas = new List<Persona>() {
            //    new Persona{ Nombre = "Eduardo", Telefonos = {"123-456", "789-852"}},
            //    new Persona{ Nombre = "Nidia",  Telefonos = {"998-478", "568-222"}},
            //    new Persona{ Nombre = "Alejandro",  Telefonos = {"712-132"}},
            //    new Persona{ Nombre = "Valentina"}
            //};

            //var telefonos = personas.SelectMany(p => p.Telefonos).ToList();
            //var telefonosSelect = personas.Select(p => p.Telefonos).ToList();

            var personas = new List<Persona>()
            {
                new Persona{ Nombre = "Eduardo", EmpresaId = 1},
                new Persona{ Nombre = "Nidia", EmpresaId = 1},
                new Persona{ Nombre = "Alejandro", EmpresaId = 3},
                new Persona{ Nombre = "Valentina", EmpresaId = 2},
                new Persona{ Nombre = "Roberto", EmpresaId = 3},
                new Persona{ Nombre = "Eugenia"},
                new Persona{ Nombre = "Esmerlin", EmpresaId = 3}
            };
            var empresas = new List<Empresa>()
            {
                new Empresa{Id = 1, Nombre = "Electrodomésticos Felipe"},
                new Empresa{Id = 2, Nombre = "Bicicletas Valentina"},
                new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"}
            };

            var personasYEmpresas_2 = from per in personas
                                      join emp in empresas on per.EmpresaId equals emp.Id
                                      select new
                                      {
                                         Persona = per.Nombre,
                                         Empresa = emp.Nombre
                                      };
        }
    }
}