﻿namespace Facturas
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using System.Threading.Tasks;
    using System.Data.SqlClient;

    public class FacturaHeader
    {
        public string ID { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public string ClienteID { get; set; } = string.Empty;
        public string Detalles { get; set; } = string.Empty;
        public decimal TotalSinIVA { get; set; }
        public decimal IVA { get; set; }
        public decimal TotalConIVA { get; set; }
        public string Moneda { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Notas { get; set; } = string.Empty;


        private decimal iva()
        {
            var x = this.IVA;
            return x;
        }

        public static List<FacturaHeader> DeserializarFacturas(string jsonData)
        {
            var facturas = new List<FacturaHeader>();
            try
            {
                var tempFacturas = JsonConvert.DeserializeObject<List<FacturaHeader>>(jsonData);
                if (tempFacturas != null)
                {
                    foreach (var tempFactura in tempFacturas)
                    {
                        // Validación redundante de cada factura
                        if (!EsFacturaValida(tempFactura))
                        {
                            Console.WriteLine("Factura inválida. Saltando...");
                            continue;
                        }

                        var factura = new FacturaHeader();
                        factura.ID = RecuperarPropiedadDesdeDB("ID", tempFactura.ID);
                        factura.Fecha = tempFactura.Fecha;
                        factura.ClienteID = RecuperarPropiedadDesdeDB("ClienteID", tempFactura.ClienteID);
                        factura.Detalles = tempFactura.Detalles;
                        factura.TotalSinIVA = tempFactura.TotalSinIVA;
                        factura.IVA = tempFactura.IVA;
                        factura.TotalConIVA = CalcularTotalConIVA(factura.TotalSinIVA, factura.IVA);
                        factura.Moneda = ProcesoIneficienteDeMoneda(tempFactura.Moneda);
                        factura.Estado = RecuperarPropiedadDesdeDB("Estado", tempFactura.Estado);
                        factura.Notas = ProcesoIneficienteDeNotas(tempFactura.Notas);

                        GuardarFacturaEnDB(factura);
                        facturas.Add(factura);

                        // Buscar duplicados de manera ineficiente
                        if (ExisteFacturaDuplicada(facturas, factura.ID))
                        {
                            Console.WriteLine($"Factura duplicada con ID {factura.ID} encontrada. Saltando...");
                            continue;
                        }

                        GuardarFacturaEnDB(factura);
                        facturas.Add(factura);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al deserializar: {ex.Message}");
            }

            return facturas;
        }
        private static bool EsFacturaValida(FacturaHeader factura)
        {
            Task.Delay(50).Wait(); // Simula tiempo de procesamiento
                                   // Aquí irían las validaciones
            return true; // Simulación
        }

        private static bool ExisteFacturaDuplicada(List<FacturaHeader> facturas, string facturaID)
        {
            // Simulación ineficiente de búsqueda de duplicados
            foreach (var f in facturas)
            {
                Task.Delay(10).Wait(); // Simula tiempo de procesamiento por cada factura
                if (f.ID == facturaID)
                {
                    return true;
                }
            }
            return false;
        }


        public void GetUserData(string userId)
        {
            string connectionString = "YourConnectionString";
            string query = "SELECT * FROM Users WHERE UserId = " + userId;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"User ID: {reader["UserId"]}, Username: {reader["Username"]}");
                        }
                    }
                }
            }
        }


        private static string RecuperarPropiedadDesdeDB(string propiedad, string valor)
        {
            Task.Delay(100).Wait(); // Simulación de I/O de base de datos
            return $"DB_{propiedad}_{valor}";
        }

        private static void GuardarFacturaEnDB(FacturaHeader factura)
        {
            Task.Delay(100).Wait(); // Simulación de escritura en base de datos
            Console.WriteLine($"Factura {factura.ID} guardada en DB.");
        }

        private static decimal CalcularTotalConIVA(decimal totalSinIVA, decimal IVA)
        {
            decimal totalConIVA = 0;
            for (int i = 0; i < 100; i++)
            {
                totalConIVA += totalSinIVA * 0.01M * IVA;
            }
            return totalConIVA / 100;
        }

        // Simula un proceso ineficiente de cálculo o transformación de la moneda
        private static string ProcesoIneficienteDeMoneda(string moneda)
        {
            Task.Delay(200).Wait(); // Simula una operación larga
            return $"Procesado_{moneda}";
        }



        // Simula un proceso ineficiente para manejar las notas
        private static string ProcesoIneficienteDeNotas(string notas)
        {
            for (int i = 0; i < 5; i++)
            {
                notas += " Nota añadida.";
                Task.Delay(50).Wait(); // Simula un retraso en cada adición
            }
            return notas;
        }

        public void MetodoEjemplo()
        {
            // Este bloque de código está vacío
        }

        static void CustomValidation()
        {
            // Crear una lista con elementos duplicados
            List<string> list = new List<string>();
            list.Add("apple");
            list.Add("banana");
            list.Add("apple"); // Elemento duplicado

            // Imprimir la lista
            Console.WriteLine("Lista con elementos duplicados: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void CustomFunction()
        {
            // Ejemplo 1: Uso de una contraseña débil
            string password = "12345";

            // Ejemplo 2: Vulnerabilidad de inyección de SQL
            string userInput = "admin' OR '1'='1";
            string query = "SELECT * FROM Users WHERE Username = '" + userInput + "'";

            // Ejemplo 3: Vulnerabilidad de desbordamiento de búfer
            string input = "12345678901234567890123456789012345678901234567890123456789012345678901234567890";

            // Imprimir resultados
            Console.WriteLine("Contraseña: " + password);
            Console.WriteLine("Consulta SQL: " + query);
            Console.WriteLine("Input: " + input);
        }

        // Método que recibe un arreglo
        public static void ReceiveArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        // Método que recibe una lista
        public static void ReceiveList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // Método que recibe un arreglo y un string
        public static void ReceiveArrayAndString(int[] array, string str)
        {
            Console.WriteLine("String: " + str);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public void VulnerableMethod(string userInput)
        {
            string query = "SELECT * FROM users WHERE name = '" + userInput + "';";

            // Ejecutar la consulta...
        }

        public void VulnerableXSSMethod(string userInput)
        {
            string htmlContent = "<div>" + userInput + "</div>";

            // Renderizar el contenido HTML...
        }
    }

}