using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Models
{
   


    public class Destino
    {
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public int Id { get; set; }

        public int Calificacion;
        // Otros atributos relevantes

        public List<Destino> ObtenerDestinos()
        {

            return new List<Destino>
        {
            new Destino { Id = 1, Nombre = "Destino 1", Ubicacion="NA", Calificacion= 8},
            new Destino { Id = 2, Nombre = "Destino 2" ,Ubicacion="CA", Calificacion= 5},
            new Destino { Id = 3, Nombre = "Destino 3" ,Ubicacion="AS" , Calificacion= 7},
            new Destino { Id = 3, Nombre = "Destino 3" ,Ubicacion="AF", Calificacion = 5},
            new Destino { Id = 3, Nombre = "Destino 3" ,Ubicacion="SA", Calificacion = 8}
            //codigos NA(norteamerica), AS(Asia)
            //CA(Centro America), AF(Africa)
            // SA(Sur America)

            
        };

        }



        public List<Destino> FiltrarDestinosPorUbicacion(string ubicacion)
        {
            // Filtrar la lista de destinos por la ubicación especificada
            return ObtenerDestinos()
            .Where(d => d.Ubicacion == "NA").ToList();
        }

        public List<Destino> FiltrarDestinoPorNombre(string Nombre)
        {
            return ObtenerDestinos()
                .Where(d => d.Nombre == Nombre)
                .ToList();

        }


        public List<Destino> FiltrarDestinoPorID(int ID)
        {

            return ObtenerDestinos()
                .Where(d => d.Id == Id)
                .ToList();

        }

        public List<Destino> FiltrarDestinoPorCalificacion(int Calificacion)
        {

            return ObtenerDestinos()
                .Where(d => d.Calificacion == Calificacion)
                .ToList();

        }



        public class usuario
        {
            public string Usuario { get; set; }
            public int IdUsuario { get; set; }
            //pondremos un int como prioridad, 0:Invitados ,1: registrados, 2:administrador,  
            public int prioridad { get; set; }



            public List<usuario> ObtenerUsuarios()
            {

                return new List<usuario>

                {
                    new usuario { Usuario = "Invitado",IdUsuario= 1,prioridad=0},
                    new usuario { Usuario = "Registrado",IdUsuario= 1, prioridad = 1},
                    new usuario { Usuario = "Administrador",IdUsuario= 1, prioridad = 2},




                };




            }



        }

    



    }















}













