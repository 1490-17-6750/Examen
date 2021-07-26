using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agexport.Tablas.NewFolder;
using Agexport.Tablas.Respuesta;
using Agexport.Tablas;
namespace Agexport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Mensajes oRespuesta = new Mensajes();
            oRespuesta.Exito = 0;
            try
            {
                using (FacturaContext db = new FacturaContext())

                {
                    var lst = db.Clientes.ToList();
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = lst;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);

         }
        [HttpPost]
        public IActionResult Add(ClienteRequest oModel)
        {
            Mensajes oRespuesta = new Mensajes();
         
            try
            {
                using (FacturaContext db = new FacturaContext())
                {
                    Cliente oCliente = new Cliente();
                    oCliente.Nombre = oModel.Nombre;
                    oCliente.Nit = oModel.Nit;
                    oCliente.Apellido = oModel.Apellido;
                    oCliente.Teléfono = oModel.Teléfono;
                    oCliente.Dirección = oModel.Dirección;
                    db.Clientes.Add(oCliente);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
                
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }


        [HttpPut]
        public IActionResult Editar(ClienteRequest oModel)
        {
            Mensajes oRespuesta = new Mensajes();

            try
            {
                using (FacturaContext db = new FacturaContext())
                {
                    Cliente oCliente = db.Clientes.Find(oModel.Nit);
                    oCliente.Nombre = oModel.Nombre;
                    oCliente.Nit = oModel.Nit;
                    oCliente.Apellido = oModel.Apellido;
                    oCliente.Teléfono = oModel.Teléfono;
                    oCliente.Dirección = oModel.Dirección;
                    db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }


        [HttpDelete]
        public IActionResult Eliminar(ClienteRequest oModel)
        {
            Mensajes oRespuesta = new Mensajes();

            try
            {
                using (FacturaContext db = new FacturaContext())
                {
                    Cliente oCliente = db.Clientes.Find(oModel.Nit);
                    db.Remove(oCliente);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }

            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }
    }   
}
