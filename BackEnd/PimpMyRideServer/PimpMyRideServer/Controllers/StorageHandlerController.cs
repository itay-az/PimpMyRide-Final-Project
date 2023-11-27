using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Handlers;
using PimpMyRideServer.Models;
using PimpMyRideServer.Server.Requests;

namespace PimpMyRideServer.Controllers
{
    [Route("/StorageHandler")]
    [ApiController]

    public class StorageHandlerController : GarageController
    {
        public StorageHandlerController() 
        {
            this.handler = new StorageHandler();
        }

        //cars controllers

        [HttpPost]
        public ActionResult CreateManufactureWithModel([FromBody] CreateManufactureAndModelRequest request)
        {
            return ((StorageHandler)handler).HandleCreate(request);
        }

        [HttpGet("{manufactureName}")]
        public ActionResult GetModelsByManufactureName(string manufactureName)
        {
            return ((StorageHandler)handler).HandlGetById(manufactureName);
        }

        [HttpGet]
        public ActionResult GetAllManufacturesAndModels()
        {
            return ((StorageHandler)handler).HandleGet();
        }

        [HttpGet("getManufactures")]
        public ActionResult GetManufactures()
        {
            return ((StorageHandler)handler).HandleGetManufacture();
        }
        [HttpDelete("removeModel/{manufactureName}/{modelName}")]
        public ActionResult DeleteModel(string modelName,string manufactureName)
        {
            return ((StorageHandler)handler).HandleDelete(manufactureName, modelName);
        }
        
        // parts controller
        
        [HttpPost("createNewPart")]
        public ActionResult createNewPart([FromBody] Part request)
        {
            return ((StorageHandler)handler).HandleCreatePart(request);
        }

        [HttpGet("getParts")]
        public ActionResult GetParts()
        {
            return ((StorageHandler)handler).HandleGetParts();
        }


        [HttpGet("getPart/{partId}")]
        public ActionResult GetPartById(string partId)
        {
            return ((StorageHandler)handler).HandleGetPartById(partId);
        }

        [HttpPut("updatePart/{partId}")]
        public ActionResult UpdatePartById(string partId ,[FromBody] Part part) 
        {
            return ((StorageHandler)handler).HandleUpdatePartById(partId, part);
        }

        [HttpDelete("deletePart/{partId}")]
        public ActionResult DeletePartById(string partId)
        {
            return ((StorageHandler)handler).HandleDeletePartById(partId);
        }

        [HttpGet("searchPart/{searchParameter}")]
        public ActionResult SearchPartByParameter(string searchParameter)
        {
            return ((StorageHandler)handler).HandleSearchByParameter(searchParameter);
        }



        // supplpliers controller

        [HttpPost("newSupplier")]
        public ActionResult CreateSupplier([FromBody] Suppliers supplier)
        {
            return ((StorageHandler)handler).HandleCreateSupplier(supplier);
        }

        [HttpGet("getAllSuppliers")]
        public ActionResult GetAllSuppliers()
        {
            return ((StorageHandler)handler).HandleGetAllSuppliers();
        }

        [HttpGet("getSupplierById/{supplierId}")]
        public ActionResult GetSupplierById(string supplierId)
        {
            return ((StorageHandler)handler).HandleGetSupplierById(supplierId);
        }

        [HttpPut("updateSupplier/{supplierId}")]
        public ActionResult UpdateSupplierById(string supplierId, [FromBody] Suppliers supplier)
        {
            return ((StorageHandler)handler).HandleUpdateSupplierById(supplierId, supplier);
        }

        [HttpDelete("deleteSupplierById/{supplierId}")]
        public ActionResult DeleteSupplierById(string supplierId) 
        {
            return ((StorageHandler)handler).HandleDeleteSupplierById(supplierId);
        }

        // orders controller


        [HttpPost("newOrder")]
        public ActionResult createOrder([FromBody] CreateNewOrderRequest order)
        {
            return ((StorageHandler)handler).HandleCreateOrder(order);
        }

        [HttpGet("getAllOrders")]
        public ActionResult GetAllOrders()
        {
            return (((StorageHandler)handler).HandleGetAllOrders());
        }

        [HttpGet("getOrderById/{orderId}")]
        public ActionResult GetOrderById(int orderId)
        {
            return (((StorageHandler)handler).HandleGetOrderById(orderId));
        }

        [HttpDelete("deleteOrderById/{orderId}")]
        public ActionResult HandleDeleteOrderById(int orderId)
        {
            return ((StorageHandler)handler).HandleDeleteOrderById(orderId);
        }
        


    }
}
